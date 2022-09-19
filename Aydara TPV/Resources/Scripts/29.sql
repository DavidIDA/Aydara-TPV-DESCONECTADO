CREATE PROCEDURE [dbo].[ImportarArticulos] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_ARTICULO]

CREATE TABLE [dbo].[SEQ_ARTICULO](
	[Codigo] [varchar](50) NULL,
	[Descripcion] [varchar](150) NULL,
	[TipoIva] [numeric](18, 0) NULL,
	[CodigoFamilia] [varchar](50) NULL,
	[CodigoSubfamilia] [varchar](50) NULL,
	[CodigoProveedor] [numeric](18, 0) NULL,
	[CodigoEnvase] [varchar](50) NULL,
	[ControlEtiquetas] [varchar](50) NULL,
	[CantidadVariable] [varchar](50) NULL,
	[ArticuloPeso] [varchar](50) NULL,
	[ControlBaja] [varchar](50) NULL,
	[TipoUnidad] [varchar](50) NULL,
	[UnidadesCaja] [varchar](50) NULL,
	[MinimoVenta] [varchar](50) NULL,
	[MinimoCompra] [varchar](50) NULL,
	[PesoUnidad] [varchar](50) NULL,
	[Descuento] [varchar](50) NULL,
	[PrecioCoste] [varchar](50) NULL,
	[Tarifa1] [varchar](50) NULL,
	[Tarifa2] [varchar](50) NULL,
	[Tarifa3] [varchar](50) NULL,
	[TipoArticulo] [varchar](50) NULL,
	[UnidadesPromo] [varchar](50) NULL,
	[PrecioPromo] [varchar](50) NULL,
	[PLU] [varchar](50) NULL,
	[Origen] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[Calibre] [varchar](50) NULL,
	[DtoFidelizacion] [varchar](50) NULL
) ON [PRIMARY]
	
declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_ARTICULO FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DECLARE @FORMATOTIENDA AS VARCHAR(1)
SET @FORMATOTIENDA = ISNULL((SELECT FormatoEmpresa FROM TIENDAS),'1')

DECLARE @TARIFATIENDA AS INT
SET @TARIFATIENDA = ISNULL((SELECT NumeroTarifa FROM TIENDAS),0)

DECLARE @ACTUALIZACOSTE AS BIT
SET @ACTUALIZACOSTE = ISNULL((SELECT ActualizaCosto FROM TIENDAS),0)

/*Etiquetas de artículos nuevos*/
INSERT INTO ETIQUETAS (CodigoArticulo, CodigoColor, CodigoTalla, Etiquetas)
SELECT SEQ_ARTICULO.Codigo, 0, 1, 1
FROM SEQ_ARTICULO LEFT JOIN ARTICULOS ON SEQ_ARTICULO.Codigo = ARTICULOS.Codigo
LEFT JOIN ETIQUETAS ON SEQ_ARTICULO.Codigo = ETIQUETAS.CodigoArticulo
WHERE SEQ_ARTICULO.ControlBaja = 'N' AND SEQ_ARTICULO.ControlEtiquetas = 'S' 
AND CAST(REPLACE(SEQ_ARTICULO.Tarifa1,',','.') AS DECIMAL(18,4)) <> ISNULL(ARTICULOS.Precio,0) 
AND ETIQUETAS.CodigoArticulo IS NULL

/*Actualizar artículos*/
UPDATE ARTICULOS
SET TipoIVA = SEQ_ARTICULO.TipoIVA, Descripcion = SEQ_ARTICULO.Descripcion, CodigoFamilia = FAMILIASARTICULOS.Id, CodigoSubfamilia = SUBFAMILIASARTICULOS.Id,
CodigoProveedor = SEQ_ARTICULO.CodigoProveedor, CodigoEnvase = SEQ_ARTICULO.CodigoEnvase, 
ControlEtiquetas = CASE SEQ_ARTICULO.ControlEtiquetas WHEN 'S' THEN 1 ELSE 0 END,
CantidadVariable = CASE SEQ_ARTICULO.CantidadVariable WHEN 'S' THEN 1 ELSE 0 END, 
ArticuloPeso = CASE SEQ_ARTICULO.ArticuloPeso WHEN 'S' THEN 1 ELSE 0 END, 
ControlBaja = CASE SEQ_ARTICULO.ControlBaja WHEN 'S' THEN 1 ELSE 0 END,
TipoUnidad_Id = TIPOS_UNIDADES.Id, 
UnidadCaja = CAST(REPLACE(SEQ_ARTICULO.UnidadesCaja,',','.') AS DECIMAL(18,4)), 
MinimoVenta = CAST(REPLACE(SEQ_ARTICULO.MinimoVenta,',','.') AS DECIMAL(18,4)), 
MinimoCompra = CAST(REPLACE(SEQ_ARTICULO.MinimoCompra,',','.') AS DECIMAL(18,4)),
PesoUnidad = CAST(REPLACE(SEQ_ARTICULO.PesoUnidad,',','.') AS DECIMAL(18,4)), 
Descuento = CAST(REPLACE(SEQ_ARTICULO.Descuento,',','.') AS DECIMAL(18,4)), 
PrecioCoste = CASE WHEN @ACTUALIZACOSTE = 1 AND SEQ_ARTICULO.TipoArticulo <> '5' THEN CAST(REPLACE(SEQ_ARTICULO.PrecioCoste,',','.') AS DECIMAL(18,4)) ELSE 0 END,
TipoArticulo = SEQ_ARTICULO.TipoArticulo, 
UnidadesPromocion = 0, 
PrecioPromocion = 0,
CodigoBascula = SUBSTRING(SEQ_ARTICULO.PLU,1,2),
PLU = SUBSTRING(SEQ_ARTICULO.PLU,3,3),
DtoFidelizacion = CAST(REPLACE(REPLACE(SEQ_ARTICULO.DtoFidelizacion,',','.'),'	','') AS DECIMAL(18,4)), 
EE_Origen = SEQ_ARTICULO.Origen, 
EE_Categoria = SEQ_ARTICULO.Categoria, 
EE_Calibre = SEQ_ARTICULO.Calibre
FROM (((ARTICULOS INNER JOIN SEQ_ARTICULO ON ARTICULOS.Codigo = SEQ_ARTICULO.Codigo)
LEFT JOIN FAMILIASARTICULOS ON SEQ_ARTICULO.CodigoFamilia = FAMILIASARTICULOS.Codigo)
LEFT JOIN SUBFAMILIASARTICULOS ON SEQ_ARTICULO.CodigoSubfamilia = SUBFAMILIASARTICULOS.Codigo AND SUBFAMILIASARTICULOS.Familia_Id = FAMILIASARTICULOS.Id)
LEFT JOIN TIPOS_UNIDADES ON SEQ_ARTICULO.TipoUnidad = TIPOS_UNIDADES.Codigo

