# MusicApp - Aplicación de reproducción de música

![MusicApp Arquitectura](https://github.com/alelolek/MusicApp/blob/main/DiagramaDeArquitectura.png)

**MusicApp** es una aplicación de reproducción de música desarrollada en C# .NET Core utilizando el framework de Windows Forms. Con esta aplicación, podrás disfrutar de tu música favorita de manera fácil y cómoda, tanto en modo usuario como en modo administrador.

## Descripción del programa

**MusicApp** ofrece un entorno de reproducción de música, donde los usuarios pueden explorar y reproducir canciones, artistas, álbumes y listas de reproducción. La aplicación está diseñada con una interfaz intuitiva y amigable, brindando una experiencia de usuario agradable.

Características clave:

- Modo usuario: Los usuarios pueden explorar y buscar su música favorita, crear listas de reproducción personalizadas y disfrutar de una reproducción fluida y de alta calidad. Además, pueden acceder a funciones de reproducción como pausar, reanudar, avanzar y retroceder.

- Modo administrador: Los administradores tienen acceso a funciones adicionales para gestionar la biblioteca de música. Pueden agregar, editar y eliminar canciones, artistas, álbumes y listas de reproducción.

## Arquitectura del proyecto

El proyecto de **MusicApp** sigue una arquitectura de capas para garantizar una estructura organizada y modular. A continuación se describe cada capa del proyecto:

1. Capa de Presentación: En esta capa se encuentran los formularios de Windows que componen la interfaz de usuario de la aplicación. Aquí se manejan las interacciones del usuario y se muestra la información relevante.

2. Capa de Negocio: En esta capa se implementa la lógica de negocio de la aplicación. Aquí se encuentran los servicios que se encargan de gestionar las funcionalidades principales de la aplicación, como la reproducción de música, la búsqueda y la gestión de la biblioteca.

3. Capa de Acceso a Datos: Esta capa se encarga de interactuar con la base de datos utilizando el cliente SQL. Aquí se definen los repositorios que se utilizan para acceder y manipular los datos almacenados en la base de datos.

4. Capa de Infraestructura: En esta capa se encuentran los componentes relacionados con la infraestructura técnica del sistema. Aquí se definen los archivos de configuración, la conexión a la base de datos y otros aspectos técnicos necesarios para el funcionamiento correcto de la aplicación.

## Diagrama de la base de datos

![Diagrama de la base de datos](https://github.com/alelolek/MusicApp/blob/main/DiagramDB.png)

El proyecto **MusicApp** utiliza una base de datos SQL Server para almacenar y gestionar la información. El diagrama de la base de datos muestra la estructura de las tablas y las relaciones entre ellas.

## Diseño de interfaz

Puedes encontrar el diseño de interfaz de **MusicApp** en el siguiente enlace de Figma: [Diseño Figma](https://www.figma.com/file/P2DVoMPE8s7puQZaWFWfXU/MusicApp?type=design&node-id=21%3A960&mode=design&t=epGuNrnKAjKdsesh-1).

## Requisitos del sistema

- Windows 10 o posterior.
- .NET Core 3.1 o posterior.
- SQL Server 2014 o posterior.

## Instalación

1. Clona o descarga el repositorio de **MusicApp** en tu máquina local.
2. Abre el proyecto en Visual Studio.
3. Restaura los paquetes NuGet necesarios para el proyecto.
4. Configura la conexión a la base de datos en el archivo de configuración.
5. Compila y ejecuta la aplicación.

## Contribución

Si deseas contribuir a **MusicApp**, puedes seguir los siguientes pasos:

1. Haz un fork del repositorio.
2. Crea una rama con una descripción clara de la función que deseas implementar o el error que deseas corregir.
3. Realiza los cambios en tu propia rama.
4. Envía un pull request explicando tus cambios y mejoras.

## Licencia

El proyecto **MusicApp** se distribuye bajo la licencia MIT. Puedes consultar el archivo [LICENSE](https://github.com/alelolek/MusicApp/blob/main/LICENSE.txt) para obtener más información.

¡Esperamos que disfrutes usando musicApp para reproducir tu música favorita de manera fácil y cómoda!