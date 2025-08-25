using Clase1Tarea.Logica;

Console.WriteLine("¡Bienvenido al juego de Adivinar el Número!");
Console.WriteLine("Tienes 6 intentos para adivinar el número entre 1 y 100.");

JuegoAdivinar juego = new JuegoAdivinar();
bool haGanado = false;

while (!haGanado && juego.PuedeSeguirIntentando())
{
    Console.Write("Ingresa tu intento: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int intento) || intento < 1 || intento > 100)
    {
        Console.WriteLine("Por favor, ingresa un número válido entre 1 y 100.");
        continue;
    }

    string feedback = juego.EvaluarIntento(intento);
    Console.WriteLine(feedback);

    if (juego.PuedeSeguirIntentando() && !juego.EsNumeroCorrecto(intento))
    {
        Console.WriteLine($"Te quedan {juego.IntentosRestantes()} intentos.");
    }
    
    haGanado = juego.EsNumeroCorrecto(intento);
}
