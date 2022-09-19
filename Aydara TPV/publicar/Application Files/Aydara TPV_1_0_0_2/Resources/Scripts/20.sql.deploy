/****** Object:  Table [dbo].[HISTORICO_TICKETS_ANULADOS]    Script Date: 06/11/2015 14:28:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HISTORICO_TICKETS_ANULADOS]') AND type in (N'U'))
DROP TABLE [dbo].[HISTORICO_TICKETS_ANULADOS]
GO
/****** Object:  Table [dbo].[HISTORICO_TICKETS_LINEAS]    Script Date: 06/11/2015 14:28:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HISTORICO_TICKETS_ANULADOS_LINEAS]') AND type in (N'U'))
DROP TABLE [dbo].[HISTORICO_TICKETS_ANULADOS_LINEAS]
GO
/****** Object:  Table [dbo].[HISTORICO_TICKETS_ANULADOS]    Script Date: 06/11/2015 09:43:28 ******/
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
 CONSTRAINT [PK_HISTORICO_TICKETS_ANULADOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HISTORICO_TICKETS_ANULADOS_LINEAS]    Script Date: 06/11/2015 09:43:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HISTORICO_TICKETS_ANULADOS_LINEAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ticket_Id] [int] NULL,
	[CodigoArticulo] [nvarchar](7) NULL,
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
 CONSTRAINT [PK_HISTORICO_TICKETS_ANULADOS_LINEAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]