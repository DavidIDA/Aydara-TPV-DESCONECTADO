ALTER TABLE dbo.TIENDAS ADD AlbaranFormatoTicket bit NULL, AlbaranFormatoA4 bit NULL
GO

UPDATE TIENDAS SET AlbaranFormatoTicket=1, AlbaranFormatoA4=1