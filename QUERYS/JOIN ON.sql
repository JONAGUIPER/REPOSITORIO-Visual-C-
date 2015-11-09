--	join
Select c.PersonID, (p.FirstName+' '+p.LastName) as nombreCompleto
from Sales.Customer as c 
join Person.Person as p 
on c.PersonID=p.BusinessEntityID
order By p.FirstName