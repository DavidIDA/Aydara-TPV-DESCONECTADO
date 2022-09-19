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