using TareaClase1.Logica;

Console.OutputEncoding = System.Text.Encoding.UTF8;
var descripcionesCercania = new Dictionary<Cercania, string>
{
    { Cercania.Frio, "Frío ❄️" },
    { Cercania.Tibio, "Tibio 🌤️" },
    { Cercania.Caliente, "Caliente 🔥" },
    { Cercania.MuyCaliente, "Muy caliente 🔥🔥" }
};


Console.WriteLine("Bienvenido al juego de Adivinar un Numero del 1 al 100!");
Console.WriteLine();
Console.WriteLine("- Ingrese un numero del 1 al 100 y en caso de no ser igual al elejido por el programa le dire que tan cerca esta. :)");
Console.WriteLine();


AdivinarNumero juego = new AdivinarNumero();

while (!juego.JuegoFinalizo())
{
    Console.Write("Numero: ");
    int numeroIngresado = int.Parse(Console.ReadLine());

    Cercania cercania = juego.IntentoAdivinarNumero(numeroIngresado);

    Console.WriteLine($"La cercania de su numero es: {descripcionesCercania[cercania]}");
    Console.WriteLine();
}

Console.WriteLine($"Felicidades! Ha adivinado el numero era {juego.ObtenerNumeroAAdivinar()}!");
