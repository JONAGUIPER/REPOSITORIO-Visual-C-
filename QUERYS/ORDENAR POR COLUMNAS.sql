--ORDENAR POR COLUMNAS
SELECT p.FirstName, p.MiddleName, p.LastName
FROM Person.Person as p
ORDER BY p.LastName DESC, p.FirstName 