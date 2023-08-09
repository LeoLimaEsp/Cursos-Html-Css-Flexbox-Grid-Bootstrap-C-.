SELECT * FROM SalesLT.ProductCategory;
SELECT * FROM SalesLT.ProductModel;
SELECT * FROM SalesLT.Product;

-----  INNER JOIN -----
--1 Consultar tabla productos y categorias, para saber de que categoria es cada producto
SELECT P.ProductID, P.Name, P.ProductNumber, P.StandardCost,
		PC.Name AS CategoryName
	FROM SalesLT.Product AS P
	INNER JOIN  SalesLT.ProductCategory AS PC
		ON P.ProductCategoryID = PC.ProductCategoryID;

--2 Realizar consulta para saber de que Modelo es cada Producto
SELECT P.ProductID, P.Name, P.ProductNumber, P.StandardCost,
		PM.Name as ModelName
	FROM SalesLT.Product as P
	INNER JOIN SalesLT.ProductModel as PM
		ON P.ProductModelID = PM.ProductModelID;

--3 Realizar consulta para saber de que Modelo y Categorias es cada Producto
SELECT P.ProductID, P.Name, P.ProductNumber, P.StandardCost,
		PC.Name as CategoryName,
		PM.Name as ModelName, PM.CatalogDescription
	FROM SalesLT.Product as P
	INNER JOIN  SalesLT.ProductCategory as PC
		ON P.ProductCategoryID = PC.ProductCategoryID
	INNER JOIN SalesLT.ProductModel as PM
		ON P.ProductModelID = PM.ProductModelID;

--4 Realizar consulta para saber Las Direcciones (Address) de cada Cliente (Customer).
SELECT C.CustomerID, C.FirstName, C.LastName, C.CompanyName,
		CA.CustomerID, CA.AddressID,
		A.AddressID, A.AddressLine1, A.City, A.StateProvince, A.CountryRegion
	FROM SalesLT.Customer as C
	INNER JOIN SalesLT.CustomerAddress as CA
		ON C.CustomerID = CA.CustomerID
	INNER JOIN SalesLT.Address as A
		ON CA.AddressID = A.AddressID;

-- 5. Para añadir filtros, agregamos el WHERE al final.

-- Ej. Filtrar unicamente Clientes de Canada
SELECT C.CustomerID, C.FirstName, C.LastName, C.CompanyName,
		CA.CustomerID, CA.AddressID,
		A.AddressID, A.AddressLine1, A.City, A.StateProvince, A.CountryRegion
		FROM SalesLT.Customer as C
		INNER JOIN SalesLT.CustomerAddress AS CA
		ON C.CustomerID = CA.CustomerID
		INNER JOIN SalesLT.Address AS A
		ON CA.AddressID = A.AddressID
		WHERE CountryRegion = 'Canada' AND c.LastName NOT LIKE 'A%'
		ORDER BY A.StateProvince;
