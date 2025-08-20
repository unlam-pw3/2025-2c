# Clase1 - Juegos de Consola en C#

## Descripción

Esta solución contiene la implementación de un juego de consola clásico: **Ahorcado**. El proyecto está desarrollado en C# (.NET 9) y cuenta con pruebas unitarias para validar la lógica principal.

### Juego Ahorcado

- El usuario debe adivinar una palabra oculta, letra por letra.
- Por cada letra acertada, se revela en todas las posiciones correspondientes.
- Por cada fallo, se incrementa un contador y se muestra la cantidad de intentos restantes.
- El usuario tiene hasta 6 fallos permitidos antes de perder la partida.
- El juego termina cuando se adivina la palabra completa o se alcanzan los fallos máximos.

### Pruebas Unitarias

El proyecto incluye pruebas unitarias para asegurar el correcto funcionamiento de la lógica del juego, verificando casos como la selección de la palabra y el proceso de adivinanza de letras.

---

## Tarea

**Implementar una nueva aplicación de consola para el juego "Adivinar número":**

- El programa debe elegir un número aleatorio entre 1 y 100.
- El usuario debe intentar adivinar el número.
- Por cada intento, el juego debe indicar si el usuario está "frío", "tibio", "caliente" o "muy caliente" según la cercanía al número objetivo:
  - **Frío:** Diferencia mayor a 30.
  - **Tibio:** Diferencia entre 16 y 30.
  - **Caliente:** Diferencia entre 6 y 15.
  - **Muy caliente:** Diferencia de 5 o menos.
- El juego termina cuando el usuario adivina el número.

## Estructura del proyecto

- `Clase1.Consola`: Aplicación de consola principal.
- `Clase1.Logica`: Lógica de los juegos.
- `Clase1.Tests`: Pruebas unitarias.

## Intrucciones
- Hacer un fork de este repositorio
- Crear Pull Request contra el repositorio original
---

¡Buena suerte con la nueva tarea!
