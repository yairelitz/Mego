USE NORTHWND
SELECT OD.OrderID,
       OD.ProductID,
	   OD.Quantity,
	   OD.UnitPrice,
	   OD.Quantity* OD.UnitPrice AS TotalPerRaw


FROM [Order Details] AS OD

SELECT P. ProductName,
       P. UnitPrice,
	   P. UnitPrice*3.5 AS sheqels

FROM Products AS P

SELECT

FROM [Order Details] AS OD

SELECT E.*
FROM Employees AS E
WHERE EmployeeId = 5 OR EmployeeID = 6

SELECT *
FROM Employees AS E
WHERE E.FirstName <> '���'

SELECT E.*
FROM Employees AS E
WHERE E.FirstName LIKE 'Nancy'
FROM Customers AS C
WHERE C.Country LIKE 'USA' OR C.Country LIKE 'CANADA' OR
C.Country LIKE 'MEXICO'
FROM Customers AS C
WHERE C.Country IN ('USA', 'CANADA', 'MEXICO')