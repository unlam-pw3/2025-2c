using PracticaClase1.Logica;

        SimonDice simonDice = new SimonDice();
        simonDice.IniciarJuego();

        Console.WriteLine("Simon dice... " + simonDice.ObtenerSecuencia());
        Console.Write("¿¿¿ Que dijo Simon ???");

        // Obtener la secuencia ingresada por el usuario y guardarla en un ArrayList de string
        string secuenciaUsuario = Console.ReadLine();
        List<string> secuenciaUsuarioList = new List<string>();
        if (secuenciaUsuario != null)
        {
            secuenciaUsuarioList = secuenciaUsuario.Split(' ').ToList();
        }

        if (simonDice.VerificarSecuencia(secuenciaUsuarioList))
        {
            Console.WriteLine("¡Correcto! Has seguido la secuencia.");
            return;
        }
        else
        {
            Console.WriteLine("¡Incorrecto! La secuencia era: " + simonDice.ObtenerSecuencia());
            Console.WriteLine("No te desanimes, podes volver a jugar!");
            simonDice.ReiniciarJuego();
        }
 