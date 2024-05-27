SELECT O.CustomerID,
 COUNT(O.CustomerID)
FROM Orders AS O
Group BY O.CustomerID,