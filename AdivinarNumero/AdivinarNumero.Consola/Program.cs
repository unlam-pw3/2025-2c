using AdivinarNumero.Logica;

JuegoAdivinarNumero juegoAdivinarNumero = new JuegoAdivinarNumero();
Console.WriteLine("Intenta adivinar el número entre 1 y 100.");

while (true)
{
    Console.Write("Introduce un número: ");
    if (!int.TryParse(Console.ReadLine(), out int intento))
    {
        Console.WriteLine("Ingresa un número válido.");
        continue;
    }

    string resultado = juegoAdivinarNumero.EvaluarIntento(intento);

    if (resultado == "¡Correcto!")
    {
        Console.WriteLine($"¡Felicidades! Adivinaste el número {intento}");
        break;
    }

    Console.WriteLine(resultado);
}