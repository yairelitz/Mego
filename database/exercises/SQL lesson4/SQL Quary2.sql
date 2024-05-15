USE NORTHWND
SELECT O.CustomerID,
       O.OrderID,
	   O.OrderDate,
	   C.CompanyName
FROM Orders AS O INNER JOIN
     Customers AS C
	 ON O.CustomerID = C.CustomerID

	 SELECT O.OrderDate,
	        O.OrderID,
			E.EmployeeID,
			E.FirstName
	 FROM Employees AS E INNER JOIN
	      Orders AS O
		  ON   O.EmployeeID = E.EmployeeID

SELECT C.CategoryID,
       C.CategoryName,
	   P.ProductID,
	   P.ProductName
FROM Categories AS C INNER JOIN
     Products AS P
	 ON P.CategoryID = C.CategoryID


SELECT C.CategoryID,
       C.CategoryName,
	   P.ProductID,
	   P.ProductName
FROM Categories AS C INNER JOIN
     Products AS P
	 ON P.CategoryID = C.CategoryID
	 WHERE C.CategoryName IN ('BEVERAGES', 'DAIRY PRODUCTS')
	--    תרגיל מספר 4 בעממוד 39    
	

SELECT C.CustomerID,
       C.CompanyName,
	   C.City,
	   C.Country

FROM Customers AS C INNER JOIN
     Products AS P 
	 ON P. = C.

SELECT S.SupplierID,
       S.CompanyName,
	   S.City,
	   P.ProductID,
	   P.ProductName,
	   P.QuantityPerUnit
FROM Suppliers AS S INNER JOIN
     Products AS P
	 ON S.SupplierID = P.SupplierID

SELECT C.CustomerID,
       C.City,
	   O.Freight
FROM Customers AS C INNER JOIN
     Orders AS O
	 ON C.CustomerID = O.CustomerID
WHERE C.City LIKE '[ABC]%' AND
      O.Freight >30 AND O.Freight < 120


SELECT E.EmployeeID,
       E.FirstName,
	   O.OrderID,
	   O.OrderDate
FROM Employees AS E INNER JOIN
     Orders AS O
	 ON O.EmployeeID = E.EmployeeID

SELECT C.CategoryID,
       C.CategoryName,
	   P.ProductID,
	   P.ProductName
FROM Categories AS C INNER JOIN
     Products AS P
	 ON C.CategoryID = P.CategoryID

SELECT C.CategoryID,
       C.CategoryName,
	   P.ProductID,
	   P.ProductName
FROM Categories AS C INNER JOIN
     Products AS P
	 ON P.CategoryID = C.CategoryID
WHERE C.CategoryName  LIKE 'Beverages' OR
      C.CategoryName LIKE 'DAIRY PRODUCTS'

SELECT C.CustomerID,
       C.CompanyName,
	   C.City,
	   C.Country,
	   OD.Quantity * OD.UnitPrice
FROM Customers AS C INNER JOIN
     Orders AS O INNER JOIN
	 [Order Details] AS OD
	 ON OD.OrderID = O.OrderID
	 ON O.CustomerID = C.CustomerID

SELECT
FROM Orders AS O