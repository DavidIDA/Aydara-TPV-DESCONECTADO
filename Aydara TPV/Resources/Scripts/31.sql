--Aydara TPV 16.06.01
ALTER TABLE TIENDAS ADD RegistroMercantil nvarchar(max) NULL

GO

UPDATE TIENDAS SET RegistroMercantil = ''