/*Artículos nuevos*/
INSERT INTO ARTICULOS (Codigo, Descripcion, TipoIVA, CodigoFamilia, CodigoSubfamilia, CodigoProveedor, CodigoEnvase, Controletiquetas, CantidadVariable,
ArticuloPeso, Controlbaja, CodigoTalla, TipoUnidad_Id, UnidadCaja, MinimoVenta, MinimoCompra, PesoUnidad, Descuento, Precio, PrecioCoste, TipoArticulo, UnidadesPromocion, PrecioPromocion,
CodigoBascula, PLU, DtoFidelizacion, EE_CodigoBarras, EE_Formato, EE_Origen, EE_Categoria, EE_Calibre)
SELECT SEQ_ARTICULO.Codigo, SEQ_ARTICULO.Descripcion, SEQ_ARTICULO.TipoIVA, FAMILIASARTICULOS.Id, SUBFAMILIASARTICULOS.Id,
SEQ_ARTICULO.CodigoProveedor, SEQ_ARTICULO.CodigoEnvase, 
CASE SEQ_ARTICULO.ControlEtiquetas WHEN 'S' THEN 1 ELSE 0 END, 
CASE SEQ_ARTICULO.CantidadVariable WHEN 'S' THEN 1 ELSE 0 END,
CASE SEQ_ARTICULO.ArticuloPeso WHEN 'S' THEN 1 ELSE 0 END, 
CASE SEQ_ARTICULO.ControlBaja WHEN 'S' THEN 1 ELSE 0 END, 
1, TIPOS_UNIDADES.Id, 
CAST(REPLACE(SEQ_ARTICULO.UnidadesCaja,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(SEQ_ARTICULO.MinimoVenta,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(SEQ_ARTICULO.MinimoCompra,',','.') AS DECIMAL(18,4)),
CAST(REPLACE(SEQ_ARTICULO.PesoUnidad,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(SEQ_ARTICULO.Descuento,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(SEQ_ARTICULO.Tarifa1,',','.') AS DECIMAL(18,4)),
0,
SEQ_ARTICULO.TipoArticulo, 
0, 
0,
SUBSTRING(SEQ_ARTICULO.PLU,1,2), SUBSTRING(SEQ_ARTICULO.PLU,3,3), 
CAST(REPLACE(REPLACE(SEQ_ARTICULO.DtoFidelizacion,',','.'),'	','') AS DECIMAL(18,4)), 
'', 0, SEQ_ARTICULO.Origen, SEQ_ARTICULO.Categoria, SEQ_ARTICULO.Calibre
FROM ((SEQ_ARTICULO
LEFT JOIN FAMILIASARTICULOS ON SEQ_ARTICULO.CodigoFamilia = FAMILIASARTICULOS.Codigo)
LEFT JOIN SUBFAMILIASARTICULOS ON SEQ_ARTICULO.CodigoSubfamilia = SUBFAMILIASARTICULOS.Codigo AND SUBFAMILIASARTICULOS.Familia_Id = FAMILIASARTICULOS.Id)
LEFT JOIN TIPOS_UNIDADES ON SEQ_ARTICULO.TipoUnidad = TIPOS_UNIDADES.Codigo
LEFT JOIN ARTICULOS ON SEQ_ARTICULO.Codigo = ARTICULOS.Codigo
WHERE ARTICULOS.Codigo IS NULL

/*Existencias artículos nuevos*/
INSERT INTO EXISTENCIAS (Articulo_Id, CodigoTienda, CodigoColor, CodigoTalla, ExistenciaInicial, ExistenciaActual, StockMinimo, StockMaximo, PrecioVenta)
SELECT Articulo_Id = ARTICULOS.Id, 1, 0, 1, 0, 0, 0, 0, 0
FROM ARTICULOS INNER JOIN SEQ_ARTICULO ON ARTICULOS.Codigo = SEQ_ARTICULO.Codigo
LEFT JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id
WHERE EXISTENCIAS.Articulo_Id IS NULL

/*Actualizar tarifas*/
IF @FORMATOTIENDA = 1
	BEGIN
		UPDATE ARTICULOS
		SET Precio = CAST(REPLACE(SEQ_ARTICULO.Tarifa1,',','.') AS DECIMAL(18,4))
		FROM ARTICULOS INNER JOIN SEQ_ARTICULO ON ARTICULOS.Codigo = SEQ_ARTICULO.Codigo
	END
IF @FORMATOTIENDA = 2
	BEGIN
		UPDATE ARTICULOS
		SET Precio = CASE @TARIFATIENDA WHEN 4 THEN CAST(REPLACE(SEQ_ARTICULO.Tarifa1,',','.') AS DECIMAL(18,4)) WHEN 6 THEN CAST(REPLACE(SEQ_ARTICULO.Tarifa2,',','.') AS DECIMAL(18,4)) WHEN 10 THEN CAST(REPLACE(SEQ_ARTICULO.Tarifa3,',','.') AS DECIMAL(18,4)) ELSE 0 END
		FROM ARTICULOS INNER JOIN SEQ_ARTICULO ON ARTICULOS.Codigo = SEQ_ARTICULO.Codigo
	END
IF @FORMATOTIENDA = 3
	BEGIN
		UPDATE ARTICULOS
		SET Precio = CASE @TARIFATIENDA WHEN 4 THEN CAST(REPLACE(SEQ_ARTICULO.Tarifa1,',','.') AS DECIMAL(18,4)) WHEN 5 THEN CAST(REPLACE(SEQ_ARTICULO.Tarifa2,',','.') AS DECIMAL(18,4)) WHEN 8 THEN CAST(REPLACE(SEQ_ARTICULO.Tarifa3,',','.') AS DECIMAL(18,4)) ELSE 0 END
		FROM ARTICULOS INNER JOIN SEQ_ARTICULO ON ARTICULOS.Codigo = SEQ_ARTICULO.Codigo
	END

/*Descuento sobre tarifa*/
DECLARE @DTOTARIFA AS DECIMAL(18,2)
SET @DTOTARIFA = ISNULL((SELECT DtoSobreTarifa FROM TIENDAS),0)

IF @DTOTARIFA <> 0
BEGIN
		UPDATE ARTICULOS
		SET Precio = ROUND(Precio - (Precio * @DTOTARIFA / 100), 2)
		FROM ARTICULOS INNER JOIN SEQ_ARTICULO ON ARTICULOS.Codigo = SEQ_ARTICULO.Codigo
	END
	
END

GO

CREATE PROCEDURE [dbo].[ImportarClientes] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_CLIENTES]

CREATE TABLE [dbo].[SEQ_CLIENTES](
	[NumTarjeta] [varchar](50) NULL,
	[Nombre] [varchar](150) NULL,
	[Direccion] [varchar](150) NULL,
	[CodigoPostal] [varchar](50) NULL,
	[Poblacion] [varchar](150) NULL,
	[Provincia] [varchar](150) NULL,
	[Telefonos] [varchar](50) NULL,
	[NIF] [varchar](50) NULL,
	[Bloqueada] [varchar](50) NULL,
	[FechaCaducidad] [varchar](50) NULL,
	[Descuento] [varchar](50) NULL,
	[VentaCredito] [varchar](50) NULL,
	[ClienteCredito] [varchar](50) NULL,
	[SaldoPuntos] [varchar](50) NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_CLIENTES FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

/*Actualizar clientes*/
UPDATE CLIENTES
SET NombreFiscal = SEQ_CLIENTES.Nombre, Direccion = SEQ_CLIENTES.Direccion, CodigoPostal = SEQ_CLIENTES.CodigoPostal, Poblacion = SEQ_CLIENTES.Poblacion,
Provincia = SEQ_CLIENTES.Provincia, CIF = SEQ_CLIENTES.NIF, TelParticular = SEQ_CLIENTES.Telefonos,
ControlBaja = CASE SEQ_CLIENTES.Bloqueada WHEN 'S' THEN 1 ELSE 0 END, TieneTarjeta = 1, CaducidadTarjeta = SEQ_CLIENTES.FechaCaducidad, 
DescuentoTarjeta = CAST(REPLACE(SEQ_CLIENTES.Descuento,',','.') AS DECIMAL(18,4)),
AlbaranCredito = CASE SEQ_CLIENTES.VentaCredito WHEN 'S' THEN 1 ELSE 0 END, ClienteCredito = CASE LTRIM(RTRIM(SEQ_CLIENTES.ClienteCredito)) WHEN '' THEN NULL ELSE SEQ_CLIENTES.ClienteCredito END, 
SaldoPuntos = CAST(REPLACE(REPLACE(SEQ_CLIENTES.SaldoPuntos,',','.'),'	','') AS DECIMAL(18,4))
FROM CLIENTES INNER JOIN SEQ_CLIENTES ON CLIENTES.Codigo = SEQ_CLIENTES.NumTarjeta

/*Nuevos clientes*/
INSERT INTO CLIENTES (Codigo, NombreFiscal, Direccion, CodigoPostal, Poblacion, Provincia, CIF, TelParticular, ControlBaja, TieneTarjeta, CaducidadTarjeta, DescuentoTarjeta, AlbaranCredito, ClienteCredito, SaldoPuntos)
SELECT NumTarjeta, Nombre, Direccion, CodigoPostal, Poblacion, Provincia, NIF, Telefonos, CASE SEQ_CLIENTES.Bloqueada WHEN 'S' THEN 1 ELSE 0 END, 1, FechaCaducidad,
CAST(REPLACE(Descuento,',','.') AS DECIMAL(18,4)),
CASE SEQ_CLIENTES.VentaCredito WHEN 'S' THEN 1 ELSE 0 END, CASE LTRIM(RTRIM(ClienteCredito)) WHEN '' THEN NULL ELSE ClienteCredito END, 
CAST(REPLACE(REPLACE(SEQ_CLIENTES.SaldoPuntos,',','.'),'	','') AS DECIMAL(18,4))
FROM SEQ_CLIENTES
WHERE NumTarjeta NOT IN (SELECT Codigo FROM CLIENTES)

END

GO

CREATE PROCEDURE [dbo].[ImportarClientesCredito] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_CLICREDI]

CREATE TABLE [dbo].[SEQ_CLICREDI](
	[Codigo] [varchar](50) NULL,
	[NombreFiscal] [varchar](150) NULL,
	[NombreComercial] [varchar](150) NULL,
	[Direccion] [varchar](150) NULL,
	[CodigoPostal] [varchar](50) NULL,
	[Poblacion] [varchar](150) NULL,
	[Provincia] [varchar](150) NULL,
	[NIF] [varchar](50) NULL,
	[RecargoEquivalencia] [varchar](50) NULL,
	[Tarifa] [varchar](50) NULL,
	[DtoPP] [varchar](50) NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_CLICREDI FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DELETE FROM CLICREDI

INSERT INTO CLICREDI (Codigo, NombreFiscal, NombreComercial, Direccion , CodigoPostal, Poblacion, Provincia, Nif, RecargoEquivalencia, Tarifa, DescuentoPP)
SELECT Codigo, NombreFiscal, NombreComercial, Direccion , CodigoPostal, Poblacion, Provincia, Nif, CASE RecargoEquivalencia WHEN 'S' THEN 1 ELSE 0 END, Tarifa, 
CAST(REPLACE(REPLACE(DtoPP,',','.'),'	','') AS DECIMAL(18,4))
FROM SEQ_CLICREDI

END

GO

CREATE PROCEDURE [dbo].[ImportarCodigosBarras] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_COBARRAS]

CREATE TABLE [dbo].[SEQ_COBARRAS](
	[CodigoBarras] [varchar](50) NULL,
	[CodigoArticulo] [varchar](50) NULL,
	[Vacio] [varchar](50) NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_COBARRAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DELETE FROM CODIGO_BARRAS

INSERT INTO CODIGO_BARRAS (CodigoBarras, Articulo_Id)
SELECT SEQ_COBARRAS.CodigoBarras, ARTICULOS.Id
FROM ARTICULOS INNER JOIN SEQ_COBARRAS ON ARTICULOS.Codigo = SEQ_COBARRAS.CodigoArticulo
LEFT JOIN CODIGO_BARRAS ON SEQ_COBARRAS.CodigoBarras = CODIGO_BARRAS.CodigoBarras
WHERE CODIGO_BARRAS.CodigoBarras IS NULL

END

GO

CREATE PROCEDURE [dbo].[ImportarFamilias] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;
	
DROP TABLE [dbo].[SEQ_FAMILIAS]

CREATE TABLE [dbo].[SEQ_FAMILIAS](
	[CodigoFamilia] [varchar](50) NULL,
	[CodigoSubfamilia] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[DtoTarjeta] [varchar](50) NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_FAMILIAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

/*Actualizar familias*/
UPDATE FAMILIASARTICULOS
SET Descripcion = SEQ_FAMILIAS.Descripcion, 
DescuentoTarjeta = CAST(REPLACE(REPLACE(SEQ_FAMILIAS.DtoTarjeta,',','.'),'	','') AS DECIMAL(18,4))
FROM FAMILIASARTICULOS INNER JOIN SEQ_FAMILIAS ON FAMILIASARTICULOS.Codigo = SEQ_FAMILIAS.CodigoFamilia
WHERE CodigoSubfamilia=''

/*Nuevas familias*/
INSERT INTO FAMILIASARTICULOS (Codigo, Descripcion, DescuentoTarjeta)
SELECT SEQ_FAMILIAS.CodigoFamilia, SEQ_FAMILIAS.Descripcion, 
CAST(REPLACE(REPLACE(SEQ_FAMILIAS.DtoTarjeta,',','.'),'	','') AS DECIMAL(18,4))
FROM SEQ_FAMILIAS
WHERE CodigoSubfamilia='' AND CodigoFamilia NOT IN (SELECT Codigo FROM FAMILIASARTICULOS)

/*Actualizar subfamilias*/
UPDATE SUBFAMILIASARTICULOS
SET Descripcion = SEQ_FAMILIAS.Descripcion, 
DescuentoTarjeta = CAST(REPLACE(REPLACE(SEQ_FAMILIAS.DtoTarjeta,',','.'),'	','') AS DECIMAL(18,4))
FROM (FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id = SUBFAMILIASARTICULOS.Familia_Id) INNER JOIN SEQ_FAMILIAS
ON FAMILIASARTICULOS.Codigo = SEQ_FAMILIAS.CodigoFamilia AND SUBFAMILIASARTICULOS.Codigo = SEQ_FAMILIAS.CodigoSubFamilia
WHERE CodigoSubfamilia<>''

/*Nuevas subfamilias*/
INSERT INTO SUBFAMILIASARTICULOS (Familia_Id, Codigo, Descripcion, DescuentoTarjeta)
SELECT FAMILIASARTICULOS.Id, SEQ_FAMILIAS.CodigoSubfamilia, SEQ_FAMILIAS.Descripcion, 
CAST(REPLACE(REPLACE(SEQ_FAMILIAS.DtoTarjeta,',','.'),'	','') AS DECIMAL(18,4))
FROM SEQ_FAMILIAS INNER JOIN FAMILIASARTICULOS ON SEQ_FAMILIAS.CodigoFamilia = FAMILIASARTICULOS.Codigo
WHERE CodigoSubfamilia<>'' AND CodigoSubfamilia NOT IN (SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id = FAMILIASARTICULOS.Id)

END

GO

CREATE PROCEDURE [dbo].[ImportarPromociones] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_PROMOCIO]

CREATE TABLE [dbo].[SEQ_PROMOCIO](
	[CodigoArticulo] [varchar](50) NULL,
	[Tienda] [varchar](50) NULL,
	[Tarifa] [varchar](50) NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[Precio] [varchar](50) NULL,
	[Unidades] [varchar](50) NULL,
	[ArticuloRegalo] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_PROMOCIO FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DECLARE @FORMATOTIENDA AS VARCHAR(1)
SET @FORMATOTIENDA = ISNULL((SELECT FormatoEmpresa FROM TIENDAS),'1')

DECLARE @NUMEROALMACEN AS INT
SET @NUMEROALMACEN = (SELECT NumeroAlmacen FROM TIENDAS)

DECLARE @TIPOTIENDA AS INT
SET @TIPOTIENDA = (SELECT TipoTienda FROM TIENDAS)

DECLARE @TARIFATIENDA AS INT
SET @TARIFATIENDA = (SELECT NumeroTarifa FROM TIENDAS)

/*Eliminar caducadas*/
DELETE PROMOCIONES WHERE FechaFinal < GETDATE() OR NumeroTarifa <> 0

/*Nuevas promociones*/
INSERT INTO PROMOCIONES (CodigoTienda, CodigoArticulo, FechaInicio, FechaFinal, Unidades, PrecioPromocion, CodigoArticuloRegalo, FraccionSinCargo, UnidadesSinCargo, PrecioArticuloRegalo, NumeroAlmacen, NumeroTarifa)
SELECT 1, SEQ_PROMOCIO.CodigoArticulo, SEQ_PROMOCIO.FechaInicio, DATEADD(s,-1,DATEADD(d,1,SEQ_PROMOCIO.FechaFin)), 
CAST(REPLACE(SEQ_PROMOCIO.Unidades,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(ISNULL(PROMOTIENDA.Precio, SEQ_PROMOCIO.Precio),',','.') AS DECIMAL(18,4)), 
LTRIM(RTRIM(REPLACE(SEQ_PROMOCIO.ArticuloRegalo,'	',''))), 0, 0, 0,
CASE ISNULL(PROMOTIENDA.Tienda, SEQ_PROMOCIO.Tienda) WHEN 'TD' THEN 0 ELSE ISNULL(PROMOTIENDA.Tienda, SEQ_PROMOCIO.Tienda) END, ISNULL(PROMOTIENDA.Tienda,SEQ_PROMOCIO.Tarifa) 
FROM SEQ_PROMOCIO LEFT JOIN SEQ_PROMOCIO AS PROMOTIENDA 
ON SEQ_PROMOCIO.CodigoArticulo = PROMOTIENDA.CodigoArticulo
AND SEQ_PROMOCIO.Tarifa = PROMOTIENDA.Tarifa
AND SEQ_PROMOCIO.FechaInicio = PROMOTIENDA.FechaInicio
AND SEQ_PROMOCIO.FechaFin = PROMOTIENDA.FechaFin
AND CASE PROMOTIENDA.Tienda WHEN 'TD' THEN 0 ELSE PROMOTIENDA.Tienda END = @NUMEROALMACEN
WHERE SEQ_PROMOCIO.TARIFA = @TARIFATIENDA

/*CALAVIA: Actualizar promociones con tarifa 10*/
IF @FORMATOTIENDA = 2
BEGIN
	
	UPDATE PROMOCIONES
	SET PrecioPromocion = 0
	FROM PROMOCIONES INNER JOIN SEQ_PROMOCIO 
	ON PROMOCIONES.CodigoArticulo = SEQ_PROMOCIO.CodigoArticulo 
	AND PROMOCIONES.FechaInicio = SEQ_PROMOCIO.FechaInicio 
	AND PROMOCIONES.FechaFinal = DATEADD(s,-1,DATEADD(d,1,SEQ_PROMOCIO.FechaFin))
	AND Tienda = 'TD' AND Tarifa = '10'

	UPDATE PROMOCIONES
	SET PrecioPromocion = 0
	FROM PROMOCIONES INNER JOIN SEQ_PROMOCIO 
	ON PROMOCIONES.CodigoArticulo = SEQ_PROMOCIO.CodigoArticulo 
	AND PROMOCIONES.FechaInicio = SEQ_PROMOCIO.FechaInicio 
	AND PROMOCIONES.FechaFinal = DATEADD(s,-1,DATEADD(d,1,SEQ_PROMOCIO.FechaFin))
	AND Tienda = @NUMEROALMACEN AND Tarifa = '10'

	END

END

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ImportarTarifas] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_TARIFAS]

CREATE TABLE [dbo].[SEQ_TARIFAS](
	[CodigoArticulo] [varchar](50) NULL,
	[Tarifa] [varchar](50) NULL,
	[Precio] [varchar](50) NULL,
	[IvaIncluido] [varchar](50) NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_TARIFAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DELETE FROM TARIFAS

DBCC CHECKIDENT(TARIFAS,RESEED,1)

INSERT INTO TARIFAS (Articulo_Id, Tarifa, Precio, IvaIncluido)
SELECT ARTICULOS.Id, SEQ_TARIFAS.Tarifa, 
CAST(REPLACE(SEQ_TARIFAS.Precio,',','.') AS DECIMAL(18,4)), 
CASE SUBSTRING(LTRIM(RTRIM(SEQ_TARIFAS.IvaIncluido)),1,1) WHEN 'S' THEN 1 ELSE 0 END
FROM SEQ_TARIFAS
INNER JOIN ARTICULOS ON SEQ_TARIFAS.CodigoArticulo = ARTICULOS.Codigo

END

GO

CREATE PROCEDURE [dbo].[ImportarInventario] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_INVENTARIO]

CREATE TABLE [dbo].[SEQ_INVENTARIO](
	[CodigoArticulo] [varchar](50) NULL,
	[ExistenciaActual] [varchar](50) NULL,
	[StockMinimo] [varchar](50) NULL,
	[StockMaximo] [varchar](50) NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_INVENTARIO FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

UPDATE EXISTENCIAS
SET ExistenciaActual = CASE IsNumeric(SEQ_INVENTARIO.ExistenciaActual) WHEN 1 THEN CAST(REPLACE(SEQ_INVENTARIO.ExistenciaActual,',','.') AS DECIMAL(18,4)) ELSE EXISTENCIAS.ExistenciaActual END, 
StockMinimo = CASE WHEN EXISTENCIAS.StockMinimo = 0 THEN CAST(REPLACE(SEQ_INVENTARIO.StockMinimo,',','.') AS DECIMAL(18,4)) ELSE EXISTENCIAS.StockMinimo END,
StockMaximo = CASE WHEN EXISTENCIAS.StockMinimo = 0 THEN CAST(REPLACE(LTRIM(RTRIM(REPLACE(SEQ_INVENTARIO.StockMaximo,'	',''))),',','.') AS DECIMAL(18,4)) ELSE EXISTENCIAS.StockMaximo END
FROM (ARTICULOS INNER JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id)
INNER JOIN SEQ_INVENTARIO ON ARTICULOS.Codigo = SEQ_INVENTARIO.CodigoArticulo
WHERE EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1

END

GO

CREATE PROCEDURE [dbo].[ImportarEntradas] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_ENTRADAS]

CREATE TABLE [dbo].[SEQ_ENTRADAS](
	[CodigoArticulo] [varchar](50) NULL,
	[Cantidad] [varchar](50) NULL,
	[Precio] [varchar](50) NULL,
	[Numeroalbaran] [varchar](50) NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_ENTRADAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\r'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DELETE SEQ_ENTRADAS
FROM (ALBARANES_COMPRAS INNER JOIN SEQ_ENTRADAS ON ALBARANES_COMPRAS.NumeroAlbaran = LTRIM(RTRIM(REPLACE(SEQ_ENTRADAS.NumeroAlbaran,'	',''))))
INNER JOIN ALBARANES_COMPRAS_LINEAS ON ALBARANES_COMPRAS.Id = ALBARANES_COMPRAS_LINEAS.AlbaranCompra_Id
WHERE ALBARANES_COMPRAS_LINEAS.CodigoArticulo = SEQ_ENTRADAS.CodigoArticulo
AND ALBARANES_COMPRAS_LINEAS.Cantidad = SEQ_ENTRADAS.Cantidad

INSERT INTO ALBARANES_COMPRAS (CodigoTienda, Numeroalbaran, Fecha, CodigoProveedor, NombreProveedor, Observaciones)
SELECT 1, LTRIM(RTRIM(REPLACE(SEQ_ENTRADAS.NumeroAlbaran,'	',''))), GETDATE(), 1, (SELECT NombreFiscal FROM TIENDAS), 'Importación fichero'
FROM SEQ_ENTRADAS WHERE LTRIM(RTRIM(REPLACE(SEQ_ENTRADAS.NumeroAlbaran,'	',''))) NOT IN (SELECT Numeroalbaran FROM ALBARANES_COMPRAS)
GROUP BY LTRIM(RTRIM(REPLACE(SEQ_ENTRADAS.NumeroAlbaran,'	','')))

INSERT INTO ALBARANES_COMPRAS_LINEAS (AlbaranCompra_Id, CodigoArticulo, Descripcion, Cantidad, Precio, Descuento, Total, Observaciones)
SELECT ALBARANES_COMPRAS.Id, SEQ_ENTRADAS.CodigoArticulo, ARTICULOS.Descripcion, 
CAST(REPLACE(SEQ_ENTRADAS.Cantidad,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(SEQ_ENTRADAS.Precio,',','.') AS DECIMAL(18,4)), 
0, 
CAST(REPLACE(SEQ_ENTRADAS.Cantidad,',','.') AS DECIMAL(18,4)) * CAST(REPLACE(SEQ_ENTRADAS.Precio,',','.') AS DECIMAL(18,4)), 
''
FROM (ALBARANES_COMPRAS INNER JOIN SEQ_ENTRADAS ON ALBARANES_COMPRAS.NumeroAlbaran = LTRIM(RTRIM(REPLACE(SEQ_ENTRADAS.NumeroAlbaran,'	',''))))
INNER JOIN ARTICULOS ON SEQ_ENTRADAS.CodigoArticulo = ARTICULOS.Codigo

UPDATE EXISTENCIAS
SET ExistenciaActual = ExistenciaActual + CAST(REPLACE(SEQ_ENTRADAS.Cantidad,',','.') AS DECIMAL(18,4))
FROM (SEQ_ENTRADAS INNER JOIN ARTICULOS ON SEQ_ENTRADAS.CodigoArticulo = ARTICULOS.Codigo)
INNER JOIN EXISTENCIAS ON EXISTENCIAS.Articulo_Id = ARTICULOS.Id
WHERE EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1

END

GO

CREATE TABLE [dbo].[ETIQUETAS_ELECTRONICAS](
	[CodigoBarras] [varchar](50) NOT NULL,
	[CodigoArticulo] [varchar](7) NULL,
	[Descripcion] [varchar](50) NULL,
	[Formato] [int] NULL,
	[Origen] [varchar](15) NULL,
	[Categoria] [varchar](10) NULL,
	[Calibre] [varchar](5) NULL,
	[Precio] [decimal](18, 4) NULL,
	[Envio] [bit] NULL,
	[FechaFinPromo] [datetime] NULL,
 CONSTRAINT [PK_ETIQUETAS_ELECTRONICAS] PRIMARY KEY CLUSTERED 
(
	[CodigoBarras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TRIGGER [dbo].[TgrEnvioEtiqueta] 
   ON  [dbo].[ARTICULOS]
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
   	/*Añadir código de barras si no existe*/
	INSERT INTO ETIQUETAS_ELECTRONICAS (CodigoBarras, CodigoArticulo, Descripcion, Formato, Origen, Categoria, Calibre, Precio, FechaFinPromo, Envio)
	SELECT INSERTED.EE_CodigoBarras, INSERTED.Codigo, INSERTED.Descripcion, INSERTED.EE_Formato, INSERTED.EE_Origen, INSERTED.EE_Categoria, INSERTED.EE_Calibre, ISNULL(PROMOCIONES.PrecioPromocion,INSERTED.Precio), PROMOCIONES.FechaFinal, 1
	FROM INSERTED 
	INNER JOIN CODIGO_BARRAS ON INSERTED.Id = CODIGO_BARRAS.Articulo_Id AND CODIGO_BARRAS.CodigoBarras = INSERTED.EE_CodigoBarras
	LEFT JOIN PROMOCIONES ON INSERTED.Codigo = PROMOCIONES.CodigoArticulo AND GETDATE() BETWEEN PROMOCIONES.FechaInicio AND PROMOCIONES.FechaFinal AND PROMOCIONES.PrecioPromocion <> 0
	WHERE ISNULL(INSERTED.EE_CodigoBarras,'') <> '' AND INSERTED.EE_CodigoBarras NOT IN (SELECT CodigoBarras FROM ETIQUETAS_ELECTRONICAS)

	/*Actualizar etiqueta si existen cambios*/
	UPDATE ETIQUETAS_ELECTRONICAS
	SET CodigoBarras = INSERTED.EE_CodigoBarras, CodigoArticulo = INSERTED.Codigo, Descripcion = INSERTED.Descripcion, Formato = INSERTED.EE_Formato, 
	Origen = INSERTED.EE_Origen, Categoria = INSERTED.EE_Categoria, Calibre = INSERTED.EE_Calibre, Precio = ISNULL(PROMOCIONES.PrecioPromocion,INSERTED.Precio), FechaFinPromo = PROMOCIONES.FechaFinal, Envio = 1
	FROM INSERTED 
	INNER JOIN ETIQUETAS_ELECTRONICAS ON INSERTED.EE_CodigoBarras = ETIQUETAS_ELECTRONICAS.CodigoBarras
	INNER JOIN CODIGO_BARRAS ON INSERTED.Id = CODIGO_BARRAS.Articulo_Id AND CODIGO_BARRAS.CodigoBarras = INSERTED.EE_CodigoBarras
	LEFT JOIN PROMOCIONES ON INSERTED.Codigo = PROMOCIONES.CodigoArticulo AND GETDATE() BETWEEN PROMOCIONES.FechaInicio AND PROMOCIONES.FechaFinal AND PROMOCIONES.PrecioPromocion <> 0
	WHERE ISNULL(INSERTED.EE_CodigoBarras,'') <> ''
	AND (INSERTED.Descripcion <> ETIQUETAS_ELECTRONICAS.Descripcion
	OR ISNULL(PROMOCIONES.PrecioPromocion,INSERTED.Precio) <> ETIQUETAS_ELECTRONICAS.Precio
	OR INSERTED.EE_Formato <> ETIQUETAS_ELECTRONICAS.Formato
	OR INSERTED.EE_CodigoBarras <> ETIQUETAS_ELECTRONICAS.CodigoBarras
	OR INSERTED.EE_Origen <> ETIQUETAS_ELECTRONICAS.Origen
	OR INSERTED.EE_Categoria <> ETIQUETAS_ELECTRONICAS.Categoria
	OR INSERTED.EE_Calibre <> ETIQUETAS_ELECTRONICAS.Calibre)

END

GO

CREATE TRIGGER [dbo].[TgrEnvioEtiquetaPromocion] 
   ON  [dbo].[PROMOCIONES]
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	/*Añadir código de barras si no existe*/
	INSERT INTO ETIQUETAS_ELECTRONICAS (CodigoBarras, CodigoArticulo, Descripcion, Formato, Origen, Categoria, Calibre, Precio, FechaFinPromo, Envio)
	SELECT EE_CodigoBarras, Codigo, Descripcion, EE_Formato, EE_Origen, EE_Categoria, EE_Calibre, INSERTED.PrecioPromocion, INSERTED.FechaFinal, 1
	FROM INSERTED INNER JOIN ARTICULOS ON INSERTED.CodigoArticulo = ARTICULOS.Codigo
	INNER JOIN CODIGO_BARRAS ON ARTICULOS.Id = CODIGO_BARRAS.Articulo_Id AND CODIGO_BARRAS.CodigoBarras = ARTICULOS.EE_CodigoBarras
	WHERE ARTICULOS.EE_CodigoBarras NOT IN (SELECT CodigoBarras FROM ETIQUETAS_ELECTRONICAS WHERE CodigoBarras = ARTICULOS.EE_CodigoBarras)

	/*Actualizar etiqueta si existen cambios*/
	UPDATE ETIQUETAS_ELECTRONICAS
	SET CodigoBarras = ARTICULOS.EE_CodigoBarras, CodigoArticulo = ARTICULOS.Codigo, Descripcion = ARTICULOS.Descripcion, Formato = ARTICULOS.EE_Formato, 
	Origen = ARTICULOS.EE_Origen, Categoria = ARTICULOS.EE_Categoria, Calibre = ARTICULOS.EE_Calibre, Precio = INSERTED.PrecioPromocion, FechaFinPromo = INSERTED.FechaFinal, Envio = 1
	FROM INSERTED INNER JOIN ARTICULOS ON INSERTED.CodigoArticulo = ARTICULOS.Codigo
	INNER JOIN ETIQUETAS_ELECTRONICAS ON ARTICULOS.EE_CodigoBarras = ETIQUETAS_ELECTRONICAS.CodigoBarras
	INNER JOIN CODIGO_BARRAS ON ARTICULOS.Id = CODIGO_BARRAS.Articulo_Id AND CODIGO_BARRAS.CodigoBarras = ARTICULOS.EE_CodigoBarras
	WHERE (ARTICULOS.Descripcion <> ETIQUETAS_ELECTRONICAS.Descripcion
	OR INSERTED.PrecioPromocion <> ETIQUETAS_ELECTRONICAS.Precio
	OR ARTICULOS.EE_Formato <> ETIQUETAS_ELECTRONICAS.Formato
	OR ARTICULOS.EE_CodigoBarras <> ETIQUETAS_ELECTRONICAS.CodigoBarras
	OR ARTICULOS.EE_Origen <> ETIQUETAS_ELECTRONICAS.Origen
	OR ARTICULOS.EE_Categoria <> ETIQUETAS_ELECTRONICAS.Categoria
	OR ARTICULOS.EE_Calibre <> ETIQUETAS_ELECTRONICAS.Calibre)
	
END