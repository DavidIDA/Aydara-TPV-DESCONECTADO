--Aydara TPV 16.06.01
ALTER TABLE TICKETS ADD TotalRecargo decimal(18, 2) NULL, TotalDtoPP decimal(18, 2) NULL

GO

UPDATE TICKETS SET TotalRecargo = 0, TotalDtoPP = 0

GO

ALTER TABLE HISTORICO_TICKETS ADD TotalRecargo decimal(18, 2) NULL, TotalDtoPP decimal(18, 2) NULL

GO

UPDATE HISTORICO_TICKETS SET TotalRecargo = 0, TotalDtoPP = 0

GO

ALTER TABLE HISTORICO_TICKETS_ANULADOS ADD TotalRecargo decimal(18, 2) NULL, TotalDtoPP decimal(18, 2) NULL

GO

UPDATE HISTORICO_TICKETS_ANULADOS SET TotalRecargo = 0, TotalDtoPP = 0