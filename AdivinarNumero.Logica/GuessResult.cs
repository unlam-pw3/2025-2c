namespace AdivinarNumero.Logica;

public enum GuessResult
{
    Correcto,
    MuyCaliente, // diff <= 5 (y != 0)
    Caliente,    // 6..15
    Tibio,       // 16..30
    Frio         // > 30
}
