using Clase1.Logica;

namespace Clase1.Tests
{
    public class JuegoAdivinarNumeroTest
    {
        [Fact]
        public void IniciarJuegoConUnNumeroValidoEntre1y100()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();

            // Act
            juego.IniciarJuego();
            int numero = juego.Intentos;

            // Assert
            Assert.InRange(juego.NumeroObjetivo, 1, 100);
        }


        [Fact]
        public void SiIngresoElNumeroCorrectoDebeDevolverElMensajeCorrecto()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            string resultado = juego.EvaluarIntento(50);

            // Assert
            Assert.Equal("Correcto", resultado);
            Assert.Equal(1, juego.Intentos);// Verifica que el contador de intentos se incremento
        }

        [Fact]
        public void VerificaSiLosNumerosIngresadosEstanMuySercaDelNumeroDeberiaDevolverElMensajeMuyCaliente()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            string resultado1 = juego.EvaluarIntento(46);
            string resultado2 = juego.EvaluarIntento(55);

            // Assert
            Assert.Equal("Muy caliente", resultado1);
            Assert.Equal("Muy caliente", resultado2);
            Assert.Equal(2, juego.Intentos);// Verifica que el contador de intentos se incremento
        }

        [Fact]
        public void VerificaSiLosNumerosIngresadosEstanMuySercaDelNumeroDeberiaDevolverElMensajeCalient()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            string resultado1 = juego.EvaluarIntento(44);
            string resultado2 = juego.EvaluarIntento(65);

            // Assert
            Assert.Equal("Caliente", resultado1);
            Assert.Equal("Caliente", resultado2);
            Assert.Equal(2, juego.Intentos);// Verifica que el contador de intentos se incremento
        }

        [Fact]
        public void VerificaSiLosNumerosIngresadosEstanMuySercaDelNumeroDeberiaDevolverElMensajeTibio()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            string resultado1 = juego.EvaluarIntento(20);
            string resultado2 = juego.EvaluarIntento(70);

            // Assert
            Assert.Equal("Tibio", resultado1);
            Assert.Equal("Tibio", resultado2);
            Assert.Equal(2, juego.Intentos);// Verifica que el contador de intentos se incremento
        }

        [Fact]
        public void VerificaSiLosNumerosIngresadosEstanMuySercaDelNumeroDeberiaDevolverElMensajeFrio()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            string resultado1 = juego.EvaluarIntento(5);
            string resultado2 = juego.EvaluarIntento(95);

            // Assert
            Assert.Equal("Frio", resultado1);
            Assert.Equal("Frio", resultado2);
            Assert.Equal(2, juego.Intentos);
        }

        [Fact]
        public void VerificaQueSiLosNumerosEstanFueraDelRangoDel1Al100MuestreMensajeDeNumeroInvalido()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();

            // Act
            string resultado1 = juego.EvaluarIntento(0);
            string resultado2 = juego.EvaluarIntento(-10);
            string resultado3 = juego.EvaluarIntento(101);

            // Assert
            Assert.Equal("Número inválido, debe estar entre 1 y 100", resultado1);
            Assert.Equal("Número inválido, debe estar entre 1 y 100", resultado2);
            Assert.Equal("Número inválido, debe estar entre 1 y 100", resultado3);
            Assert.Equal(0, juego.Intentos);
        }

        [Fact]
        public void VerificaQueSeSumenLosIntentosPorCadaNumeroValidoIngresado()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            juego.EvaluarIntento(40);
            juego.EvaluarIntento(55);

            // Assert
            Assert.Equal(2, juego.Intentos);
        }

        [Fact]
        public void VerificaQueNoSeSumenLosIntentosPorCadaNumeroValidoIngresado()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            juego.EvaluarIntento(0);
            juego.EvaluarIntento(101);

            // Assert
            Assert.Equal(0, juego.Intentos);
        }

        [Fact]
        public void VerificaQueSeSumenLosIntentosPorCadaNumeroValidoIngresadoYNoSumeLosInvalidos()
        {
            // Arrange
            var juego = new JuegoAdivinarNumero();
            juego.IniciarJuego();
            juego.SetNumeroObjetivo(50);

            // Act
            juego.EvaluarIntento(-10);
            juego.EvaluarIntento(55);

            // Assert
            Assert.Equal(1, juego.Intentos);
        }

    }
}
