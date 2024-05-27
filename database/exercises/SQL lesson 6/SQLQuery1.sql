--USE NORTHWND
--SELECT SUM(OD.UnitPrice*OD.Quantity) AS SumOfOrders
--FROM Orders AS O INNER JOIN
-- [Order Details] AS OD
--ON OD.OrderID = O.OrderID

--SELECT O.CustomerID,
--       SUM(O.Freight) AS SumOfFret
--FROM Orders AS O
--GROUP BY O.CustomerID


--SELECT C.CustomerID,
--       C.COMPANYNAME,
--       SUM(O.Freight) AS SumOfFret
--FROM Customers AS C INNER JOIN
--Orders AS O 
--ON O.CustomerID = C.CustomerID
--GROUP BY C.CustomerID, C.CompanyName

SELECT C.CustomerID,
       C.CompanyName,
	   SUM(O.Freight) AS SUMOFF
FROM Customers AS C INNER JOIN
     Orders AS O
     ON O.CustomerID = C.CustomerID
GROUP BY C.CustomerID, C.CompanyName
HAVING SUM(O.Freight) > 500
----------------------------------------
SELECT YEAR(O.OrderDate) AS YR,
       SUM(O.Freight)
FROM Orders AS O
WHERE YEAR(O.OrderDate)BETWEEN 1994 AND 2003
GROUP BY YEAR(O.OrderDate)
ORDER BY YR
--------------------------------------------
--SELECT C.CustomerID,
--       C.CompanyName,
--	   O.CustomerID AS OID
--FROM Customers AS C LEFT JOIN
--     Orders AS O
--	 ON O.CustomerID = C.CustomerID
--WHERE O.OrderID IS NULL 

--SELECT O.CustomerID,
--       SUM(O.Freight)
--FROM Orders AS O
--GROUP BY SUM(O.Freight)
--HAVING O.CustomerID LIKE '[ABC]%',
--       DATEPART(QUARTER) > 500
--ORDER BY

--SELECT O. CustomerID,
--       C.COMPANYNAME,
--       SUM(O.Freight),
--	   C.Country
--FROM Customers AS C INNER JOIN
--     Orders AS O
--	 ON O.CustomerID = C.CustomerID
--GROUP BY O.CustomerID,
--         SUM(O.Freight)
--HAVING C.Country LIKE 'FRANCE' OR
--C.Country LIKE 'GERMANY'
--SUM(O.Freight) BETWEEN 500 AND 2000 