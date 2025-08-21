
/*
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
*/

using Clase1.Tarea.Logica;

var nombre = "Uriel Yurquina";
Console.WriteLine($"Probando, hola {nombre}");


var numeroSecreto = new Random().Next(1, 101);

IJuegoService juegoService = new JuegoService(numeroSecreto);
Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
Console.WriteLine("He elegido un número entre 1 y 100. Intenta adivinarlo.");

var resultado = new string(' ', 50);

do
{
   Console.WriteLine("Ingresa un numero:");
   string? entrada= Console.ReadLine();

   // o iniciar aca el int numeroIngresado;
   if(!int.TryParse(entrada, out int numeroIngresado))
   {
      Console.WriteLine("Entrada inválida. Por favor, ingresa un número entre 1 y 100.");
      continue;
   }

   if (juegoService.EvaluarRangoPermitido(numeroIngresado))
   {
      juegoService.IncrementarIntentos();
      resultado = juegoService.VerificarNumeroIngresado(numeroIngresado);
      Console.WriteLine($"Estado: {resultado}\nCantidad de intentos: {juegoService.CantidadIntentos}");
   }
   else
   {
      Console.WriteLine("El número ingresado no está dentro del rango permitido (1-100). Inténtalo de nuevo.");
   }
}   while(!resultado.Equals("GANASTE!"));

