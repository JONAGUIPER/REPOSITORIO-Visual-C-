--Busacar el nombre y apellido de los clientes que han hecho pedidos y que aparezcan solamente una vez en el resultado
--Otra manera de hacerla MAS EFICIENTE
Select cus.CustomerID AS customerid,
       case when (per.MiddleName  IS NULL)
		    then per.FirstName
	        else per.FirstName
                      + ' '
					  + per.MiddleName
       end 
       + ' '
	   + per.LastName   nomape
  from Person.Person    per,
       Sales.Customer   cus
 where per.BusinessEntityID = cus.PersonID
   and exists (select 'X'
                 from Sales.SalesOrderHeader   ped
				where ped.CustomerID = cus.CustomerID)
 order by per.LastName,
          per.FirstName;

Select Person.Person.FirstName, Person.Person.LastName
From Person.Person
Where Person.Person.BusinessEntityID
IN--CUANDO UN FILTRO SE VA A COMPARAR CON UN CONJUNTO DE VALORES SE USA: IN
(	
	Select Distinct Customer.PersonID
	From Sales.Customer,sales.SalesOrderHeader
	Where sales.Customer.CustomerID=Sales.SalesOrderHeader.CustomerID
)