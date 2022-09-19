--Aydara TPV 15.1.01
ALTER TABLE dbo.CLIENTES ADD Observaciones text NULL, Email nvarchar(100) NULL
GO
UPDATE CLIENTES SET Observaciones=''
UPDATE CLIENTES SET Email=''