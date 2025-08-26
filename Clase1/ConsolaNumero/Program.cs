using Clase1.Logica;

namespace Clase1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var juegoNumero = new JuegoNumero();

            juegoNumero.ElegirNumeroAleatorio();

            Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
            Console.WriteLine("He elegido un número entre 1 y 100. ¿Puedes adivinar cuál es?");
            Console.WriteLine("Te iré diciendo qué tan cerca estás:");
            Console.WriteLine("Frío: diferencia > 30, Tibio: 16-30, Caliente: 6-15, Muy Caliente: 0-5");
            Console.WriteLine("¡Comencemos!");
            Console.WriteLine("-----------------------------------");

            while (!juegoNumero.JuegoTerminado)
            {
                Console.Write("Introduce un número: ");

                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingresa un número válido:");
                }

                string resultado = juegoNumero.AdivinarNumero(numero);
                Console.WriteLine(resultado);
            }

            Console.WriteLine("¡Felicidades! Has adivinado el número.");
        }
    }
}
