using Clase1.Logica;

//Console.WriteLine("Hello, World!");

//logica para juego ahorcado
//deberia pedir una palabra y ocultarla con guiones bajos
//en caso de que el usuario acierte una letra,
//se debe mostrar la letra en todas las posiciones correspondiente
//si el usuario falla, se debe mostrarse que ha fallado
//con un contador de fallos y un dibujo del ahorcado
//son 6 fallos permitidos

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

    if(juegoAhorcado.AdivinarLetra(letra))
    {
        if(juegoAhorcado.JuegoTerminado())
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
