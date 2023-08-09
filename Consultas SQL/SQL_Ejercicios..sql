--------------------------------Consultas para la tabla Address:
--1.1	Registros que sean del Country: Canada.
SELECT * FROM SalesLT.Address
	WHERE CountryRegion = 'Canada'; 

--1.2	Registros cuyo StateProvince inicie con la letra ‘A’.
SELECT * FROM SalesLT.Address
	WHERE StateProvince LIKE 'A%'; 

--1.3	Registros que sean de  las Cities: Phoenix, Chicago, Vancouver, Ottawa.
SELECT * FROM SalesLT.Address
	WHERE City IN ('Phoenix', 'Chicago', 'Vancouver', 'Ottawa'); 

--------------------------------Consultas para la tabla Customer:
--2.1	Registros cuyo Phone inicie con ‘15’.
SELECT * FROM SalesLT.Customer
	WHERE Phone LIKE '15%'; 

--2.2	Registros cuyo MiddleName no sea null y LastName inicie con la letra ‘B’.
SELECT * FROM SalesLT.Customer
	WHERE LastName LIKE 'B%' AND MiddleName IS NOT NULL;

--2.3	Los primeros 20 registros, mostrando únicamente las columnas: Title, FirstName, MiddleName, LastName, Suffix, CompanyName, SalesPerson, EmailAddress.
SELECT TOP (20) Title, FirstName, MiddleName, LastName, Suffix, CompanyName, SalesPerson, EmailAddress
	FROM SalesLT.Customer

--2.4	Mostrar los diferentes LastName que existen en la tabla.
SELECT DISTINCT LastName	
	FROM SalesLT.Customer;

--2.5	Registros cuyo Title sea diferente de null, su LastName no inicie con la letra ‘A’ y ordenados por el FirstName.
SELECT * FROM SalesLT.Customer
	WHERE Title IS NOT NULL AND LastName NOT LIKE 'A%' 
	ORDER BY FirstName;

--------------------------------Consultas para la tabla Product:
--3.1	Registros que sean de Color: Yellow, Blue o Silver, cuyo StandardCost se encuentre entre 500 y 1000 o bien se encuentre entre 10 y 50, ordenados por StandardCost.
SELECT * FROM SalesLT.Product
	WHERE Color IN ('Yellow', 'Blue', 'Silver') AND StandardCost BETWEEN 500 AND 1000 OR StandardCost BETWEEN 10 AND 50
	ORDER BY StandardCost;




