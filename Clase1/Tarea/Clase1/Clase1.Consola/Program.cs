using Clase1.Logica;

JuegoAdivinarNumero juegoAdivinarNumero = new JuegoAdivinarNumero();

Console.WriteLine("Bienvenido a adivinar numero");

bool juegoEnCurso = true;

while (juegoEnCurso)
{
    Console.Write("Introduce un numero entre 1 y 100: ");
    string entrada = Console.ReadLine();
    if (int.TryParse(entrada, out int numero))
    {
        string resultado = juegoAdivinarNumero.Adivinar(numero);
        Console.WriteLine(resultado);
        if (resultado.StartsWith("Adivinaste"))
        {
            juegoEnCurso = false;
        }
    }
    else
    {
        Console.WriteLine("Por favor, introduce un numero valido.");
    }
}