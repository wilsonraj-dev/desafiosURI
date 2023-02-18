--https://www.beecrowd.com.br/judge/pt/problems/view/2744
SELECT id
     , password
     , MD5(password) AS MD5
FROM account