--https://www.beecrowd.com.br/judge/pt/problems/view/2622
SELECT P.NAME 
FROM customers AS P
INNER JOIN legal_person AS L ON P.id = L.id_customers;