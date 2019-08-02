
# DGT.API

## Patrón de diseño

Para la creación de esta api he utilizado la arquitectura por capas.

En el caso práctico tenemos 4 proyectos dentro de la misma solución:

  

-   DGT.API - Donde encontramos los controladores para acceder a los datos
    
-   DGT.Data - Capa de acceso a datos, esta se encargará de la comunicación con base de datos en este caso.
    
-   DGT.Domain - Define el contexto de la aplicación, así como sus modelos de datos
    
-   DGT.Services - Capa de lógica de negocio.
    

## Base de datos

La base de datos la he creado, gracias a Entity Framework Core, con la tecnología llamada Code First.

A partir de los modelos de Domain y el context al arrancar la aplicación se genera una bbdd (InMemoryDatabase) en memoria, para facilitar su testeo. También he implementado un DataGenerator, para llenar mínimamente la base de datos.

Esta tecnología es muy usada para poder hacer testing tanto de la base de datos como de la aplicación, sin tener que “tocar” la base de datos real.

## Diagrama de base de datos

  

![](https://lh6.googleusercontent.com/BNghwFMNMo9nPIwb9SlGuaQWpisCt7XsigrHOCAW5ug5I0FZh5a-l7L3EdPWuJD5Xwf93VsqOC3cpif8SKIXleDajsOYU-Jt20UqY7hg4Wiz9mUwPqSZSfllu6AuUklxGyUIUmAm)

## Cómo ejecutar la aplicación

Para testear la aplicación solo hace faltar tener instalado y actualizado el Visual Studio 2017, o el Visual Studio 2019, con .NetCore 2.2 instalado.

## Llamadas a la api:

Link para postman con las llamadas de ejemplo:

[https://www.getpostman.com/collections/687f8860fcf8c64b0d11](https://www.getpostman.com/collections/687f8860fcf8c64b0d11)

En caso de no tener postman las llamadas y ejemplos son los siguientes:

  

### Crear infracción

POST: {{url}}/api/Infraccion/crear

JSON:
```JSON
{
  "Matricula": "7652GRH",
  "Fecha": "2015-02-26T00:00:00",
  "TipoInfraccionId": 2
}
```
### Crear tipo infracción

POST: {{url}}/api/TipoInfraccion/crear
JSON:
```JSON
{
  "Descripccion": "Exceso velocidad",
  "Puntos": 5
}
```
### Crear vehículo

POST: {{url}}/api/vehiculo/crear

JSON:
```JSON
{
  "Matricula": "6344Gzg",
  "NombreModelo": "Jimmy",
  "ConductoresHabituales": [
    {
      "DNI": "44442222R"
    }
  ]
}
```
### Crear conductor

POST: {{url}}/api/Conductor/crear

JSON:
```JSON
{
  "Apellidos": "Frotnera Luna",
  "DNI": "41234255R",
  "Nombre": "Biel",
  "Puntos": 10
}
```

  

### Historial de un conductor

GET: {{url}}/api/Infraccion/Historial/12341234R

### Tipos de infracción

GET: {{url}}/api/TipoInfraccion/

### 5 incidencias más habituales

GET: {{url}}/api/TipoInfraccion/Top5InfraccionesHabituales

### Top N conductores

GET: {{url}}/api/Conductor/top/2

  

# Comentarios

He añadido un sistema de autenticación JWT, pero solo he creado el controlador para generar el token, con los claims. Para quitar el acceso a los métodos necesarios únicamente haría falta añadir la etiqueta “[Authorize]” en el controlador.

  

Para la creación de los conductores, podría haber añadido un validador de DNI.

Falta la asociación de un conductor a un coche como endpoint, ahora mismo solo se pueden añadir conductores en la creació d

Falta la creación de los test unitarios.

Debido a ser una prueba técnica y a la falta de tiempo no los he generado, pero para una aplicación real, los generaría.
