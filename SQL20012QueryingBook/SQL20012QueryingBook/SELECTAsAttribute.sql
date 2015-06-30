USE TSQL2012
GO

SELECT empid, firstname + N' ' + lastname AS fullname
FROM HR.Employees;

-- fullname as the attribute for the select