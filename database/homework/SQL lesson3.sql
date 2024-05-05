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
WHERE E.FirstName <> 'гег'

SELECT E.*
FROM Employees AS E
WHERE E.FirstName LIKE 'Nancy'SELECT C.*
FROM Customers AS C
WHERE C.Country LIKE 'USA' OR C.Country LIKE 'CANADA' OR
C.Country LIKE 'MEXICO'SELECT C.*
FROM Customers AS C
WHERE C.Country IN ('USA', 'CANADA', 'MEXICO')SELECT E.*FROM Employees AS EWHERE E.HireDate BETWEEN '12/31/1992' and '01/06/1993'SELECT C.CustomerID,       C.CompanyName,	   C.City,	   C.Country,	   C.ContactTitleFROM Customers AS CWHERE C.Country LIKE 'france' OR C.Country LIKE 'USA'SELECT E.EmployeeID,       E.FirstName,	   E.CityFROM Employees AS EWHERE E.City LIKE 'LONDON'SELECT P.ProductID,       P.ProductName,	   P.QuantityPerUnitFROM PRODUCTS AS P--WHERE P.QuantityPerUnit LIKE 'BOXES%'--WHERE P.QuantityPerUnit LIKE '%BOXES'--WHERE P.QuantityPerUnit LIKE '%BOXES%'WHERE P.QuantityPerUnit LIKE '___BOXES%'--WHERE P.QuantityPerUnit LIKE '[ABC]%'--ORDER BY P.ProductName--WHERE P.QuantityPerUnit LIKE 'A%'--WHERE P.QuantityPerUnit LIKE 'B%'SELECT DISTINCT        E.EmployeeID,       E.FirstNameFROM Employees AS E.SELECT E.BirthDateFROM Employees AS EWHERE MONTH(E.BirthDate) %2 = 0SELECT O.OrderID,       O.OrderDate,	   O.FreightFROM Orders AS OWHERE O.Freight > 10 AND O.Freight < 35SELECT E.EmployeeID,       E.FirstName,	   E.HireDate-DATEDIFFFROM Employees AS EWHERE E. < 1950