--	4Consultas usando JOIN, las tablas involucradas en cada consulta aparecen entre paréntesis.

--4.1 Crear una consulta para mostrar la descripción(ProductDescription) correspondiente a cada modelo de producto (ProductModel).  Considerando la tabla intermedia que maneja la relación entre ellas: (ProductModelProductDescription).
SELECT PM.Name, Description, PM.ProductModelID FROM SalesLT.ProductDescription AS PD
	INNER JOIN SalesLT.ProductModelProductDescription AS PMPD
		ON PD.ProductDescriptionID = PMPD.ProductDescriptionID
			INNER JOIN SalesLT.ProductModel AS PM
				ON PM.ProductModelID = PMPD.ProductModelID;

--4.2 Crear una consulta para saber el nombre: FirstName y LastName, del Cliente (Customer) que ha realizado una orden de compra(SalesOrderHeader). Selecciona las columnas de cada tabla que consideres relevantes.
SELECT C.CustomerID, FirstName, LastName, SO.SalesOrderID AS 'Orden de compra', SO.OrderDate FROM SalesLT.Customer AS C
	INNER JOIN SalesLT.SalesOrderHeader AS SO
		ON C.CustomerID = SO.CustomerID;

--4.3 Crear una consulta para saber que Productos (Product) está comprando un Cliente(Customer), por cada Orden de compra (SalesOrderHeader), (SalesOrderDetail). Selecciona las columnas de cada tabla que consideres relevantes.
SELECT C.FirstName, C.LastName, C.EmailAddress, P.ProductID, P.Name, OH.TotalDue FROM SalesLT.Customer AS C
	INNER JOIN SalesLT.SalesOrderHeader AS OH
		ON C.CustomerID = OH.CustomerID
			INNER JOIN SalesLT.SalesOrderDetail AS SO
				ON OH.SalesOrderID = SO.SalesOrderID
					INNER JOIN SalesLT.Product AS P
						ON SO.ProductID = P.ProductID
							ORDER BY ProductID;
					
			