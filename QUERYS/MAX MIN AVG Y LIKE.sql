--cuantos clientes no tienen territorio asignado
select count([TerritoryID])
from Sales.Customer
where TerritoryID is null

--cuantos clientes existen por territorio
Select [TerritoryID],count([CustomerID])
from Sales.Customer
group by TerritoryID

--el territorio que tiene mas clientes
Select top 1 [TerritoryID],count([CustomerID]) as cuentaClientes
from Sales.Customer
group by TerritoryID
order by cuentaClientes desc

select	count(s.TotalDue) as cuantos,
		max(s.TotalDue)as mayor,
		min(s.TotalDue)as minimo,
		AVG(s.TotalDue) as promedio
from Sales.SalesOrderHeader as s

--hacemos una consulta y le damos un alias que luego lo llamamos para obtener el maximo
select max(subQuery.cuentaClientes)
from 
(Select [TerritoryID],count([CustomerID]) as cuentaClientes
from Sales.Customer
group by TerritoryID) as subQuery


--HAVING= Es como el Where del Group By
Select [TerritoryID],count([CustomerID])
from Sales.Customer
group by TerritoryID
having Count(CustomerID)<1000

-- LIKE= los comodines son: % = cualquier caracter antes o despues, y _ = ignora ese caracter para la comparacion 
Select FirstName 
from Person.Person
Where FirstName LIKE 'H_%m%'