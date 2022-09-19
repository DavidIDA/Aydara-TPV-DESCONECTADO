--Aydara TPV 16.05.01
ALTER TABLE TIENDAS ADD DirectorioFicheroBasculas nvarchar(max) NULL, EE_DireccionFTP nvarchar(max) NULL, EE_UsuarioFTP nvarchar(max) NULL, EE_PasswordFTP nvarchar(max) NULL

GO

UPDATE TIENDAS SET DirectorioFicheroBasculas = '', EE_DireccionFTP = '', EE_UsuarioFTP = '', EE_PasswordFTP = ''