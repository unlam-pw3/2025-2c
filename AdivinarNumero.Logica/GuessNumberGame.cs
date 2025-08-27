namespace AdivinarNumero.Logica;

public sealed class GuessNumberGame
{
    private readonly int _target;

    public GuessNumberGame() : this(Random.Shared.Next(1, 101)) { }

    public GuessNumberGame(int target)
    {
        if (target < 1 || target > 100)
            throw new ArgumentOutOfRangeException(nameof(target), "El número debe estar entre 1 y 100.");
        _target = target;
    }

    public int Target => _target;

    public GuessResult Evaluate(int guess)
    {
        if (guess < 1 || guess > 100)
            throw new ArgumentOutOfRangeException(nameof(guess), "El intento debe estar entre 1 y 100.");

        int diff = Math.Abs(_target - guess);
        if (diff == 0) return GuessResult.Correcto;
        if (diff <= 5) return GuessResult.MuyCaliente;
        if (diff <= 15) return GuessResult.Caliente;
        if (diff <= 30) return GuessResult.Tibio;
        return GuessResult.Frio;
    }

    public static string Describe(GuessResult result) => result switch
    {
        GuessResult.Correcto => "¡Adivinaste! 🎉",
        GuessResult.MuyCaliente => "Muy caliente 🔥",
        GuessResult.Caliente => "Caliente ♨️",
        GuessResult.Tibio => "Tibio 🙂",
        GuessResult.Frio => "Frío 🧊",
        _ => "¿?"
    };
}
