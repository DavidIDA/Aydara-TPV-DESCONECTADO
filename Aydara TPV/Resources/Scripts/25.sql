--Aydara TPV 15.10.02
ALTER TABLE TIENDAS ADD [Comunicaciones_Terminales] [nvarchar](max) NULL
GO
UPDATE TIENDAS SET Comunicaciones_Terminales = ''