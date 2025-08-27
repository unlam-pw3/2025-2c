using PracticaClase1.Logica;

namespace PracticaClase1.Test;

public class SimonDiceTest
{
    [Fact]
    public void InstanciarUnJuegoSimonDice_TieneCeroPartidasJugadas()
    {
        SimonDice simonDiceTest = new SimonDice();

        int numeroObtenido = simonDiceTest.CantidadDeJuegos;
        int numeroEsperado = 0;

        Assert.Equal(numeroEsperado, numeroObtenido);
    }

    [Fact]
    public void IniciarJuegoSimonDice_TieneUnaPartidaJugadas()
    {
        SimonDice simonDiceTest = new SimonDice();

        simonDiceTest.IniciarJuego();
        int numeroObtenido = simonDiceTest.CantidadDeJuegos;
        int numeroEsperado = 1;

        Assert.Equal(numeroEsperado, numeroObtenido);
    }

    [Fact]
    public void IniciarJuegoSimonDice_SePuedeObtenerSecuencia()
    {
        SimonDice simonDiceTest = new SimonDice();

        simonDiceTest.IniciarJuego();
        string secuenciaObtenida = simonDiceTest.ObtenerSecuencia();

        Assert.NotEmpty(secuenciaObtenida);
    }

    [Fact]
    public void VerificarSecuenciaSimonDice_SecuenciaCorrecta_RetornaTrue()
    {
        SimonDice simonDiceTest = new SimonDice();

        simonDiceTest.IniciarJuego();
        string secuenciaObtenida = simonDiceTest.ObtenerSecuencia();

        bool resultado = simonDiceTest.VerificarSecuencia(secuenciaObtenida);

        Assert.True(resultado);
    }

    [Fact]
    public void VerificarSecuenciaSimonDice_SecuenciaIncorrecta_RetornaFalse()
    {
        SimonDice simonDiceTest = new SimonDice();

        simonDiceTest.IniciarJuego();
        string secuenciaObtenida = simonDiceTest.ObtenerSecuencia();

        bool resultado = simonDiceTest.VerificarSecuencia(secuenciaObtenida + "X");

        Assert.False(resultado);
    }

    [Fact]
    public void ReiniciarJuegoSimonDice_TieneCeroPartidasJugadas()
    {
        SimonDice simonDiceTest = new SimonDice();

        simonDiceTest.IniciarJuego();
        simonDiceTest.ReiniciarJuego();
        int numeroObtenido = simonDiceTest.CantidadDeJuegos;
        int numeroEsperado = 0;

        Assert.Equal(numeroEsperado, numeroObtenido);
    }

    [Fact]
    public void JugarDosVecesSimonDice_TieneDosPartidasJugadas()
    {
        SimonDice simonDiceTest = new SimonDice();

        simonDiceTest.IniciarJuego();
        simonDiceTest.IniciarJuego();
        int numeroObtenido = simonDiceTest.CantidadDeJuegos;
        int numeroEsperado = 2;

        Assert.Equal(numeroEsperado, numeroObtenido);
    }


}
