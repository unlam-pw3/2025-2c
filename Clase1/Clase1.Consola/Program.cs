using Clase1.Logica;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("         MENÚ DE JUEGOS         ");
        Console.WriteLine("================================");
        Console.WriteLine("1) Juego del Ahorcado");
        Console.WriteLine("2) Juego de Adivinar el Número");
        Console.Write("Elige una opción: ");
        string opcion = Console.ReadLine();
        Console.WriteLine();

        switch (opcion)
        {
            case "1":
                JuegoAhorcado juegoAhorcado = new JuegoAhorcado();
                juegoAhorcado.ElegirPalabra();
                Console.WriteLine("Palabra oculta: " + juegoAhorcado.ObtenerPalabraOculta());
                Console.WriteLine("Tienes " + juegoAhorcado.FallosPermitidos() + " intentos para adivinar la palabra.");
                int fallosPermitidos = juegoAhorcado.FallosPermitidos();

                while (juegoAhorcado.ObtenerFallos() < fallosPermitidos && !juegoAhorcado.JuegoTerminado())
                {
                    Console.Write("Introduce una letra: ");
                    char letra = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (juegoAhorcado.AdivinarLetra(letra))
                    {
                        if (juegoAhorcado.JuegoTerminado())
                        {
                            Console.WriteLine("¡Felicidades! Has adivinado la palabra: " + juegoAhorcado.ObtenerPalabraOculta());
                            return;
                        }

                        Console.WriteLine("¡Correcto! La palabra oculta ahora es: " + juegoAhorcado.ObtenerPalabraOculta());
                    }
                    else
                    {
                        Console.WriteLine($"Fallaste! Te quedan {fallosPermitidos - juegoAhorcado.ObtenerFallos()} intentos.");
                        Console.WriteLine("La palabra oculta es: " + juegoAhorcado.ObtenerPalabraOculta());
                    }
                }
                break;

            case "2":
                JuegoAdivinarNumero juego = new JuegoAdivinarNumero();
                juego.NuevaRonda();

                while (!juego.AdivinaElNumero())
                {
                    Console.Write("Adivina el número del 1 al 100: ");
                    int numero = int.Parse(Console.ReadLine());

                    string mensaje = juego.RealizarIntento(numero);
                    Console.WriteLine(mensaje);
                }
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}
