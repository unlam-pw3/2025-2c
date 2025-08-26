using TareaClase1.Logica;

AdivinarNumero juegoAdivinarNumero = new AdivinarNumero();
int numeroRandom = juegoAdivinarNumero.ObtenerNumeroRandom();
int numeroInicial = 0;

while(!juegoAdivinarNumero.FinalizoElJuego(numeroRandom, numeroInicial))
{
    Console.WriteLine("Introduci un numero: ");
    int numeroIngresado = int.Parse(Console.ReadLine());
    numeroInicial = numeroIngresado;

    Console.WriteLine(juegoAdivinarNumero.DeterminarDiferencia(numeroRandom, numeroIngresado));
}

Console.WriteLine("El juego terminó, el número era " + numeroRandom);