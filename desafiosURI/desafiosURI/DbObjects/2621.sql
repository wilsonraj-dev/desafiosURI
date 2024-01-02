SELECT P.NAME 
FROM products AS P
INNER JOIN providers AS PV ON P.id_providers = Pv.id
WHERE PV.NAME LIKE 'P%' 
  AND P.amount BETWEEN 10 AND 20