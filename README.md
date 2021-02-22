# Proyecto ADO.NET

Realiza un proyecto que accederá a la base de datos SQL Server de Equipos de Fútbol de la primera evaluación. Utilizando tecnología ADO .NET. Realizar los **9 formularios**.
Puntos obligatorios a tener en cuenta:

Menu Principal de la aplicación:

![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/mainMenu.PNG?raw=true)

1. Primer formulario:
   - Poder leer, insertar, eliminar y modificar todos los registros de las diversas tablas.
   - Utilizar **DataSets** y **DataView.**
   - Modificar las cabeceras del **DataGrid**
   - Visualizar texto con la cantidad de filas del DataGrid
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/tamperLogs.PNG?raw=true)
   
2. Segundo formulario:
   
   - Utilizar el **DataReader** con **DataGrid**
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/readLogs.PNG?raw=true)
   
3. Tercer formulario:
   
   - Utilizar dentro de un **DataGrid** una de sus columnas que sea un combo
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/comboDataGrid.PNG?raw=true)
   
4. Cuarto formulario:
   
   - Visualizar en un combo los registros de alguna de las tablas, una vez se seleccione un valor que visualice en un **DataGrid** los registros relacionados de otra tabla.
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/comboSelectedDataGrid.PNG?raw=true)
   
5. Quinto formulario
   
   - Hacer alguna inserción de registro de tabla, de modo que los datos los introduces en varios **TextBox**, **ComboBox**, **CheckBox…**
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/createLogs.PNG?raw=true)
   
6. Sexto formulario:
   
   - Hacer algún borrado de registro de tabla, mostrar los datos antes del borrado en varios **TextBox**, **CheckBox…**
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/deleteLogs.PNG?raw=true)
   
7. Séptimo formulario:
   
   - Hacer alguna edición de registro de tabla, mostrar los datos anteriores en varios **TextBox**, **ComboBox**, **CheckBox…**
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/updateLogs.PNG?raw=true)
   
8. Octavo formulario:
   - Seleccionar una celda de un **DataGrid** y en otra ventana los registros relacionados indicando también los valores del primer **DataGrid**
   - Utilizar **DataRelations.**
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/twoDataGridRelation.PNG?raw=true)
   
9. Noveno formulario:
   
   - Ejecutar todos los procedimientos y funciones de la base de datos.
   
   ![](https://github.com/Ayoamaro/Proyecto_ADO.NET/blob/main/docs/images/executePyF.PNG?raw=true)

Observaciones generales a tener en cuenta en el proyecto:

- [ ] Tu nombre deberá aparecer en todas las ventanas.
- [ ] Los datos de conexión con la base de datos estarán en un solo fichero (clase).
- [ ] No olvides de comentar el código
- [ ] No olvides de controlar todas las posibles excepciones (datos del servidor, tablas, columnas...)
