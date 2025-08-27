using AdivinarNumero.Logica;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== Juego: Adivinar número (1 a 100) ===");
Console.WriteLine("Escribí un número entre 1 y 100. O escribí 'q' para salir.\n");

var game = new GuessNumberGame();
int intentos = 0;

while (true)
{
    Console.Write("Tu intento: ");
    var input = Console.ReadLine();

    if (input is null) continue;
    if (input.Trim().Equals("q", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Saliendo. El número era {game.Target}.");
        break;
    }

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("Entrada inválida. Ingresá un número entre 1 y 100, o 'q' para salir.");
        continue;
    }

    if (guess is < 1 or > 100)
    {
        Console.WriteLine("Fuera de rango. Debe ser entre 1 y 100.");
        continue;
    }

    intentos++;
    var result = game.Evaluate(guess);
    Console.WriteLine(GuessNumberGame.Describe(result));

    if (result == GuessResult.Correcto)
    {
        Console.WriteLine($"\n¡Ganaste en {intentos} intento(s)! El número era {game.Target}.");
        break;
    }
}
