using Clase2_Logica;
/*Implementar una nueva aplicación de consola para el juego "Adivinar número":

El programa debe elegir un número aleatorio entre 1 y 100.
El usuario debe intentar adivinar el número.
Por cada intento, el juego debe indicar si el usuario está "frío", "tibio", "caliente" o "muy caliente" según la cercanía al número objetivo:
Frío: Diferencia mayor a 30.
Tibio: Diferencia entre 16 y 30.
Caliente: Diferencia entre 6 y 15.
Muy caliente: Diferencia de 5 o menos.
El juego termina cuando el usuario adivina el número.*/


JuegoAdivinarNumero juegoAdivinarNumero = new JuegoAdivinarNumero();
Console.WriteLine("¡Bienvenido al juego de Adivinar el Número!");
juegoAdivinarNumero.ElegirNumero();

while (!juegoAdivinarNumero.JuegoTerminado())
{
    Console.Write("Introduce tu intento (número entre 1 y 100): ");
    if (int.TryParse(Console.ReadLine(), out int intento))
    {
        string estado = juegoAdivinarNumero.EvaluarIntento(intento);
        Console.WriteLine($"Estado: {estado}");
        if (juegoAdivinarNumero.JuegoTerminado())
        {
            Console.WriteLine("¡Felicidades! Has adivinado el número.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Por favor, introduce un número válido.");
    }
}



