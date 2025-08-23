using AdivinarNumero.Logica;

namespace AdivinarNumero.Tests;

public class JuegoAdivinarNumeroTest
{
    public void EvaluarIntento_DeberiaRetornarCategoriaSegunDiferencia(int numeroSecreto, int intento, string esperado)
    {
        var juego = new JuegoAdivinarNumero(numeroSecreto);
        string resultado = juego.EvaluarIntento(intento);
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void ObtenerNumeroSecreto_DeberiaRetornarElNumeroCorrecto()
    {
        int numero = 77;
        var juego = new JuegoAdivinarNumero(numero);
        int obtenido = juego.ObtenerNumeroSecreto();
        Assert.Equal(numero, obtenido);
    }
}
