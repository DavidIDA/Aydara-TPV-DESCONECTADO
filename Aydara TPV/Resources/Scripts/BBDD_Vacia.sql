USE [master]
GO
/****** Object:  Database [AydaraTPV_NAVAL]    Script Date: 19/09/2017 8:43:25 ******/
CREATE DATABASE [AydaraTPV_NAVAL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AydaraTPV_NAVAL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.A3ERP\MSSQL\DATA\AydaraTPV_NAVAL.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AydaraTPV_NAVAL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.A3ERP\MSSQL\DATA\AydaraTPV_NAVAL_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AydaraTPV_NAVAL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET ARITHABORT OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET  MULTI_USER 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AydaraTPV_NAVAL', N'ON'
GO
USE [AydaraTPV_NAVAL]
GO
/****** Object:  Table [dbo].[ACTIVACIONES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACTIVACIONES](
	[NumeroSerie] [nvarchar](50) NOT NULL,
	[NombreEquipo] [nvarchar](50) NULL,
	[CodigoActivacion] [nvarchar](50) NULL,
	[FechaInstalacion] [ntext] NULL,
	[FechaCaducidad] [ntext] NULL,
 CONSTRAINT [PK_NumerosSerie] PRIMARY KEY CLUSTERED 
(
	[NumeroSerie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ALBARANES_COMPRAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALBARANES_COMPRAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoTienda] [int] NULL,
	[NumeroAlbaran] [nvarchar](10) NULL,
	[Fecha] [datetime] NULL,
	[CodigoProveedor] [int] NULL,
	[NombreProveedor] [nvarchar](50) NULL,
	[Observaciones] [nvarchar](max) NULL,
 CONSTRAINT [PK_ALBARANES_COMPRAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ALBARANES_COMPRAS_LINEAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALBARANES_COMPRAS_LINEAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlbaranCompra_Id] [int] NULL,
	[CodigoArticulo] [nvarchar](15) NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Cantidad] [decimal](18, 4) NULL,
	[Precio] [decimal](18, 4) NULL,
	[Descuento] [decimal](18, 4) NULL,
	[Total] [decimal](18, 4) NULL,
	[Observaciones] [nvarchar](max) NULL,
 CONSTRAINT [PK_ALBARANES_COMPRAS_LINEAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ALBARANES_COMPRAS_LINEAS_DETALLE]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALBARANES_COMPRAS_LINEAS_DETALLE](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LineaAlbaranCompra_Id] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoTalla] [int] NULL,
	[Cantidad] [decimal](18, 4) NULL,
 CONSTRAINT [PK_ALBARANES_COMPRAS_LINEAS_DETALLE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ARTICULOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](15) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[TipoIva] [int] NULL CONSTRAINT [DF_ARTICULOS_TipoIva]  DEFAULT ((1)),
	[CodigoFamilia] [int] NULL,
	[CodigoSubfamilia] [int] NULL,
	[CodigoProveedor] [int] NULL,
	[CodigoEnvase] [nvarchar](7) NULL,
	[ControlEtiquetas] [bit] NULL CONSTRAINT [DF_ARTICULOS_ControlEtiquetas]  DEFAULT ((0)),
	[CantidadVariable] [bit] NULL CONSTRAINT [DF_ARTICULOS_CantidadVariable]  DEFAULT ((0)),
	[ControlBaja] [bit] NULL CONSTRAINT [DF_ARTICULOS_ControlBaja]  DEFAULT ((0)),
	[CodigoTalla] [int] NULL CONSTRAINT [DF_ARTICULOS_CodigoTalla]  DEFAULT ((0)),
	[FechaAlta] [datetime] NULL,
	[UnidadCaja] [int] NULL CONSTRAINT [DF_ARTICULOS_UnidadCaja]  DEFAULT ((1)),
	[MinimoVenta] [int] NULL CONSTRAINT [DF_ARTICULOS_MinimoVenta]  DEFAULT ((0)),
	[MinimoCompra] [int] NULL CONSTRAINT [DF_ARTICULOS_MinimoCompra]  DEFAULT ((0)),
	[PesoUnidad] [decimal](18, 4) NULL CONSTRAINT [DF_ARTICULOS_PesoUnidad]  DEFAULT ((0)),
	[Descuento] [decimal](18, 4) NULL CONSTRAINT [DF_ARTICULOS_Descuento]  DEFAULT ((0)),
	[Precio] [decimal](18, 4) NULL CONSTRAINT [DF_ARTICULOS_Precio]  DEFAULT ((0)),
	[PrecioCoste] [decimal](18, 4) NULL CONSTRAINT [DF_ARTICULOS_PrecioCoste]  DEFAULT ((0)),
	[Imagen] [image] NULL,
	[Etiqueta] [nvarchar](20) NULL,
	[TipoUnidad_Id] [int] NULL,
	[ArticuloPeso] [bit] NULL CONSTRAINT [DF_ARTICULOS_ArticuloPeso]  DEFAULT ((0)),
	[TipoArticulo] [nvarchar](1) NULL,
	[TpvTactil] [bit] NULL,
	[UnidadesPromocion] [decimal](18, 4) NULL,
	[PrecioPromocion] [decimal](18, 4) NULL,
	[CodigoBascula] [nvarchar](2) NULL,
	[PLU] [int] NULL,
	[DtoFidelizacion] [decimal](18, 4) NULL,
	[EE_CodigoBarras] [nvarchar](13) NULL,
	[EE_Formato] [int] NULL,
	[EE_Origen] [nvarchar](15) NULL,
	[EE_Categoria] [nvarchar](10) NULL,
	[EE_Calibre] [nvarchar](5) NULL,
	[ImporteEcoraee] [decimal](18, 4) NULL,
	[Equivalencia] [float] NULL,
 CONSTRAINT [PK_ARTICULOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ARTICULOS_COLORES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULOS_COLORES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Articulo_Id] [int] NULL,
	[Color_Id] [int] NULL,
 CONSTRAINT [PK_ARTICULOS_COLORES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CAJAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAJAS](
	[CodigoTienda] [int] NOT NULL,
	[CodigoCaja] [int] NOT NULL,
	[TopeEfectivoEnCaja] [decimal](18, 4) NULL,
	[NumeroTicket] [int] NULL,
	[NumeroTicket_2] [int] NULL,
	[CajaCerrada] [bit] NULL,
	[ImprimeTicket] [int] NULL,
	[AperturaCajon] [bit] NULL,
	[CorteTicket] [bit] NULL,
	[Visor] [bit] NULL,
	[ActivaVisor] [nvarchar](30) NULL,
	[DesactivaVisor] [nvarchar](30) NULL,
	[ActivaExpandido] [nvarchar](30) NULL,
	[DesactivaExpandido] [nvarchar](30) NULL,
	[AbreCajon] [nvarchar](30) NULL,
	[TextoCorteTicket] [nvarchar](30) NULL,
 CONSTRAINT [PK_CAJAS] PRIMARY KEY CLUSTERED 
(
	[CodigoTienda] ASC,
	[CodigoCaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CLICREDI]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[Codigo] [int] NOT NULL,
	[NombreFiscal] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[CodigoPostal] [nvarchar](5) NULL,
	[Poblacion] [nvarchar](50) NULL,
	[Provincia] [nvarchar](30) NULL,
	[CIF] [nvarchar](15) NULL,
	[TelParticular] [nvarchar](30) NULL,
	[TelMovil] [nvarchar](30) NULL,
	[ControlBaja] [bit] NULL,
	[TieneTarjeta] [bit] NULL,
	[CaducidadTarjeta] [datetime] NULL,
	[DescuentoTarjeta] [decimal](18, 4) NULL,
	[AlbaranCredito] [bit] NULL,
	[Observaciones] [text] NULL,
	[Email] [nvarchar](100) NULL,
	[ClienteCredito] [nvarchar](8) NULL,
	[SaldoPuntos] [decimal](18, 4) NULL,
	[Matricula] [varchar](20) NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[TipoVehiculo] [varchar](50) NULL,
	[Km] [decimal](18, 2) NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CODIGO_BARRAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CODIGO_BARRAS](
	[CodigoBarras] [nvarchar](13) NOT NULL,
	[Articulo_Id] [nvarchar](50) NULL,
	[CodigoColor] [int] NULL,
	[CodigoTalla] [int] NULL,
 CONSTRAINT [PK_CODIGO_BARRAS] PRIMARY KEY CLUSTERED 
(
	[CodigoBarras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COLORES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COLORES](
	[CodigoColor] [int] NOT NULL,
	[Descripcion] [nvarchar](10) NULL,
	[Color] [int] NULL,
 CONSTRAINT [PK_COLORES] PRIMARY KEY CLUSTERED 
(
	[CodigoColor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ETIQUETAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ETIQUETAS](
	[CodigoArticulo] [nvarchar](15) NOT NULL,
	[CodigoColor] [int] NOT NULL,
	[CodigoTalla] [int] NOT NULL,
	[Etiquetas] [int] NULL,
 CONSTRAINT [PK_ETIQUETAS] PRIMARY KEY CLUSTERED 
(
	[CodigoArticulo] ASC,
	[CodigoColor] ASC,
	[CodigoTalla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ETIQUETAS_ELECTRONICAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ETIQUETAS_ELECTRONICAS](
	[CodigoBarras] [varchar](50) NOT NULL,
	[CodigoArticulo] [varchar](15) NULL,
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EXISTENCIAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EXISTENCIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Articulo_Id] [int] NULL,
	[CodigoTienda] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoTalla] [int] NULL,
	[ExistenciaInicial] [decimal](18, 4) NULL,
	[ExistenciaActual] [decimal](18, 4) NULL,
	[StockMinimo] [int] NULL,
	[StockMaximo] [int] NULL,
	[PrecioVenta] [decimal](18, 4) NULL,
 CONSTRAINT [PK_EXISTENCIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FAMILIASARTICULOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAMILIASARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](15) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[DescuentoTarjeta] [decimal](18, 4) NULL,
	[Imagen] [image] NULL,
	[Etiqueta] [nvarchar](10) NULL,
	[TpvTactil] [bit] NULL,
	[CtaVentas] [nvarchar](10) NULL,
	[CtaCompras] [nvarchar](10) NULL,
 CONSTRAINT [PK_FAMILIAS_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HISTORICO_INVENTARIO]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORICO_INVENTARIO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Articulo_Id] [int] NULL,
	[CodigoTienda] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoTalla] [int] NULL,
	[Fecha] [datetime] NULL,
	[Cantidad] [decimal](18, 4) NULL,
 CONSTRAINT [PK_HISTORICO_INVENTARIO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HISTORICO_TICKETS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORICO_TICKETS](
	[Id] [int] NOT NULL,
	[CodigoTienda] [int] NULL,
	[CodigoCaja] [int] NULL,
	[NumeroTicket] [int] NULL,
	[FechaTicket] [datetime] NULL,
	[HoraTicket] [datetime] NULL,
	[TipoCobro] [nchar](1) NULL,
	[CodigoCliente] [int] NULL,
	[ImpresoTicket] [bit] NULL,
	[ImporteEfectivo] [decimal](18, 4) NULL,
	[ImporteTalonCheque] [decimal](18, 4) NULL,
	[ImporteValesProveedor] [decimal](18, 4) NULL,
	[ImporteValesCobrados] [decimal](18, 4) NULL,
	[ImporteTarjeta] [decimal](18, 4) NULL,
	[ImporteEnvases] [decimal](18, 4) NULL,
	[ImportePendienteCobro] [decimal](18, 4) NULL,
	[ImporteValesEmitidos] [decimal](18, 4) NULL,
	[ImporteTotalCambios] [decimal](18, 4) NULL,
	[ImporteCambios] [decimal](18, 4) NULL,
	[PorcentajeDescuento] [decimal](18, 4) NULL,
	[ImporteDescuento] [decimal](18, 4) NULL,
	[NumeroLineas] [int] NULL,
	[ImporteTotal] [decimal](18, 4) NULL,
	[EnEspera] [bit] NULL,
	[RepartoDomicilio] [bit] NULL,
	[DireccionReparto] [nvarchar](max) NULL,
	[ImporteSorteo] [decimal](18, 2) NULL,
	[FechaCierre] [datetime] NULL,
	[CierreTurno] [bit] NULL,
	[NumeroAlbaran] [int] NULL,
	[Exportado] [bit] NULL CONSTRAINT [DF_HISTORICO_TICKETS_Exportado]  DEFAULT ((0)),
	[TipoFactura] [int] NULL,
	[PuntosCanjeados] [decimal](18, 2) NULL,
	[ClienteCredito] [nvarchar](8) NULL,
	[FidelizacionImporte] [decimal](18, 2) NULL,
	[FidelizacionVales] [decimal](18, 2) NULL,
	[FidelizacionPuntos] [decimal](18, 2) NULL,
	[FidelizacionLoteria] [decimal](18, 2) NULL,
	[ValesCanjeados] [decimal](18, 2) NULL,
	[TotalRecargo] [decimal](18, 2) NULL,
	[TotalDtoPP] [decimal](18, 2) NULL,
	[Km] [decimal](18, 2) NULL,
 CONSTRAINT [PK_HISTORICO_TICKETS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HISTORICO_TICKETS_ANULADOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORICO_TICKETS_ANULADOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoTienda] [int] NULL,
	[CodigoCaja] [int] NULL,
	[NumeroTicket] [int] NULL,
	[FechaTicket] [datetime] NULL,
	[HoraTicket] [datetime] NULL,
	[TipoCobro] [nchar](1) NULL,
	[CodigoCliente] [int] NULL,
	[ImpresoTicket] [bit] NULL,
	[ImporteEfectivo] [decimal](18, 4) NULL,
	[ImporteTalonCheque] [decimal](18, 4) NULL,
	[ImporteValesProveedor] [decimal](18, 4) NULL,
	[ImporteValesCobrados] [decimal](18, 4) NULL,
	[ImporteTarjeta] [decimal](18, 4) NULL,
	[ImporteEnvases] [decimal](18, 4) NULL,
	[ImportePendienteCobro] [decimal](18, 4) NULL,
	[ImporteValesEmitidos] [decimal](18, 4) NULL,
	[ImporteTotalCambios] [decimal](18, 4) NULL,
	[ImporteCambios] [decimal](18, 4) NULL,
	[PorcentajeDescuento] [decimal](18, 4) NULL,
	[ImporteDescuento] [decimal](18, 4) NULL,
	[NumeroLineas] [int] NULL,
	[ImporteTotal] [decimal](18, 4) NULL,
	[EnEspera] [bit] NULL,
	[RepartoDomicilio] [bit] NULL,
	[DireccionReparto] [nvarchar](max) NULL,
	[ImporteSorteo] [decimal](18, 2) NULL,
	[CierreTurno] [bit] NULL,
	[NumeroAlbaran] [int] NULL,
	[TotalRecargo] [decimal](18, 2) NULL,
	[TotalDtoPP] [decimal](18, 2) NULL,
	[Km] [decimal](18, 2) NULL,
 CONSTRAINT [PK_HISTORICO_TICKETS_ANULADOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HISTORICO_TICKETS_ANULADOS_LINEAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORICO_TICKETS_ANULADOS_LINEAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ticket_Id] [int] NULL,
	[CodigoArticulo] [nvarchar](15) NULL,
	[Promocion] [bit] NULL,
	[PrecioManual] [bit] NULL,
	[CodigoEmleado] [int] NULL,
	[DescripcionArticulo] [nvarchar](40) NULL,
	[Cantidad] [decimal](18, 4) NULL,
	[Precio] [decimal](18, 4) NULL,
	[DescuentoLinea] [decimal](18, 4) NULL,
	[Importe] [decimal](18, 4) NULL,
	[PorcentajeIVA] [decimal](18, 4) NULL,
	[NumeroTalla] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoArticuloRegalo] [nvarchar](7) NULL,
	[UnidadesRegalo] [decimal](18, 4) NULL,
	[PrecioRegalo] [decimal](18, 4) NULL,
	[CodigoColorPromocion] [int] NULL,
	[NumeroTallaPromocion] [int] NULL,
	[FraccionSinCargo] [decimal](18, 4) NULL,
	[UnidadesSinCargo] [decimal](18, 4) NULL,
	[Peso] [decimal](18, 4) NULL,
 CONSTRAINT [PK_HISTORICO_TICKETS_ANULADOS_LINEAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HISTORICO_TICKETS_LINEAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORICO_TICKETS_LINEAS](
	[Id] [int] NOT NULL,
	[Ticket_Id] [int] NULL,
	[CodigoArticulo] [nvarchar](15) NULL,
	[Promocion] [bit] NULL,
	[PrecioManual] [bit] NULL,
	[CodigoEmleado] [int] NULL,
	[DescripcionArticulo] [nvarchar](40) NULL,
	[Cantidad] [decimal](18, 4) NULL,
	[Precio] [decimal](18, 4) NULL,
	[DescuentoLinea] [decimal](18, 4) NULL,
	[Importe] [decimal](18, 4) NULL,
	[PorcentajeIVA] [decimal](18, 4) NULL,
	[NumeroTalla] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoArticuloRegalo] [nvarchar](7) NULL,
	[UnidadesRegalo] [decimal](18, 4) NULL,
	[PrecioRegalo] [decimal](18, 4) NULL,
	[CodigoColorPromocion] [int] NULL,
	[NumeroTallaPromocion] [int] NULL,
	[FraccionSinCargo] [decimal](18, 4) NULL,
	[UnidadesSinCargo] [decimal](18, 4) NULL,
	[FechaCierre] [datetime] NULL,
	[Peso] [decimal](18, 4) NULL,
	[DtoFidelizacion] [decimal](18, 2) NULL,
	[UnidadStock] [decimal](18, 4) NULL,
	[ImporteEcoraee] [decimal](18, 4) NULL,
 CONSTRAINT [PK_HISTORICO_TICKETS_LINEAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INCIDENCIAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INCIDENCIAS](
	[IDIncidencia] [int] IDENTITY(1,1) NOT NULL,
	[TipoID] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[OperarioID] [int] NOT NULL,
	[Comentario] [text] NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[ArticuloID] [int] NOT NULL,
	[AfectaStock] [bit] NULL,
	[PrecioCoste] [decimal](18, 4) NULL,
 CONSTRAINT [PK_INCIDENCIAS] PRIMARY KEY CLUSTERED 
(
	[IDIncidencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INCIDENCIAS_TIPOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INCIDENCIAS_TIPOS](
	[IDTipo] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_INCIDENCIAS_TIPOS] PRIMARY KEY CLUSTERED 
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVENTARIO]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoArticulo] [nvarchar](15) NULL,
	[Cantidad] [decimal](18, 4) NULL,
 CONSTRAINT [PK_INVENTARIO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MODIFICACIONES_PENDIENTES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODIFICACIONES_PENDIENTES](
	[FechaVigor] [datetime] NOT NULL,
	[CodigoArticulo] [nvarchar](15) NOT NULL,
	[CodigoColor] [int] NOT NULL,
	[CodigoTalla] [int] NOT NULL,
	[PrecioTarifa] [decimal](18, 4) NULL,
 CONSTRAINT [PK_MODIFICACIONES_PENDIENTES_1] PRIMARY KEY CLUSTERED 
(
	[FechaVigor] ASC,
	[CodigoArticulo] ASC,
	[CodigoColor] ASC,
	[CodigoTalla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MOVIMIENTOS_CAJA]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIMIENTOS_CAJA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoTienda] [int] NULL,
	[CodigoCaja] [int] NULL,
	[FechaMovimiento] [datetime] NULL,
	[TipoMovimiento] [nchar](2) NULL,
	[TipoCobro] [int] NULL,
	[CodigoCliente] [int] NULL,
	[Concepto] [nvarchar](30) NULL,
	[Importe] [decimal](18, 4) NULL,
	[FechaCierre] [datetime] NULL,
	[CodigoEmpleado] [int] NULL,
	[CierreTurno] [bit] NULL,
 CONSTRAINT [PK_MOVIMIENTOS_CAJA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OPERARIOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OPERARIOS](
	[Codigo] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Poblacion] [nvarchar](50) NULL,
	[Provincia] [nvarchar](30) NULL,
	[Telefono] [nvarchar](30) NULL,
	[NombreTicket] [nvarchar](20) NULL,
 CONSTRAINT [PK_EMPLEADOS] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PARAMETROS_BASCULA]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARAMETROS_BASCULA](
	[Prefijo] [nchar](2) NOT NULL,
	[PosInicial_Articulo] [int] NULL,
	[PosFinal_Articulo] [int] NULL,
	[PosInicial_Peso] [int] NULL,
	[PosFinal_Peso] [int] NULL,
	[PosInicial_Importe] [int] NULL,
	[PosFinal_Importe] [int] NULL,
 CONSTRAINT [PK_PARAMETROS_BASCULA] PRIMARY KEY CLUSTERED 
(
	[Prefijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoTienda] [int] NULL,
	[NumeroPedido] [int] NULL,
	[Fecha] [datetime] NULL,
	[FechaEntrega] [datetime] NULL,
	[CodigoProveedor] [int] NULL,
	[NombreProveedor] [nvarchar](50) NULL,
	[Observaciones] [nvarchar](max) NULL,
	[FechaEnvio] [datetime] NULL,
 CONSTRAINT [PK_PEDIDOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PEDIDOS_LINEAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS_LINEAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pedido_Id] [int] NULL,
	[CodigoArticulo] [nvarchar](15) NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Cantidad] [decimal](18, 4) NULL,
	[Precio] [decimal](18, 4) NULL,
	[Descuento] [decimal](18, 4) NULL,
	[Total] [decimal](18, 4) NULL,
	[Observaciones] [nvarchar](max) NULL,
	[CantidadServida] [decimal](18, 4) NULL,
 CONSTRAINT [PK_PEDIDOS_LINEAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PEDIDOS_LINEAS_DETALLE]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS_LINEAS_DETALLE](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LineaPedido_Id] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoTalla] [int] NULL,
	[Cantidad] [decimal](18, 4) NULL,
	[CantidadServida] [decimal](18, 4) NULL,
 CONSTRAINT [PK_PEDIDOS_LINEAS_DETALLE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PENDIENTES_COBRO]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PENDIENTES_COBRO](
	[CodigoCliente] [int] NOT NULL,
	[CodigoTienda] [int] NOT NULL,
	[CodigoCaja] [int] NOT NULL,
	[CodigoTicket] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[ImporteTicket] [decimal](18, 4) NULL,
	[ImporteCobrado] [decimal](18, 4) NULL,
 CONSTRAINT [PK_PENDIENTES_COBRO] PRIMARY KEY CLUSTERED 
(
	[CodigoCliente] ASC,
	[CodigoTienda] ASC,
	[CodigoCaja] ASC,
	[CodigoTicket] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROMOCIONES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROMOCIONES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoTienda] [int] NULL,
	[CodigoArticulo] [nvarchar](7) NULL,
	[CodigoColor] [int] NULL,
	[CodigoTalla] [int] NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFinal] [datetime] NULL,
	[CodigoArticuloRegalo] [nvarchar](15) NULL,
	[PrecioPromocion] [decimal](18, 4) NULL,
	[FraccionSinCargo] [decimal](18, 4) NULL,
	[UnidadesSinCargo] [decimal](18, 4) NULL,
	[PrecioArticuloRegalo] [decimal](18, 4) NULL,
	[NumeroAlmacen] [int] NULL,
	[NumeroTarifa] [int] NULL,
	[Unidades] [decimal](18, 4) NULL,
 CONSTRAINT [PK_PROMOCIONES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROVEEDORES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDORES](
	[Codigo] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[CodigoPostal] [nvarchar](5) NULL,
	[Poblacion] [nvarchar](50) NULL,
	[Provincia] [nvarchar](30) NULL,
	[CIF] [nvarchar](15) NULL,
	[Telefono] [nvarchar](30) NULL,
	[TelMovil] [nvarchar](30) NULL,
	[Fax] [nvarchar](30) NULL,
	[Contacto] [nvarchar](50) NULL,
 CONSTRAINT [PK_PROVEEDORES] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[REFERENCIAS_PROVEEDORES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REFERENCIAS_PROVEEDORES](
	[Articulo_Id] [int] NOT NULL,
	[CodigoProveedor] [int] NOT NULL,
	[Referencia] [nvarchar](50) NULL,
	[PrecioCoste] [decimal](18, 4) NULL,
	[PrecioVenta] [decimal](18, 4) NULL,
	[UnidadesCaja] [int] NULL,
 CONSTRAINT [PK_REFERENCIAS_PROVEEDORES] PRIMARY KEY CLUSTERED 
(
	[Articulo_Id] ASC,
	[CodigoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SEQ_ARTICULO]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
	[DtoFidelizacion] [varchar](50) NULL,
	[ImporteEcoraee] [varchar](50) NULL,
	[Equivalencia] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEQ_CLICREDI]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEQ_CLIENTES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEQ_CLIENTES](
	[NumTarjeta] [varchar](50) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[CodigoPostal] [varchar](50) NOT NULL,
	[Poblacion] [varchar](150) NOT NULL,
	[Provincia] [varchar](150) NOT NULL,
	[Telefonos] [varchar](50) NOT NULL,
	[NIF] [varchar](50) NOT NULL,
	[Bloqueada] [varchar](50) NOT NULL,
	[FechaCaducidad] [varchar](50) NOT NULL,
	[Descuento] [varchar](50) NOT NULL,
	[VentaCredito] [varchar](50) NOT NULL,
	[ClienteCredito] [varchar](50) NULL,
	[SaldoPuntos] [varchar](50) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEQ_COBARRAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEQ_COBARRAS](
	[CodigoBarras] [varchar](50) NULL,
	[CodigoArticulo] [varchar](50) NULL,
	[Vacio] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEQ_FAMILIAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEQ_FAMILIAS](
	[CodigoFamilia] [varchar](50) NULL,
	[CodigoSubfamilia] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[DtoTarjeta] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEQ_INVENTARIO]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEQ_INVENTARIO](
	[CodigoArticulo] [varchar](50) NULL,
	[ExistenciaActual] [varchar](50) NULL,
	[StockMinimo] [varchar](50) NULL,
	[StockMaximo] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEQ_PROMOCIO]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEQ_PROMOCIO](
	[CodigoArticulo] [varchar](50) NULL,
	[Tienda] [varchar](50) NULL,
	[Tarifa] [varchar](50) NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[Precio] [varchar](50) NULL,
	[Unidades] [varchar](50) NULL,
	[ArticuloRegalo] [varchar](max) NULL,
	[FraccionSinCargo] [varchar](50) NULL,
	[UnidadesSinCargo] [varchar](50) NULL,
	[PrecioRegalo] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEQ_TARIFAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEQ_TARIFAS](
	[CodigoArticulo] [varchar](50) NULL,
	[Tarifa] [varchar](50) NULL,
	[Precio] [varchar](50) NULL,
	[IvaIncluido] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SORTEOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SORTEOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[FechaSorteo] [datetime] NULL,
	[Tipo] [int] NULL,
	[SoloTarjetas] [bit] NULL,
	[Fraccion] [decimal](18, 2) NULL,
	[Participacion] [decimal](18, 2) NULL,
	[Numero] [int] NULL,
	[DepositadoEn] [nvarchar](40) NULL,
	[AplicaPromociones] [bit] NULL,
 CONSTRAINT [PK_SORTEOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SUBFAMILIASARTICULOS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUBFAMILIASARTICULOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Familia_Id] [int] NOT NULL,
	[Codigo] [nvarchar](15) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[DescuentoTarjeta] [decimal](18, 4) NULL,
 CONSTRAINT [PK_SUBFAMILIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TALLAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TALLAS](
	[CodigoTalla] [int] NOT NULL,
	[Talla_1] [nvarchar](4) NULL,
	[Talla_2] [nvarchar](4) NULL,
	[Talla_3] [nvarchar](4) NULL,
	[Talla_4] [nvarchar](4) NULL,
	[Talla_5] [nvarchar](4) NULL,
	[Talla_6] [nvarchar](4) NULL,
	[Talla_7] [nvarchar](4) NULL,
	[Talla_8] [nvarchar](4) NULL,
	[Talla_9] [nvarchar](4) NULL,
	[Talla_10] [nvarchar](4) NULL,
	[Talla_11] [nvarchar](4) NULL,
	[Talla_12] [nvarchar](4) NULL,
	[Talla_13] [nvarchar](4) NULL,
	[Talla_14] [nvarchar](4) NULL,
	[Talla_15] [nvarchar](4) NULL,
	[Talla_16] [nvarchar](4) NULL,
	[Talla_17] [nvarchar](4) NULL,
	[Talla_18] [nvarchar](4) NULL,
 CONSTRAINT [PK_TALLAS] PRIMARY KEY CLUSTERED 
(
	[CodigoTalla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TARIFAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[TICKETS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKETS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodigoTienda] [int] NULL,
	[CodigoCaja] [int] NULL,
	[NumeroTicket] [int] NULL,
	[FechaTicket] [datetime] NULL,
	[HoraTicket] [datetime] NULL,
	[TipoCobro] [nchar](1) NULL,
	[CodigoCliente] [int] NULL,
	[ImpresoTicket] [bit] NULL,
	[ImporteEfectivo] [decimal](18, 4) NULL,
	[ImporteTalonCheque] [decimal](18, 4) NULL,
	[ImporteValesProveedor] [decimal](18, 4) NULL,
	[ImporteValesCobrados] [decimal](18, 4) NULL,
	[ImporteTarjeta] [decimal](18, 4) NULL,
	[ImporteEnvases] [decimal](18, 4) NULL,
	[ImportePendienteCobro] [decimal](18, 4) NULL,
	[ImporteValesEmitidos] [decimal](18, 4) NULL,
	[ImporteTotalCambios] [decimal](18, 4) NULL,
	[ImporteCambios] [decimal](18, 4) NULL,
	[PorcentajeDescuento] [decimal](18, 4) NULL,
	[ImporteDescuento] [decimal](18, 4) NULL,
	[NumeroLineas] [int] NULL,
	[ImporteTotal] [decimal](18, 4) NULL,
	[EnEspera] [bit] NULL,
	[RepartoDomicilio] [bit] NULL,
	[DireccionReparto] [nvarchar](max) NULL,
	[ImporteSorteo] [decimal](18, 2) NULL,
	[CierreTurno] [bit] NULL,
	[NumeroAlbaran] [int] NULL,
	[TipoFactura] [int] NULL,
	[PuntosCanjeados] [decimal](18, 2) NULL,
	[ClienteCredito] [nvarchar](8) NULL,
	[FidelizacionImporte] [decimal](18, 2) NULL,
	[FidelizacionVales] [decimal](18, 2) NULL,
	[FidelizacionPuntos] [decimal](18, 2) NULL,
	[FidelizacionLoteria] [decimal](18, 2) NULL,
	[ValesCanjeados] [decimal](18, 2) NULL,
	[TotalRecargo] [decimal](18, 2) NULL,
	[TotalDtoPP] [decimal](18, 2) NULL,
	[Km] [decimal](18, 2) NULL,
 CONSTRAINT [PK_TICKETS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TICKETS_LINEAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKETS_LINEAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ticket_Id] [int] NULL,
	[CodigoArticulo] [nvarchar](15) NULL,
	[Promocion] [bit] NULL,
	[PrecioManual] [bit] NULL,
	[CodigoEmleado] [int] NULL,
	[DescripcionArticulo] [nvarchar](40) NULL,
	[Cantidad] [decimal](18, 4) NULL,
	[Precio] [decimal](18, 4) NULL,
	[DescuentoLinea] [decimal](18, 4) NULL,
	[Importe] [decimal](18, 4) NULL,
	[PorcentajeIVA] [decimal](18, 4) NULL,
	[NumeroTalla] [int] NULL,
	[CodigoColor] [int] NULL,
	[CodigoArticuloRegalo] [nvarchar](7) NULL,
	[UnidadesRegalo] [decimal](18, 4) NULL,
	[PrecioRegalo] [decimal](18, 4) NULL,
	[CodigoColorPromocion] [int] NULL,
	[NumeroTallaPromocion] [int] NULL,
	[FraccionSinCargo] [decimal](18, 4) NULL,
	[UnidadesSinCargo] [decimal](18, 4) NULL,
	[Peso] [decimal](18, 4) NULL,
	[DtoFidelizacion] [decimal](18, 2) NULL,
	[UnidadStock] [decimal](18, 4) NULL,
	[ImporteEcoraee] [decimal](18, 4) NULL,
 CONSTRAINT [PK_TICKETS_LINEAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIENDAS]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIENDAS](
	[CodigoTienda] [int] NOT NULL,
	[NombreFiscal] [nvarchar](40) NULL,
	[Direccion] [nvarchar](40) NULL,
	[CodigoPostal] [nvarchar](5) NULL,
	[Poblacion] [nvarchar](30) NULL,
	[Provincia] [nvarchar](30) NULL,
	[Nif] [nvarchar](15) NULL,
	[Telefonos] [nvarchar](30) NULL,
	[FormatoEmpresa] [nvarchar](2) NULL,
	[TextoCabecera1] [nvarchar](max) NULL,
	[TextoCabecera2] [nvarchar](max) NULL,
	[TextoPie] [nvarchar](max) NULL,
	[NumeroCajas] [int] NULL,
	[DecimalesPrecio] [int] NULL,
	[DecimalesImporte] [int] NULL,
	[TarifaIvaIncluido] [bit] NULL,
	[GestionTarjetas] [bit] NULL,
	[GeneralTarjetas] [decimal](18, 4) NULL,
	[GestionTallas] [bit] NULL,
	[ImpresionEtiquetas] [bit] NULL,
	[ControlVendedores] [bit] NULL,
	[CopiasDocumentos] [int] NULL,
	[CantidadManual] [bit] NULL,
	[PrecioManual] [bit] NULL,
	[DtoEnLinea] [bit] NULL,
	[DtoSobrePromociones] [bit] NULL,
	[VtasPorFamiliaCierre] [bit] NULL,
	[VtasPorVendedorCierre] [bit] NULL,
	[TicketDeBascula] [bit] NULL,
	[TipoIva1] [decimal](18, 2) NULL,
	[TipoIva2] [decimal](18, 2) NULL,
	[TipoIva3] [decimal](18, 2) NULL,
	[TipoIva4] [decimal](18, 2) NULL,
	[NumeroVale] [int] NULL,
	[NumeroPedido] [int] NULL,
	[PrefijoBascula1] [nvarchar](2) NULL,
	[PrefijoBascula2] [nvarchar](2) NULL,
	[PrefijoBascula3] [nvarchar](2) NULL,
	[TpvTactil] [bit] NULL,
	[GestionColores] [bit] NULL,
	[PrefijoEtiqueta] [nvarchar](2) NULL,
	[TextoImpuesto] [nvarchar](50) NULL,
	[Logo] [image] NULL,
	[NumeroAlmacen] [int] NULL,
	[TipoTienda] [int] NULL,
	[RecargoEquivalencia] [bit] NULL,
	[PorcentajeDescuento] [decimal](18, 2) NULL,
	[Comunicaciones_Tipo] [int] NULL,
	[Comunicaciones_Direccion] [nvarchar](max) NULL,
	[Comunicaciones_Usuario] [nvarchar](50) NULL,
	[Comunicaciones_Password] [nvarchar](50) NULL,
	[Comunicaciones_Envio] [nvarchar](max) NULL,
	[ArticuloPropioInicio] [nvarchar](7) NULL,
	[ArticuloPropioFin] [nvarchar](7) NULL,
	[NumeroTarifa] [int] NULL,
	[TipoRecargo1] [decimal](18, 2) NULL,
	[TipoRecargo2] [decimal](18, 2) NULL,
	[TipoRecargo3] [decimal](18, 2) NULL,
	[TipoRecargo4] [decimal](18, 2) NULL,
	[FechaUltimaActualizacion] [datetime] NULL,
	[Actualizando] [bit] NULL,
	[VersionBD] [int] NULL,
	[NumeroAlbaran] [int] NULL,
	[DtoSobreTarifa] [decimal](18, 2) NULL,
	[DtoSobrePromocion] [decimal](18, 2) NULL,
	[RecibePromociones] [bit] NULL,
	[ActualizaCosto] [bit] NULL,
	[AlbaranFormatoTicket] [bit] NULL,
	[AlbaranFormatoA4] [bit] NULL,
	[Comunicaciones_Terminales] [nvarchar](max) NULL,
	[VentaCredito] [bit] NULL,
	[ControlTarjetas] [bit] NULL,
	[EtiquetaElectronica] [bit] NULL,
	[NumeroFactura1] [int] NULL,
	[NumeroFactura2] [int] NULL,
	[Comunicaciones_DirectorioFicheros] [nvarchar](max) NULL,
	[DirectorioFicheroBasculas] [nvarchar](max) NULL,
	[EE_DireccionFTP] [nvarchar](max) NULL,
	[EE_UsuarioFTP] [nvarchar](max) NULL,
	[EE_PasswordFTP] [nvarchar](max) NULL,
	[RegistroMercantil] [nvarchar](max) NULL,
 CONSTRAINT [PK_TIENDAS] PRIMARY KEY CLUSTERED 
(
	[CodigoTienda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIPOS_UNIDADES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_UNIDADES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](2) NOT NULL,
	[Descripcion] [nvarchar](10) NULL,
 CONSTRAINT [PK_TIPOS_UNIDADES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRASPASO_ALMACENES]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRASPASO_ALMACENES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlmacenDestino] [int] NULL,
	[CodigoArticulo] [nvarchar](15) NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_TRASPASO_ALMACENES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VALES_TIENDA]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VALES_TIENDA](
	[CodigoTienda] [int] NOT NULL,
	[CodigoVale] [int] NOT NULL,
	[FechaVale] [datetime] NULL,
	[Nombre] [nvarchar](40) NULL,
	[Concepto] [nvarchar](40) NULL,
	[Importe] [decimal](18, 4) NULL,
 CONSTRAINT [PK_VALES_TIENDA] PRIMARY KEY CLUSTERED 
(
	[CodigoTienda] ASC,
	[CodigoVale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ALBARANES_COMPRAS_LINEAS] ADD  CONSTRAINT [DF_ALBARANES_COMPRAS_LINEAS_Cantidad]  DEFAULT ((0)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[ALBARANES_COMPRAS_LINEAS] ADD  CONSTRAINT [DF_ALBARANES_COMPRAS_LINEAS_Precio]  DEFAULT ((0)) FOR [Precio]
GO
ALTER TABLE [dbo].[ALBARANES_COMPRAS_LINEAS] ADD  CONSTRAINT [DF_ALBARANES_COMPRAS_LINEAS_Descuento]  DEFAULT ((0)) FOR [Descuento]
GO
ALTER TABLE [dbo].[ALBARANES_COMPRAS_LINEAS] ADD  CONSTRAINT [DF_ALBARANES_COMPRAS_LINEAS_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[PEDIDOS_LINEAS] ADD  CONSTRAINT [DF_PEDIDOS_LINEAS_Cantidad]  DEFAULT ((0)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[PEDIDOS_LINEAS] ADD  CONSTRAINT [DF_PEDIDOS_LINEAS_Precio]  DEFAULT ((0)) FOR [Precio]
GO
ALTER TABLE [dbo].[PEDIDOS_LINEAS] ADD  CONSTRAINT [DF_PEDIDOS_LINEAS_Descuento]  DEFAULT ((0)) FOR [Descuento]
GO
ALTER TABLE [dbo].[PEDIDOS_LINEAS] ADD  CONSTRAINT [DF_PEDIDOS_LINEAS_Total]  DEFAULT ((0)) FOR [Total]
GO
ALTER TABLE [dbo].[INCIDENCIAS]  WITH CHECK ADD  CONSTRAINT [FK_INCIDENCIAS_ARTICULOS] FOREIGN KEY([ArticuloID])
REFERENCES [dbo].[ARTICULOS] ([Id])
GO
ALTER TABLE [dbo].[INCIDENCIAS] CHECK CONSTRAINT [FK_INCIDENCIAS_ARTICULOS]
GO
ALTER TABLE [dbo].[INCIDENCIAS]  WITH CHECK ADD  CONSTRAINT [FK_INCIDENCIAS_INCIDENCIAS_TIPOS] FOREIGN KEY([TipoID])
REFERENCES [dbo].[INCIDENCIAS_TIPOS] ([IDTipo])
GO
ALTER TABLE [dbo].[INCIDENCIAS] CHECK CONSTRAINT [FK_INCIDENCIAS_INCIDENCIAS_TIPOS]
GO
ALTER TABLE [dbo].[INCIDENCIAS]  WITH CHECK ADD  CONSTRAINT [FK_INCIDENCIAS_OPERARIOS] FOREIGN KEY([OperarioID])
REFERENCES [dbo].[OPERARIOS] ([Codigo])
GO
ALTER TABLE [dbo].[INCIDENCIAS] CHECK CONSTRAINT [FK_INCIDENCIAS_OPERARIOS]
GO
/****** Object:  StoredProcedure [dbo].[ImportarArticulos]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
	[DtoFidelizacion] [varchar](50) NULL,
	[ImporteEcoraee] [varchar](50) NULL,
	[Equivalencia] [varchar](50) NULL
) ON [PRIMARY]
	
declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_ARTICULO FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
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
SET TipoIVA = SEQ_ARTICULO.TipoIVA, Descripcion = SEQ_ARTICULO.Descripcion,
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
ImporteEcoraee = CAST(REPLACE(REPLACE(SEQ_ARTICULO.ImporteEcoraee,',','.'),'	','') AS DECIMAL(18,4)), 
Equivalencia = CAST(REPLACE(REPLACE(SEQ_ARTICULO.Equivalencia,',','.'),'	','') AS FLOAT), 
EE_Origen = ISNULL(SEQ_ARTICULO.Origen,''), 
EE_Categoria = ISNULL(SEQ_ARTICULO.Categoria,''), 
EE_Calibre = ISNULL(SEQ_ARTICULO.Calibre,'')
FROM ARTICULOS INNER JOIN SEQ_ARTICULO ON ARTICULOS.Codigo = SEQ_ARTICULO.Codigo
LEFT JOIN TIPOS_UNIDADES ON SEQ_ARTICULO.TipoUnidad = TIPOS_UNIDADES.Codigo

/*Artículos nuevos*/
INSERT INTO ARTICULOS (Codigo, Descripcion, TipoIVA, CodigoProveedor, CodigoEnvase, Controletiquetas, CantidadVariable,
ArticuloPeso, Controlbaja, CodigoTalla, TipoUnidad_Id, UnidadCaja, MinimoVenta, MinimoCompra, PesoUnidad, Descuento, Precio, PrecioCoste, TipoArticulo, UnidadesPromocion, PrecioPromocion,
CodigoBascula, PLU, DtoFidelizacion, ImporteEcoraee, Equivalencia, EE_CodigoBarras, EE_Formato, EE_Origen, EE_Categoria, EE_Calibre)
SELECT SEQ_ARTICULO.Codigo, SEQ_ARTICULO.Descripcion, SEQ_ARTICULO.TipoIVA,
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
CAST(REPLACE(REPLACE(SEQ_ARTICULO.ImporteEcoraee,',','.'),'	','') AS DECIMAL(18,4)), 
CAST(REPLACE(REPLACE(SEQ_ARTICULO.Equivalencia,',','.'),'	','') AS DECIMAL(18,4)), 
'', 0, SEQ_ARTICULO.Origen, SEQ_ARTICULO.Categoria, SEQ_ARTICULO.Calibre
FROM SEQ_ARTICULO
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
/****** Object:  StoredProcedure [dbo].[ImportarClientes]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE PROCEDURE [dbo].[ImportarClientes] (@FicheroSEQ AS varchar(2500))
AS
BEGIN

	SET NOCOUNT ON;

DROP TABLE [dbo].[SEQ_CLIENTES]

CREATE TABLE [dbo].[SEQ_CLIENTES](
	[NumTarjeta] [varchar](50) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[CodigoPostal] [varchar](50) NOT NULL,
	[Poblacion] [varchar](150) NOT NULL,
	[Provincia] [varchar](150) NOT NULL,
	[Telefonos] [varchar](50) NOT NULL,
	[NIF] [varchar](50) NOT NULL,
	[Bloqueada] [varchar](50) NOT NULL,
	[FechaCaducidad] [varchar](50) NOT NULL,
	[Descuento] [varchar](50) NOT NULL,
	[VentaCredito] [varchar](50) NOT NULL,
	[ClienteCredito] [varchar](50) NULL,
	[SaldoPuntos] [varchar](50) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL
) ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_CLIENTES FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

/*Actualizar clientes*/
UPDATE CLIENTES
SET NombreFiscal = SEQ_CLIENTES.Nombre, Direccion = SEQ_CLIENTES.Direccion, CodigoPostal = SEQ_CLIENTES.CodigoPostal, Poblacion = SEQ_CLIENTES.Poblacion,
Provincia = SEQ_CLIENTES.Provincia, CIF = SEQ_CLIENTES.NIF, TelParticular = SEQ_CLIENTES.Telefonos,
ControlBaja = CASE SEQ_CLIENTES.Bloqueada WHEN 'S' THEN 1 ELSE 0 END, TieneTarjeta = 1, CaducidadTarjeta = SEQ_CLIENTES.FechaCaducidad, 
DescuentoTarjeta = CAST(REPLACE(SEQ_CLIENTES.Descuento,',','.') AS DECIMAL(18,4)),
AlbaranCredito = CASE SEQ_CLIENTES.VentaCredito WHEN 'S' THEN 1 ELSE 0 END, ClienteCredito = CASE LTRIM(RTRIM(SEQ_CLIENTES.ClienteCredito)) WHEN '' THEN NULL ELSE SEQ_CLIENTES.ClienteCredito END, 
SaldoPuntos = CAST(REPLACE(REPLACE(SEQ_CLIENTES.SaldoPuntos,',','.'),'	','') AS DECIMAL(18,4)),
Matricula = SEQ_CLIENTES.Matricula, Marca = SEQ_CLIENTES.Marca, Modelo = SEQ_CLIENTES.Modelo
FROM CLIENTES INNER JOIN SEQ_CLIENTES ON CLIENTES.Codigo = SEQ_CLIENTES.NumTarjeta

/*Nuevos clientes*/
INSERT INTO CLIENTES (Codigo, NombreFiscal, Direccion, CodigoPostal, Poblacion, Provincia, CIF, TelParticular, ControlBaja, TieneTarjeta, CaducidadTarjeta, DescuentoTarjeta, AlbaranCredito, ClienteCredito, SaldoPuntos, Matricula, Marca, Modelo)
SELECT NumTarjeta, Nombre, Direccion, CodigoPostal, Poblacion, Provincia, NIF, Telefonos, CASE SEQ_CLIENTES.Bloqueada WHEN 'S' THEN 1 ELSE 0 END, 1, FechaCaducidad,
CAST(REPLACE(Descuento,',','.') AS DECIMAL(18,4)),
CASE SEQ_CLIENTES.VentaCredito WHEN 'S' THEN 1 ELSE 0 END, CASE LTRIM(RTRIM(ClienteCredito)) WHEN '' THEN NULL ELSE ClienteCredito END, 
CAST(REPLACE(REPLACE(SEQ_CLIENTES.SaldoPuntos,',','.'),'	','') AS DECIMAL(18,4)),
Matricula, Marca, Modelo
FROM SEQ_CLIENTES
WHERE NumTarjeta NOT IN (SELECT Codigo FROM CLIENTES)

END





GO
/****** Object:  StoredProcedure [dbo].[ImportarClientesCredito]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
set @cadena = 'BULK INSERT SEQ_CLICREDI FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DELETE FROM CLICREDI

INSERT INTO CLICREDI (Codigo, NombreFiscal, NombreComercial, Direccion , CodigoPostal, Poblacion, Provincia, Nif, RecargoEquivalencia, Tarifa, DescuentoPP)
SELECT Codigo, NombreFiscal, NombreComercial, Direccion , CodigoPostal, Poblacion, Provincia, Nif, CASE RecargoEquivalencia WHEN 'S' THEN 1 ELSE 0 END, Tarifa, 
CAST(REPLACE(REPLACE(DtoPP,',','.'),'	','') AS DECIMAL(18,4))
FROM SEQ_CLICREDI

END




GO
/****** Object:  StoredProcedure [dbo].[ImportarCodigosBarras]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
set @cadena = 'BULK INSERT SEQ_COBARRAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
EXEC(@cadena)

DELETE FROM CODIGO_BARRAS

INSERT INTO CODIGO_BARRAS (CodigoBarras, Articulo_Id)
SELECT SEQ_COBARRAS.CodigoBarras, ARTICULOS.Id
FROM ARTICULOS INNER JOIN SEQ_COBARRAS ON ARTICULOS.Codigo = SEQ_COBARRAS.CodigoArticulo
LEFT JOIN CODIGO_BARRAS ON SEQ_COBARRAS.CodigoBarras = CODIGO_BARRAS.CodigoBarras
WHERE CODIGO_BARRAS.CodigoBarras IS NULL

END




GO
/****** Object:  StoredProcedure [dbo].[ImportarEntradas]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
set @cadena = 'BULK INSERT SEQ_ENTRADAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
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
/****** Object:  StoredProcedure [dbo].[ImportarFamilias]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
set @cadena = 'BULK INSERT SEQ_FAMILIAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
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
/****** Object:  StoredProcedure [dbo].[ImportarInventario]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
set @cadena = 'BULK INSERT SEQ_INVENTARIO FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
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
/****** Object:  StoredProcedure [dbo].[ImportarPromociones]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[ArticuloRegalo] [varchar](max) NULL,
	[FraccionSinCargo] [varchar](50) NULL,
	[UnidadesSinCargo] [varchar](50) NULL,
	[PrecioRegalo] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

declare @cadena as varchar(2500)
set @cadena = 'BULK INSERT SEQ_PROMOCIO FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
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
LTRIM(RTRIM(REPLACE(SEQ_PROMOCIO.ArticuloRegalo,'	',''))), 
CAST(REPLACE(SEQ_PROMOCIO.FraccionSinCargo,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(SEQ_PROMOCIO.UnidadesSinCargo,',','.') AS DECIMAL(18,4)), 
CAST(REPLACE(REPLACE(SEQ_PROMOCIO.PrecioRegalo,',','.'),'	','') AS DECIMAL(18,4)), 
CASE ISNULL(PROMOTIENDA.Tienda, SEQ_PROMOCIO.Tienda) WHEN 'TD' THEN 0 ELSE ISNULL(PROMOTIENDA.Tienda, SEQ_PROMOCIO.Tienda) END, ISNULL(PROMOTIENDA.Tienda,SEQ_PROMOCIO.Tarifa) 
FROM SEQ_PROMOCIO LEFT JOIN SEQ_PROMOCIO AS PROMOTIENDA 
ON SEQ_PROMOCIO.CodigoArticulo = PROMOTIENDA.CodigoArticulo
AND SEQ_PROMOCIO.Tarifa = PROMOTIENDA.Tarifa
AND SEQ_PROMOCIO.FechaInicio = PROMOTIENDA.FechaInicio
AND SEQ_PROMOCIO.FechaFin = PROMOTIENDA.FechaFin
AND CASE PROMOTIENDA.Tienda WHEN 'TD' THEN 0 ELSE PROMOTIENDA.Tienda END = @NUMEROALMACEN
WHERE SEQ_PROMOCIO.TARIFA = @TARIFATIENDA

/*CALAVIA: Actualizar promociones con tarifa 10*/

END

GO
/****** Object:  StoredProcedure [dbo].[ImportarTarifas]    Script Date: 19/09/2017 8:43:25 ******/
SET ANSI_NULLS ON
GO
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
set @cadena = 'BULK INSERT SEQ_TARIFAS FROM ''' + @FicheroSEQ + ''' WITH (FIELDTERMINATOR = ''\t'', ROWTERMINATOR = ''\n'', CODEPAGE = ''ACP'')'
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
USE [master]
GO
ALTER DATABASE [AydaraTPV_NAVAL] SET  READ_WRITE 
GO
