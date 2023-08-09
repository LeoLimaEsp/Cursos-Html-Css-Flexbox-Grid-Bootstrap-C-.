-- Consulta 1: select básico
SELECT * FROM SalesLT.Product;

-- Consulta 2: select con pocas columnas
SELECT Name, ProductNumber, Color, ListPrice
		FROM SalesLT.Product

-- Consulta 3: Filtrar los productos de color rojo
SELECT * FROM SalesLT.Product
		WHERE Color = 'red'; 

-- Consulta simple de las direcciones
SELECT * FROM SalesLT.Address;

-- Consulta para filtrar direcciones que son del estado de TEXAS 
SELECT AddressID, AddressLine1, PostalCode, City, StateProvince, CountryRegion
		FROM SalesLT.Address
		WHERE StateProvince = 'Texas'
		ORDER BY City, PostalCode;

--                      Combinando operadores lógicos                  --

-- Direcciones de Texas, que son unicamente de las cidades Austin y Dallas.
SELECT AddressID, AddressLine1, PostalCode, City, StateProvince, CountryRegion
		FROM SalesLT.Address
		WHERE StateProvince = 'Texas' AND (City = 'Austin' OR City = 'Dallas' OR City = 'Houston'); 

-- Direcciones de Texas, que no sean de Austin, San Antonio y Dallas.
SELECT AddressID, AddressLine1, PostalCode, City, StateProvince, CountryRegion
		FROM SalesLT.Address
		WHERE StateProvince = 'Texas' AND NOT City = 'Austin' AND NOT City = 'San Antonio' AND NOT City = 'Dallas';

--          Operador LIKE             --
-- operador like no es sensible a mayusculas/minusculas
-- Direcciones cuya ciudad inicie con la letra 'C'
SELECT AddressID, AddressLine1, PostalCode, City, StateProvince, CountryRegion
		FROM SalesLT.Address
		WHERE City LIKE 'C%';

-- Direcciones cuya ciudad contenga la letra 'x'
SELECT AddressID, AddressLine1, PostalCode, City, StateProvince, CountryRegion
	FROM SalesLT.Address
	WHERE City LIKE '%x%';

------      OPERADOR BETWEEN      --------
-- operador sirve para comparar un rango numerico (enteros o decimales)
SELECT *
		FROM SalesLT.Product
		WHERE ListPrice BETWEEN 1 AND 5;

