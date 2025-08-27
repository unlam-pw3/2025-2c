using Clase1.Logica;

namespace Clase1.Tests;

public class JuegoAhorcadoTest
{
    [Fact]
    public void ElegirPalabra_NoSeaNullNiEmpty()
    {
        // Arrange
        var juego = new JuegoAhorcado();

        // Act
        juego.ElegirPalabra();

        // Assert
        Assert.NotNull(juego.ObtenerPalabraOculta());
        Assert.NotEmpty(juego.ObtenerPalabraOculta());
    }

    [Theory]
    [InlineData("test")]
    [InlineData("programacion")]
    [InlineData("prueba")]
    [InlineData("aaaaa")]
    public void AdivinarLetra_Correcta_DeberiaActualizarPalabraOculta(string palabraAAdivinar)
    {
        // Arrange
        var juego = new JuegoAhorcado();
        juego.ElegirPalabra(palabraAAdivinar);
        char letra = palabraAAdivinar.First(); // Tomamos la primera letra de la palabra oculta

        // Act
        bool resultado = juego.AdivinarLetra(letra);

        // Assert
        Assert.True(resultado);
        Assert.Contains(letra, juego.ObtenerPalabraOculta().Replace(" ", "")); // Verifica que la letra se haya añadido a la palabra oculta
    }

    [Fact]
    public void AdivinarLetra_Incorrecta_DeberiaIncrementarFallos()
    {
        // Arrange
        var juego = new JuegoAhorcado();
        juego.ElegirPalabra("test");
        char letraIncorrecta = 'x'; // Letra que no está en la palabra

        // Act
        bool resultado = juego.AdivinarLetra(letraIncorrecta);

        // Assert
        Assert.False(resultado);
        Assert.Equal(1, juego.ObtenerFallos()); // Verifica que los fallos se hayan incrementado
    }

    [Fact]
    public void JuegoTerminado_DeberiaSerTrue_CuandoSeAlcanzaElLimiteDeFallos()
    {
        // Arrange
        var juego = new JuegoAhorcado();
        juego.ElegirPalabra("test");
        // Simulamos 6 fallos
        for (int i = 0; i < 6; i++)
        {
            juego.AdivinarLetra('x'); // Letra incorrecta
        }
        // Act
        bool terminado = juego.JuegoTerminado();
        // Assert
        Assert.True(terminado); // El juego debería estar terminado al alcanzar el límite de fallos
    }
}