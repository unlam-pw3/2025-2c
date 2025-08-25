using Clase1Tarea.Logica;

namespace Clase1Tarea.Tests;

public class JuegoAhorcadoTest
{
    [Fact]
    public void NumeroSecreto_EstaDentroDelRango()
    {
        JuegoAdivinar juego = new JuegoAdivinar();
        string feedback = juego.EvaluarIntento(1);
        Assert.NotNull(feedback);
    }

    // Test ObtenerFeedback (calor) por separado
    [Theory]
    [InlineData(0, "¡Felicitaciones, ganaste!")]
    [InlineData(3, "Muy caliente")]
    [InlineData(10, "Caliente")]
    [InlineData(25, "Tibio")]
    [InlineData(50, "Frío")]
    public void EvaluarIntento_RetornaFeedbackCorrecto(int diferencia, string feedbackEsperado)
    {
        JuegoAdivinar juego = new JuegoAdivinar(50); 
        int intento = 50 - diferencia;
        string feedback = juego.EvaluarIntento(intento);
        Assert.StartsWith(feedbackEsperado, feedback);
    }

    [Theory]
    [InlineData(30, "más alto")]
    [InlineData(50, "más bajo")]
    [InlineData(60, "más bajo")]
    public void ObtenerProximidad_RetornaDireccionCorrecta(int intento, string esperado)
    {
        JuegoAdivinar juego = new JuegoAdivinar(50);
        string resultado = juego.ObtenerProximidad(intento);
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(50, 30, "Tibio, intenta un número más alto.")]
    [InlineData(50, 48, "Muy caliente, intenta un número más alto.")]
    [InlineData(50, 55, "Muy caliente, intenta un número más bajo.")]
    public void EvaluarIntento_RetornaFeedbackCompleto(int secreto, int intento, string esperado)
    {
        JuegoAdivinar juego = new JuegoAdivinar(secreto);
        string resultado = juego.EvaluarIntento(intento);
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void IntentosRestantes_DisminuyeDespuesDeCadaIntento()
    {
        JuegoAdivinar juego = new JuegoAdivinar(50);
        Assert.Equal(6, juego.IntentosRestantes());

        juego.EvaluarIntento(30);
        Assert.Equal(5, juego.IntentosRestantes());

        juego.EvaluarIntento(40);
        Assert.Equal(4, juego.IntentosRestantes());
    }

    [Fact]
    public void PuedeSeguirIntentando_RetornaFalsoDespuesDe6Intentos()
    {
        JuegoAdivinar juego = new JuegoAdivinar(50);
        for (int i = 0; i < 6; i++)
        {
            Assert.True(juego.PuedeSeguirIntentando());
            juego.EvaluarIntento(30 + i);
        }
        Assert.False(juego.PuedeSeguirIntentando());
    }

    [Fact]
    public void EvaluarIntento_RetornaMensajeFinDeJuegoDespuesDe6IntentosFallidos()
    {
        JuegoAdivinar juego = new JuegoAdivinar(50);
        for (int i = 0; i < 6; i++)
        {
            juego.EvaluarIntento(30 + i);
        }
        string feedback = juego.EvaluarIntento(30);
        Assert.Equal("Se acabaron los intentos. ¡Suerte la próxima! El número era 50.", feedback);
    }

    [Fact]
    public void EsNumeroCorrecto_RetornaVerdaderoSiElNumeroEsCorrecto()
    {
        JuegoAdivinar juego = new JuegoAdivinar(50);
        Assert.True(juego.EsNumeroCorrecto(50));
        Assert.False(juego.EsNumeroCorrecto(30));
    }
}

