using Clase1.Logica;

Console.WriteLine("Elige el juego:");
Console.WriteLine("1 - Ahorcado");
Console.WriteLine("2 - Adivinar Número");

string eleccion = Console.ReadLine();

if (eleccion == "1")
{
    //logica para juego ahorcado 
    //deberia pedir una palabra y ocultarla con guiones bajos 
    //en caso de que el usuario acierte una letra, //se debe mostrar la letra en todas las posiciones correspondiente 
    //si el usuario falla, se debe mostrarse que ha fallado //con un contador de fallos y un dibujo del ahorcado 
    //son 6 fallos permitidos
    // ------------------------
    // Juego Ahorcado
    // ------------------------
    JuegoAhorcado juegoAhorcado = new JuegoAhorcado();
    juegoAhorcado.ElegirPalabra();
    Console.WriteLine("Palabra oculta: " + juegoAhorcado.ObtenerPalabraOculta());
    Console.WriteLine("Tienes " + juegoAhorcado.FallosPermitidos() + " intentos para adivinar la palabra.");
    int fallosPermitidos = juegoAhorcado.FallosPermitidos();

    while (juegoAhorcado.ObtenerFallos() < fallosPermitidos && !juegoAhorcado.JuegoTerminado())
    {
        Console.Write("Introduce una letra: ");
        char letra = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (juegoAhorcado.AdivinarLetra(letra))
        {
            if (juegoAhorcado.JuegoTerminado())
            {
                Console.WriteLine("¡Felicidades! Has adivinado la palabra: " + juegoAhorcado.ObtenerPalabraOculta());
                return; // Termina el juego si se adivina la palabra
            }

            Console.WriteLine("¡Correcto! La palabra oculta ahora es: " + juegoAhorcado.ObtenerPalabraOculta());
        }
        else
        {
            Console.WriteLine($"Fallaste! Te quedan {fallosPermitidos - juegoAhorcado.ObtenerFallos()} intentos.");
            Console.WriteLine("La palabra oculta es: " + juegoAhorcado.ObtenerPalabraOculta());
        }
    }
}
else if (eleccion == "2")
{
    // ------------------------
    // Juego Adivinar Número
    // ------------------------
    JuegoAdivinarNumero juegoNumero = new JuegoAdivinarNumero();
    juegoNumero.IniciarJuego();

    Console.WriteLine("¡Bienvenido al juego Adivinar Número!");
    Console.WriteLine("Intenta adivinar el número entre 1 y 100.");

    int numero;
    string resultado="";
    do
    {
        Console.Write("Ingresa un número: ");
        if (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
            continue;
        }

        resultado = juegoNumero.EvaluarIntento(numero);
        Console.WriteLine(resultado);

    } while (resultado != "Correcto");

    Console.WriteLine($"¡Felicidades! Adivinaste el número en {juegoNumero.Intentos} intentos.");
}
else
{
    Console.WriteLine("Opción inválida. Reinicia el programa y elige 1 o 2.");
}
