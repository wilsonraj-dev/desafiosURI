--https://www.beecrowd.com.br/judge/pt/problems/view/2606
SELECT p.id, p.name
FROM products as p
INNER JOIN categories as c
ON p.id_categories = c.id
WHERE lower(c.name) LIKE 'super%';