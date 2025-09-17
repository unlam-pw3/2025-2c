using Clase1.Logica;

namespace Clase1.Tests;

public class JuegoAdivinarNumeroTest
{
    [Fact]
    public void DevuelveCorrectoCuandoAdivina()
    {
        var juego = new JuegoAdivinarNumero();
        juego.SetNumeroObjetivo(50);
        string resultado = juego.IntentarAdivinar(50);
        Assert.Equal("¡Correcto! Adivinaste el número.", resultado);
        Assert.True(juego.JuegoTerminado(50));
    }

    [Theory]
    [InlineData(50, 10, "Frío")]
    [InlineData(50, 20, "Tibio")]
    [InlineData(50, 40, "Caliente")]
    [InlineData(50, 46, "Muy caliente")]
    public void DevuelveCalificacionSegunDiferencia(int objetivo, int intento, string esperado)
    {
        var juego = new JuegoAdivinarNumero();
        juego.SetNumeroObjetivo(objetivo);
        string resultado = juego.IntentarAdivinar(intento);
        Assert.Equal(esperado, resultado);
    }
    [Fact]
    public void SumaIntentosCorrectamente()
    {
        var juego = new JuegoAdivinarNumero();
        juego.SetNumeroObjetivo(50);
        juego.IntentarAdivinar(10);
        juego.IntentarAdivinar(20);
        juego.IntentarAdivinar(30);
        Assert.Equal(3, juego.ObtenerIntentos());
    }

    [Fact]
    public void DeveDarTrueCuandoElJuegoTermina()
    {
        var juego = new JuegoAdivinarNumero();
        juego.SetNumeroObjetivo(75);
        Assert.False(juego.JuegoTerminado(50));
        Assert.True(juego.JuegoTerminado(75));
    }
}