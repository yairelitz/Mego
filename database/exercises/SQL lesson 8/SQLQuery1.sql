USE NORTHWND
SELECT *
FROM Customers AS C INNER JOIN
     Orders AS O ON O.CustomerID = C.CustomerID

SELECT E.EmployeeID,
      -- E.LastName + ' ' +E.FirstName AS 'שם מלא',
	   SUM(OD.Quantity * OD.UnitPrice) AS SIKUM,
	   AVG(OD.Quantity * OD.UnitPrice) AS MEMUTZA
FROM Employees AS E INNER JOIN
     Orders AS O INNER JOIN
	 [Order Details] AS OD
	 ON OD.OrderID = O.OrderID
	 ON O.EmployeeID = E.EmployeeID
WHERE E.CITY LIKE 'LONDON'
GROUP BY E.EmployeeID


SELECT C.CustomerID,
       C.CompanyName,
	   C.City,
	   C.Country,
	   OD.Quantity * OD.UnitPrice AS PRICEPERROW,
	   P.ProductID,
	   P.ProductName,
	   OD.Quantity
	   
FROM Customers AS C INNER JOIN
     Orders AS O INNER JOIN [Order Details] AS OD
	 INNER JOIN Products AS P
	 ON P.ProductID = OD.ProductID
	 ON OD.OrderID = O.OrderID
	 ON O.CustomerID = C.CustomerID


SELECT C.CustomerID,
       C.City,
	   O.Freight
FROM Customers AS C INNER JOIN
     Orders AS O
ON O.CustomerID = C.CustomerID
WHERE C.City LIKE '[ABC]%'
GROUP BY C.CustomerID
     