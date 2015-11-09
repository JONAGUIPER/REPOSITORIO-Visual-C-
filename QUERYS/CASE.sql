--CASE
select distinct CustomerID,
	case TerritoryID
		When 1 then 'NUNCAjAMAS'
		When 2 then 'Liliput'
		else 'Nadena"'
		end as paisImaginario


from Sales.Customer
Order by paisImaginario