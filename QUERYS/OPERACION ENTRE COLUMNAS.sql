select Unitprice, OrderQty,UnitPriceDiscount, PreciConDescuento=(unitprice*OrderQty)*(1-UnitPriceDiscount) 
from sales.SalesOrderDetail as slo
where slo.UnitPriceDiscount>0;
