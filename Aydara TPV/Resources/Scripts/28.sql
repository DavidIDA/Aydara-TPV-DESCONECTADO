--Aydara TPV 16.04.01
ALTER TABLE TIENDAS ADD VentaCredito bit NULL, ControlTarjetas bit NULL, EtiquetaElectronica bit NULL, NumeroFactura1 int NULL, NumeroFactura2 int NULL, Comunicaciones_DirectorioFicheros nvarchar(max) NULL

GO

UPDATE TIENDAS SET EtiquetaElectronica = 0, ControlTarjetas = 0, NumeroFactura1 = 0, NumeroFactura2 = 0, Comunicaciones_DirectorioFicheros = ''

GO

ALTER TABLE ARTICULOS ADD CodigoBascula nvarchar(2) NULL, PLU int NULL, DtoFidelizacion decimal(18,4) NULL, 
EE_CodigoBarras nvarchar(13) NULL, EE_Formato int NULL, EE_Origen nvarchar(15) NULL, EE_Categoria nvarchar(10) NULL, EE_Calibre nvarchar(5) NULL

GO

UPDATE ARTICULOS SET CodigoBascula = '', DtoFidelizacion = 0, EE_CodigoBarras = '', EE_Formato = 0, EE_Origen = '', EE_Categoria = '', EE_Calibre = ''

GO

ALTER TABLE TICKETS ADD TipoFactura int NULL, FidelizacionImporte decimal(18, 2) NULL, FidelizacionVales decimal(18, 2) NULL, FidelizacionPuntos decimal(18, 2) NULL, 
FidelizacionLoteria decimal(18, 2) NULL, PuntosCanjeados decimal(18, 2) NULL, ValesCanjeados decimal(18, 2) NULL, ClienteCredito nvarchar(8) NULL

GO

UPDATE TICKETS SET TipoFactura = 0, FidelizacionImporte = 0, FidelizacionVales = 0, FidelizacionPuntos = 0, FidelizacionLoteria = 0, PuntosCanjeados = 0, ValesCanjeados = 0

GO

ALTER TABLE HISTORICO_TICKETS ADD TipoFactura int NULL, FidelizacionImporte decimal(18, 2) NULL, FidelizacionVales decimal(18, 2) NULL, FidelizacionPuntos decimal(18, 2) NULL, 
FidelizacionLoteria decimal(18, 2) NULL, PuntosCanjeados decimal(18, 2) NULL, ValesCanjeados decimal(18, 2) NULL, ClienteCredito nvarchar(8) NULL

GO

UPDATE HISTORICO_TICKETS SET TipoFactura = 0, FidelizacionImporte = 0, FidelizacionVales = 0, FidelizacionPuntos = 0, FidelizacionLoteria = 0, PuntosCanjeados = 0, ValesCanjeados = 0

GO

ALTER TABLE TICKETS_LINEAS ADD DtoFidelizacion decimal(18, 2) NULL

GO

UPDATE TICKETS_LINEAS SET DtoFidelizacion = 0

GO

ALTER TABLE HISTORICO_TICKETS_LINEAS ADD DtoFidelizacion decimal(18, 2) NULL

GO

UPDATE HISTORICO_TICKETS_LINEAS SET DtoFidelizacion = 0

GO

ALTER TABLE CLIENTES ADD ClienteCredito nvarchar(8) NULL, SaldoPuntos decimal(18,4) NULL

GO

UPDATE CLIENTES SET SaldoPuntos = 0

GO

CREATE TABLE [dbo].[TARIFAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Articulo_Id] [int] NULL,
	[Tarifa] [nvarchar](8) NULL,
	[Precio] [decimal](18, 4) NULL,
	[IvaIncluido] [bit] NULL,
 CONSTRAINT [PK_TARIFAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[CLICREDI](
	[Codigo] [nvarchar](8) NOT NULL,
	[NombreFiscal] [nvarchar](150) NULL,
	[NombreComercial] [nvarchar](150) NULL,
	[Direccion] [nvarchar](150) NULL,
	[CodigoPostal] [nvarchar](150) NULL,
	[Poblacion] [nvarchar](150) NULL,
	[Provincia] [nvarchar](150) NULL,
	[Nif] [nvarchar](15) NULL,
	[RecargoEquivalencia] [bit] NULL,
	[Tarifa] [nvarchar](8) NULL,
	[DescuentoPP] [decimal](18, 2) NULL,
 CONSTRAINT [PK_CLICREDI] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE SORTEOS ADD AplicaPromociones bit NULL

GO

UPDATE SORTEOS SET AplicaPromociones = 0