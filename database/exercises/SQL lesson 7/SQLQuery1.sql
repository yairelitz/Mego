USE NORTHWND

SELECT C.CustomerID,
   C.Country
FROM Customers AS C
WHERE C.Country LIKE (SELECT C.Country
 FROM Customers AS C
 WHERE C.CustomerID LIKE 'ALFKI')

SELECT C.CustomerID,
  AVG (O.Freight) AS SelfAverage,
  C.CompanyName
FROM ORDERS AS O INNER JOIN
 Customers AS C
ON C.CustomerID = O.CustomerID
GROUP BY C.CustomerID, C.CompanyName
HAVING AVG(O.Freight) > (SELECT MAX(O.Freight)
 FROM Orders AS O
 WHERE O.CustomerID LIKE 'ALFKI')
ORDER BY AVG(O.Freight)


SELECT C.CustomerID,
       SUM(OD.Quantity * OD.UnitPrice)/(SELECT SUM(OD.Quantity * OD.UnitPrice)
	                                   FROM [Order Details] AS OD) AS RET
FROM Customers AS C INNER JOIN
     Orders AS O INNER JOIN
	 [Order Details] AS OD
	 ON OD.OrderID = O.OrderID
	 ON O.CustomerID = C.CustomerID
GROUP BY C.CustomerID


SELECT C.CustomerID,
       C.Country,   
	   'Customers' AS Cs1
FROM Customers AS C
UNION
SELECT E.FirstName,
       E.Country,
	   'Employee'
FROM Employees AS E
ORDER BY Cs1 DESC


