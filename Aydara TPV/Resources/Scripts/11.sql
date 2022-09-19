--Aydara TPV 13.2.01
CREATE TABLE [dbo].[ACTIVACIONES](
	[NumeroSerie] [nvarchar](50) NOT NULL,
	[NombreEquipo] [nvarchar](50) NULL,
	[CodigoActivacion] [nvarchar](50) NULL,
	[FechaInstalacion] [ntext] NULL,
	[FechaCaducidad] [ntext] NULL,
 CONSTRAINT [PK_NumerosSerie] PRIMARY KEY CLUSTERED 
(
	[NumeroSerie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]