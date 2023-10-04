# Corazón de Café - Stock Manager ☕️

Corazón de Café es una aplicación de gestión de inventario especialmente diseñada como distribuidora de café a nivel nacional en Argentina. Este repositorio te proporciona una solución robusta y fácil de usar para controlar tus existencias de café, gestionar empleados y asegurarte de que cada cliente disfrute de la mejor taza de café.

## Inicialización del Proyecto

Sigue estos simples pasos para poner en marcha tu sistema de gestión de inventario de Corazón de Café:

### 1. Importar Base de Datos
Utiliza SQL Server para importar el archivo `.bacpac` que se encuentra en la raiz del proyecto. El nombre de la base de datos debe ser "CorazonDeCafe". ¡Asegúrate de que el nombre sea exactamente este!

### 2. Configurar String Connection
Dentro del directorio "Properties" encontrarás un archivo llamado "Resources.resx". En este archivo, localiza la variable `connectionString` que vincula la base de datos. Por defecto, el servidor está configurado como "localhost". Si estás utilizando un servidor diferente, modifica solo la parte `server=<own-server>`.

### 3. Correr la Aplicación
Para ingresar como administrador, utiliza las siguientes credenciales:
- Usuario: `pc-admin`
- Contraseña: `admin`

Una vez dentro, dirígete a la sección "Employees" para añadir nuevos empleados y asignarles roles específicos. Por defecto, el DNI del empleado se utiliza como contraseña.

## Funcionalidades Principales

- **Gestión de Inventario:** Realiza un seguimiento detallado de tu inventario de café, desde granos hasta productos terminados.
- **Gestión de Empleados:** Añade, edita y elimina empleados, asigna roles y controla los privilegios de acceso.
- **Registro de Ventas:** Registra cada venta para mantener un historial preciso y tomar decisiones informadas.
