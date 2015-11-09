--FILTROS: WHERE
SELECT *
FROM sales.SalesOrderHeader
WHERE OrderDate>='20140101'
AND OrderDate<='20140404'