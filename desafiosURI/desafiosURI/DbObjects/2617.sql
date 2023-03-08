--https://www.beecrowd.com.br/judge/pt/problems/view/2617
SELECT P.NAME
	 , PV.NAME FROM
PRODUCTS AS P
INNER JOIN PROVIDERS AS PV ON PV.ID = P.ID_PROVIDERS
WHERE PV.NAME = 'Ajax SA'