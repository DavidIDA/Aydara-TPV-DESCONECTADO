--Aydara TPV 15.12.01
ALTER PROCEDURE [dbo].[CrearTablaTemporal_Promociones]
AS
      
SET NOCOUNT ON

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[COMUNICACIONES_PROMOCIONES]') AND type in (N'U'))
DROP TABLE [dbo].[COMUNICACIONES_PROMOCIONES]

CREATE TABLE [dbo].[COMUNICACIONES_PROMOCIONES](
      [Id] [int] IDENTITY(1,1) NOT NULL,
      [CodigoTienda] [int] NULL,
      [CodigoArticulo] [nvarchar](7) COLLATE Modern_Spanish_CI_AS NULL,
      [CodigoColor] [int] NULL,
      [CodigoTalla] [int] NULL,
      [FechaInicio] [datetime] NULL,
      [FechaFinal] [datetime] NULL,
      [CodigoArticuloRegalo] [nvarchar](7) COLLATE Modern_Spanish_CI_AS NULL,
      [PrecioPromocion] [decimal](18, 4) NULL,
      [FraccionSinCargo] [decimal](18, 4) NULL,
      [UnidadesSinCargo] [decimal](18, 4) NULL,
      [PrecioArticuloRegalo] [decimal](18, 4) NULL,
      [NumeroAlmacen] [int] NULL,
      [NumeroTarifa] [int] NULL,
	  [Unidades] [decimal](18, 4) NULL
CONSTRAINT [PK_COMUNICACIONES_PROMOCIONES] PRIMARY KEY CLUSTERED 
(
      [Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

SET NOCOUNT OFF

GO

ALTER TABLE PROMOCIONES ADD [Unidades] [decimal](18, 4) NULL

GO

UPDATE PROMOCIONES SET Unidades = 0

GO

CREATE TABLE [dbo].[HISTORICO_INVENTARIO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Articulo_Id] [int] NULL,
	[CodigoTienda] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoTalla] [int] NULL,
	[Fecha] [datetime] NULL,
	[Cantidad] [decimal](18, 4) NULL
 CONSTRAINT [PK_HISTORICO_INVENTARIO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]