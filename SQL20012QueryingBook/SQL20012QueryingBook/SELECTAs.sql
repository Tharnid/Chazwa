USE TSQL2012
GO

SELECT empid, firstname + N' ' + lastname
FROM HR.Employees;

-- Result has no name attribute