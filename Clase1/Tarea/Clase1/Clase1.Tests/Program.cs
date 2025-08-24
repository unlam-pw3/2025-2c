using Clase1.Logica;

namespace Clase1.Tests;

public class JuegoAdivinarNumeroTest
{
    [Fact]
    public void AdivinarNumero_Correcto_DeberiaRetornarCorrecto()
    {
        var juego = new JuegoAdivinarNumero();
        int numeroSecreto = 50; // Asumimos que el número secreto es 50 para la prueba
        juego.ElegirNumeroSecreto(numeroSecreto);

        string resultado = juego.Adivinar(50);

        Assert.Equal("Adivinaste!!!", resultado);
    }
    [Theory]
    [InlineData(10, "Frío")]
    [InlineData(30, "Tibio")]
    [InlineData(40, "Caliente")]
    [InlineData(49, "Muy caliente")]
    public void AdivinarNumero_Incorrecto_DeberiaRetornarDiferentesMensajes(int numero, string mensajeEsperado)
    {
        var juego = new JuegoAdivinarNumero();
        int numeroSecreto = 50; 
        juego.ElegirNumeroSecreto(numeroSecreto);

        string resultado = juego.Adivinar(numero);

        Assert.Equal(mensajeEsperado, resultado);
    }
}