using Clase1.Logica;



        JuegoAdivinarNumero juego = new JuegoAdivinarNumero();
        juego.IniciarJuego();

        Console.WriteLine("Bienvenido al juego 'Adiviná el número'.");
        Console.WriteLine("Estoy pensando en un número entre 1 y 100. ¡Intentá adivinarlo!");

        bool terminado = false;
        while (!terminado)
        {
            Console.Write("Ingresá tu intento: ");
            string? entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numeroIngresado))
            {
                string resultado = juego.IntentarAdivinar(numeroIngresado);
                Console.WriteLine(resultado);
                terminado = juego.JuegoTerminado(numeroIngresado);
            }
            else
            {
                Console.WriteLine("Por favor, ingresá un número válido.");
            }
        }

        Console.WriteLine($"¡Felicitaciones! Lo lograste en {juego.ObtenerIntentos()} intentos.");
    