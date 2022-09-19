--Aydara TPV  13.1.11
ALTER PROCEDURE [dbo].[CrearTablaTemporal_Articulos]
AS
	SET NOCOUNT ON;

	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[COMUNICACIONES_ARTICULOS]') AND type in (N'U'))
	DROP TABLE [dbo].[COMUNICACIONES_ARTICULOS]

	CREATE TABLE [dbo].[COMUNICACIONES_ARTICULOS](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Codigo] [nvarchar](7) COLLATE Modern_Spanish_CI_AS NOT NULL,
		[Descripcion] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
		[TipoIva] [int] NULL,
		[CodigoFamilia] [nvarchar](15) COLLATE Modern_Spanish_CI_AS NULL,
		[CodigoSubfamilia] [nvarchar](15) COLLATE Modern_Spanish_CI_AS NULL,
		[CodigoProveedor] [int] NULL,
		[CodigoEnvase] [nvarchar](7) COLLATE Modern_Spanish_CI_AS NULL,
		[ControlEtiquetas] [bit] NULL,
		[CantidadVariable] [bit] NULL,
		[ControlBaja] [bit] NULL,
		[CodigoTalla] [int] NULL,
		[FechaAlta] [datetime] NULL,
		[UnidadCaja] [int] NULL,
		[MinimoVenta] [int] NULL,
		[MinimoCompra] [int] NULL,
		[PesoUnidad] [decimal](18, 4) NULL,
		[Descuento] [decimal](18, 4) NULL,
		[Precio] [decimal](18, 4) NULL,
		[PrecioCoste] [decimal](18, 4) NULL,
		[TipoUnidad_Codigo] [nvarchar](2) COLLATE Modern_Spanish_CI_AS NULL,
		[ArticuloPeso] [bit] NULL,
		[PrecioVenta] [decimal](18, 4) NULL,
		[TipoArticulo] [nvarchar](1) COLLATE Modern_Spanish_CI_AS NULL,
		[UnidadesPromocion] [decimal](18, 4) NULL,
		[PrecioPromocion] [decimal](18, 4) NULL,
	 CONSTRAINT [PK_COMUNICACIONES_ARTICULOS] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]

	SET NOCOUNT OFF
GO
ALTER TABLE ARTICULOS ADD [UnidadesPromocion] [decimal](18, 4) NULL, [PrecioPromocion] [decimal](18, 4) NULL
GO
UPDATE ARTICULOS SET UnidadesPromocion = 0, PrecioPromocion = 0