use NORTHWND


select o.CustomerID,
count(o.OrderID)

from Orders as o

group by o.CustomerID
having count (o.OrderID) >5 and count (o.OrderID) <20


select

from
group by
having

SELECT O.CustomerID,
 COUNT(O.CustomerID)
FROM Orders AS O
Group BY O.CustomerID,