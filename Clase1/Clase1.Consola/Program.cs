using Clase1.Logica;

JuegoAdivinarNumero juego = new JuegoAdivinarNumero();
juego.NuevaRonda();

while (!juego.AdivinaElNumero())
{
    Console.Write("Adivina el número del 1 al 100: ");
    int numero = int.Parse(Console.ReadLine());

    string mensaje = juego.RealizarIntento(numero);
    Console.WriteLine(mensaje);
}


