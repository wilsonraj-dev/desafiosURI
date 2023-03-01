--https://www.beecrowd.com.br/judge/pt/problems/view/2611
SELECT m.id
	 , m.name 
FROM movies as m
INNER JOIN genres AS g ON M.id_genres = g.id
WHERE g.description = 'Action';