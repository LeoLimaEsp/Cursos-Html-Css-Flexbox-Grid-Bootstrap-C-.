# Ventas

## Listado de entidades

### Clientes **(ED)**

- cliente_id **(PK)**
- nombre
- apellidos
- telefono
- email
- direccion
- codigo postal
- ciudad
- pais **(FK)**

### Productos **(EC)**

- productos_id **(PK)**
- nombre
- descripcion
- foto
- precio
- cantidad

### Ventas

### paises **(EC)**

- pais_id
- nombre
- dominio