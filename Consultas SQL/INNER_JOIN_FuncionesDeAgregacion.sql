-- inner join
SELECT * FROM SalesLT.ProductCategory AS PC	
	INNER JOIN SalesLT.Product AS P
		ON PC.ProductCategoryID = P.ProductCategoryID;

--left join 
SELECT * FROM SalesLT.ProductCategory AS PC
	LEFT JOIN SalesLT.Product AS P
		ON PC.ProductCategoryID = P.ProductCategoryID;

--right join
SELECT * FROM SalesLT.ProductCategory AS PC
	RIGHT JOIN SalesLT.Product AS P
		ON PC.ProductCategoryID = P.ProductCategoryID;

-- FUNCIONES DE AGREGACI�N
-- Calcular un promedio usando de Average AVG()
SELECT AVG(ListPrice) AS AVGListPrice
	FROM SalesLT.Product;

-- Calcular la suma de todos los precios, usando SUM()
SELECT SUM(ListPrice)
	FROM SalesLT.Product;

-- Calcular (saber) cual es el producto que tiene el menor precio, usando MIN()
SELECT MIN(ListPrice) AS MinPrice
	FROM SalesLT.Product;

-- Calcular (saber) cual es el producto que tiene el mayor precio, usando MAX()
SELECT MAX(ListPrice)
	FROM SalesLT.Product;

--- Invocar varias funciones de agregaci�n en el mismo SELECT
SELECT MIN(ListPrice) as minimo, MAX(ListPrice) as maximo, AVG(ListPrice) as promedio, SUM(ListPrice) as suma
	FROM SalesLT.Product;

-- NO se pueden mezclar columnas con funciones de agregaci�n
SELECT Name, ListPrice, MIN(ListPrice)
	FROM SalesLT.Product;

--- GROUP BY : sirve para agrupar registros y aplicar funciones de agregaci�n sobre cada grupo formado.
	SELECT Color, AVG(ListPrice) as Promedio
		FROM SalesLT.Product
		GROUP BY Color;

-- Se puede agrupar por m�s de una columna
	SELECT Color, Size, AVG(ListPrice) as Promedio
		FROM SalesLT.Product
		GROUP BY Color, Size
		ORDER BY Color, Size;

-- Se puede usar m�s de una funci�n para los mismos grupos e inner join mientras todos lleven funcion de agregaci�n
	SELECT AVG(ListPrice) as Promedio, MIN(ListPrice) as MasBarato, AVG(StandardCost) as Prom, MIN(PC.ProductCategoryID)
		FROM SalesLT.Product as P
		INNER JOIN SalesLT.ProductCategory AS PC
		ON PC.ProductCategoryID = P.ProductCategoryID

-- Se puede usar m�s de una funci�n para los mismos grupos
	SELECT Color, AVG(ListPrice) as Promedio, MIN(ListPrice) as MasBarato, AVG(StandardCost) as Prom
		FROM SalesLT.Product
		GROUP BY Color;