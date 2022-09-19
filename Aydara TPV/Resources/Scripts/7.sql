--Aydara TPV  13.1.10
ALTER PROCEDURE [dbo].[CrearTablaTemporal_Clientes]
AS	
SET NOCOUNT ON
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLIENTES]') AND type in (N'U'))
DROP TABLE [dbo].[COMUNICACIONES_CLIENTES]
CREATE TABLE [dbo].[COMUNICACIONES_CLIENTES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NOT NULL,
	[NombreFiscal] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Direccion] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[CodigoPostal] [nvarchar](5) COLLATE Modern_Spanish_CI_AS NULL,
	[Poblacion] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL,
	[Provincia] [nvarchar](30) COLLATE Modern_Spanish_CI_AS NULL,
	[CIF] [nvarchar](15) COLLATE Modern_Spanish_CI_AS NULL,
	[TelParticular] [nvarchar](30) COLLATE Modern_Spanish_CI_AS NULL,
	[TelMovil] [nvarchar](30) COLLATE Modern_Spanish_CI_AS NULL,
	[ControlBaja] [bit] NULL,
	[TieneTarjeta] [bit] NULL,
	[CaducidadTarjeta] [datetime] NULL,
	[DescuentoTarjeta] [decimal](18, 4) NULL,
	[AlbaranCredito] [bit] NULL,
 CONSTRAINT [PK_COMUNICACIONES_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
SET NOCOUNT OFF