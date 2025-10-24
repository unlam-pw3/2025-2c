using PracticaClase1.Logica;

SimonDice simonDice = new SimonDice();


do
{
    simonDice.IniciarJuego();
    Console.WriteLine("\nSimon dice... ");
    simonDice.MostrarSecuenciaConPausa(2);
    Console.WriteLine("\n¿¿¿ Que dijo Simon ???");

    // Obtener la secuencia ingresada por el usuario y guardarla en un ArrayList de string
    string secuenciaUsuario = Console.ReadLine();

    if (secuenciaUsuario != null && simonDice.VerificarSecuencia(secuenciaUsuario))
    {
        Console.WriteLine("\n¡Correcto! Has seguido la secuencia.");

    }
    else
    {
        Console.WriteLine("\n¡Incorrecto! La secuencia era: " + simonDice.ObtenerSecuencia());
        Console.WriteLine("\nNo te desanimes, podes volver a jugar!");
        simonDice.ReiniciarJuego();
    }

} while (simonDice.CantidadDeJuegos != 0);


