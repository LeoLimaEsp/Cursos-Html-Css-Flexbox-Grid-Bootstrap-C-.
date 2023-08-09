-------------------------------   DISTINCT   -------------------------------------------------
-- DISCTINCT: para saber cuales son todos los paises que tiene la tabla
SELECT DISTINCT CountryRegion
	FROM SalesLT.Address;
-- Usando dos columnas: se filtran todas las posibles parejas distintas
SELECT DISTINCT City, CountryRegion
	FROM SalesLT.Address
	ORDER BY City;
--------------------------------- NULL values --------------------------------------------------
-- Ej. Mostrar todos los productos cuyo tamaño (size) sea nulo.
SELECT *
	FROM SalesLT.Product
	WHERE size IS NULL;
-- Ej. Mostrar todos los productos cuyo tamaño (size) no sea nulo.
SELECT *
	FROM SalesLT.Product
	WHERE size IS NOT NULL;
--------------------------------- SELECT TOP -------------------------------------------
-- Ej. Mostrar los primeros 10 productos de AddressID, AddressLine1, PostalCode, City, StateProvince, CountryRegion.
SELECT TOP (10) AddressID, AddressLine1, PostalCode, City, StateProvince, CountryRegion
	FROM SalesLT.Address
	WHERE city <> 'Ottawa';
--------------------------------- Operador IN -------------------------------------------
-- Ej. Filtrar los registros que pertenezcan a la ciudades de Dallas o Montreal o Chicago
SELECT * 
	FROM SalesLT.Address
	WHERE City IN ('Dallas', 'Montreal', 'Chicago');
--------------------------------- Alias (usando AS) -------------------------------------------
SELECT AddressLine1 AS Calle, PostalCode AS CodigoPostal, City AS Ciudad
	FROM SalesLT.Address;
-- También podemos usar los alias, para mezclar valores de más de una columna, en una sola
-- Ej. Juntar los valores de AddressLines1, City, StateProvince. En una sola columna llamada Direccion
SELECT  AddressLine1, 
		City, 
		StateProvince, 
		AddressLine1 +' '+ City +' '+ StateProvince AS Direccion
	FROM SalesLT.Address;