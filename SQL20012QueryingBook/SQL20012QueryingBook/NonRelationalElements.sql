USE TSQL2012;

SELECT custid, YEAR(orderdate)
FROM Sales.Orders
ORDER BY 1, 2;

SELECT DISTINCT custid, YEAR(orderdate) AS orderyear
FROM Sales.Orders;