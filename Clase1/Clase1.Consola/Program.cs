using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1.Logica;

JuegoAdivinarNumero juego = new JuegoAdivinarNumero();
int numeroAleatorio = juego.IniciarJuego();
Console.WriteLine("Bienvenido al juego de adivinar un numero!");

while (juego.JuegoTerminado())
{
    Console.Write("Ingrese un numero entre 1 y 100: ");
    string numeros = Console.ReadLine();
    int numeroIngresado = int.Parse(numeros);
    Console.WriteLine();

    int diferencia = juego.CalcularDiferencia(numeroIngresado, numeroAleatorio);
    if (diferencia >= 0 && diferencia <=100)
    {
        if (diferencia == 0)
        {
            Console.WriteLine(juego.ObtenerResultado(diferencia));
            juego.JuegoTerminado();
            return;
        }
        Console.WriteLine(juego.ObtenerResultado(diferencia));
    }
    else
    {
        Console.WriteLine(juego.ObtenerResultado(diferencia));
        
    }
}