--https://www.beecrowd.com.br/judge/pt/problems/view/2623
SELECT P.NAME
     , C.NAME 
FROM products AS P
INNER JOIN categories AS C ON P.id_categories = C.ID
WHERE P.amount > 100 
  AND P.id_categories IN (1, 2, 3, 6, 9);