--Aydara TPV 14.1.01
ALTER TABLE EXISTENCIAS ALTER COLUMN ExistenciaInicial decimal(18,4)

GO

ALTER TABLE EXISTENCIAS ALTER COLUMN ExistenciaActual decimal(18,4)

GO

ALTER TABLE INVENTARIO ALTER COLUMN Cantidad decimal(18,4)