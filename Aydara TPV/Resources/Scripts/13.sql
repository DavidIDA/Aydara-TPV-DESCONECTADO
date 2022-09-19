--Aydara TPV 14.1.07
UPDATE TICKETS 
SET ImporteEfectivo=ImporteTotal, ImporteCambios=0
WHERE ImporteCambios>99999

UPDATE HISTORICO_TICKETS
SET ImporteEfectivo=ImporteTotal, ImporteCambios=0
WHERE ImporteCambios>99999