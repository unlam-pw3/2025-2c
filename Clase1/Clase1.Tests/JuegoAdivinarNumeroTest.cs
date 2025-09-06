using Clase1.Logica;

namespace Clase1.Tests;

public class JuegoAdivinarNumeroTest
{
    [Fact]
    public void CalcularDiferencia_ReturnsCorrectAbsoluteDifference()
    {
        var juego = new JuegoAdivinarNumero();
        int resultado = juego.CalcularDiferencia(50, 30);
        Assert.Equal(20, resultado);
    }

    [Theory] // Para correr el mismo test varias veces con diferentes datos
    [InlineData(0, "¡Felicidades! Has adivinado el numero.")]
    [InlineData(3, "Muy caliente")]
    [InlineData(10, "Caliente")]
    [InlineData(20, "Tibio")]
    [InlineData(40, "Frio")]
    public void ObtenerResultado_ReturnsExpectedMessage(int diferencia, string esperado)
    {
        var juego = new JuegoAdivinarNumero();
        string resultado = juego.ObtenerResultado(diferencia);
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void IniciarJuego_ReturnsNumberBetween1And100()
    {
        var juego = new JuegoAdivinarNumero();
        int numero = juego.IniciarJuego();
        Assert.InRange(numero, 1, 100);
    }
}
