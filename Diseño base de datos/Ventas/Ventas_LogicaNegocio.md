# Ventas

## Listado de entidades

### Clientes **(ED)**

- cliente_id **(PK)**
- nombre
- apellidos
- telefono **(UQ)**
- email **(UQ)**
- direccion
- codigo postal
- ciudad
- pais **(FK)**

### Productos **(ED|EC)**

- productos_id **(PK)**
- nombre
- descripcion
- foto
- precio
- cantidad

### Ventas **(ED)**

- venta_id **(PK)**
- cliente_id **(FK)**
- fecha
- monto
- 

### Articulos_x_venta **(EP)**

- articulo_id **(PK)**
- venta_id **(FK)**
- producto_id **(FK)**
- cantidad_productos

### Paises **(EC)**

- pais_id **(PK)**
- nombre 
- dominio **(UQ)**

## Relaciones

1. Un **cliente** tiene **pais** (_1 - 1_).
1. Una **cliente** genera **venta** (_1 - M_).
1. Una **venta** tiene **articulo** (_1 - M_).
1. Un **articulo** es un **producto** (_1 - 1_).

## Diagramas

### Modelo relacional de la BD

![Modelo relacional de la BD](./VentasModeloRelacional%20(1).jpg)

## Reglas de negocio

### Clientes

1. Crear nuevo cliente.
1. Actualizar datos de cliente.
1. Leer cliente particular registrado.
1. Leer todos los clientes registrados.
1. Borrar cliente particular registrado.

### Productos

1. Crear nuevo producto.
1. Actualizar datos de producto.
1. Leer producto particular registrado.
1. Leer todos los productos registrados.
1. Borrar producto particular registrado.
1. Cada que haya una venta restar a la cantidad de productos disponibles, el número de articulos que se vendieron.
1. Reporte de ventas por periodo de tiempo.

### Articulos_x_venta

1. Crear nuevo articulo.
1. Actualizar datos de articulo.
1. Leer articulo particular registrado.
1. Leer todos los articulos registrados.
1. Borrar articulo particular registrado.
1. Leer todos los articulos de una venta.
1. Leer todos los articulos de un producto.
1. Leer todos los articulos de un cliente.

### Ventas

1. Crear nueva venta.
1. Leer venta particular registrada.
1. Leer todas las ventas registradas.
1. Leer todas las ventas de un cliente.
1. Leer todas las ventas de un producto.
1. Actualizar una venta.
1. Eliminar una venta.

### Paises 

1. Leer pais particular registrado.
1. Leer todos los paises registrados.
1. Crear nuevo pais.
1. Eliminar un pais.
