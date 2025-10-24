# Clase1 - Juegos de Consola en C#

## Descripción

Hicimos ejemplos Alta, Baja, Modificacion y Listado de la entidad "Tesoro" usando web api y creamos tests usando database in memory


### Modelo de datos

*Tesoro*
- [IdTesoro] [int] IDENTITY(1,1) NOT NULL,
- Nombre NVARCHAR(255),
- ImagenUrl NVARCHAR(1000),
- Latitud DECIMAL (9,6) NULL,
- Longitud DECIMAL (9,6) NULL,
- Valor INT NULL;

### Pruebas Unitarias

El proyecto incluye pruebas unitarias para asegurar el correcto funcionamiento de la lógica utilizando Database InMemory.

---

## Tarea

**Hacer Alta, Baja, Modificacion y Listado de la entidad "Cazatesoro" y creamos tests usando database in memory**


- IdCazatesoro [int] IDENTITY(1,1)  NOT NULL,
- Nick NVARCHAR(255),
- AvatarUrl NVARCHAR(1000) NULL

## Intrucciones
- Hacer un fork de este repositorio
- Crear Pull Request contra el repositorio original
---

¡Buena suerte con la nueva tarea!


Scaffold-DbContext "Server=.;Database=PW3-2025-2c-BusquedaTesoro;Trusted_Connection=True;TrustServerCertificate=True"  Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entidades
