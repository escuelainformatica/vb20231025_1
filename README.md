# ejercicio 1

Cree un proyecto nuevo y una base de datos nueva.

Cree la siguiente tabla en la base de datos:
* Compra
   * Id (entero, llave primaria y autonumerico)
   * Cliente (texto)
   * Producto (texto)
   * PrecioUnitario (entero)
   * Cantidad (entero)
Agregue datos de ejemplo
* Cargue las librerias del entity framework y cree los modelos
* Luego, en el proyecto, muestre las compras en una grilla usando el modelo Compra generado
* Cree un DTO llamado CompraDTO con los siguientes campos:

* CompraDTO
   * Cliente (texto)
   * Producto (texto)
   * Total (entero)
* Y cargue una nueva grilla usando una consulta a la base de datos

```sql
select cliente,producto,preciounitario*cantidad total from compra
```
* Para hacer eso, modifique el contexto y agregue lo siguiente

```vbnet
Public Overridable Property CompraDTOs As DbSet(Of CompraDTO)
```

