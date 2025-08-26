// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EjercicioNumOculto.Logica;

JuegoAdivinarNumero juegoAdivinarNumero = new JuegoAdivinarNumero();
int _numRandom = juegoAdivinarNumero.GetNumeroRandom();
int _numUsuario = 0;


while (!juegoAdivinarNumero.JuegoTerminado(_numRandom, _numUsuario))
{
    Console.Write("Ingrese un numero del 1 al 100: ");
    _numUsuario = int.Parse(Console.ReadLine());
    Console.WriteLine(juegoAdivinarNumero.IndicaCercaniaAlUsuario(_numUsuario, _numRandom));
}

Console.WriteLine("Numero correcto, juego terminado");