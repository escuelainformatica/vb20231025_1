# ejercicio 1

Cree un proyecto nuevo y una base de datos nueva.

Cree la siguiente tabla en la base de datos:
* Compra
   * Id (entero, llave primaria y autonumerico)
   * Cliente (texto)
   * Producto (texto)
   * PrecioUnitario (entero)
   * Cantidad (entero)
   
Y Agregue datos de ejemplo

* Cargue las librerias del entity framework y cree los modelos

Agregar librerias
En la consola de nuget
```
Install-Package EntityFrameworkCore.VisualBasic -Version 7.0.0
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.11
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 7.0.11
```
Generar el codigo para entity frameworks
Cambie lo que esta entre comillas por su conexion.

En la consola de nuget
```
Scaffold-DbContext "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\cursovb2023\WinFormsApp4\WinFormsApp4\b
```


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

