--Aydara TPV 13.1.18
CREATE TABLE [dbo].[PARAMETROS_BASCULA](
	[Prefijo] [nchar](2) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[PosInicial_Articulo] [int] NULL,
	[PosFinal_Articulo] [int] NULL,
	[PosInicial_Peso] [int] NULL,
	[PosFinal_Peso] [int] NULL,
	[PosInicial_Importe] [int] NULL,
	[PosFinal_Importe] [int] NULL,
 CONSTRAINT [PK_PARAMETROS_BASCULA] PRIMARY KEY CLUSTERED 
(
	[Prefijo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
