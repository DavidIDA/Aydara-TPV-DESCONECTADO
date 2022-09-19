ALTER TABLE dbo.TIENDAS ADD DtoSobreTarifa decimal(18, 2) NULL, DtoSobrePromocion decimal(18, 2) NULL
GO

UPDATE TIENDAS SET DtoSobreTarifa=0
UPDATE TIENDAS SET DtoSobrePromocion=0
