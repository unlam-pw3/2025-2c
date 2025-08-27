using TareaClase1.Logica;

namespace TareaClase1.Test
{
    public class JuegoAdivinarNumeroTest
    {
  
        [Fact]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoLePidoElNumeroAAdivinarEntoncesObtengoUnNumeroAleatorioEntre1y100()
        {

            // Preparacion

            AdivinarNumero juego = new AdivinarNumero();

            // Ejecucion

            int numeroObtenido = juego.ObtenerNumeroAAdivinar();

            // Validacion

            Assert.InRange(numeroObtenido, 1, 100);
        }

        [Fact]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoIntentoAdivinarElNumeroObtengoUnaCercaniaComoValorDeRetorno()
        {

            // Preparacion

            AdivinarNumero juego = new AdivinarNumero();
            int intentoDeAdivinarNumero = new Random().Next(1, 100);

            // Ejecucion

            var valorRetorno = juego.IntentoAdivinarNumero(intentoDeAdivinarNumero);

            // Validacion

            Assert.IsType<Cercania>(valorRetorno);

        }

        [Theory]
        [InlineData(1,100)]
        [InlineData(1,32)]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoElNumeroDeIntentoTieneUnaDiferenciaMayorA30ConElNumeroAAdivinarEntoncesObtengoElValorDeCercaniaFrio(int intento, int numeroAAdivinar)
        {
            // Preparacion

            AdivinarNumero juego = new AdivinarNumero(numeroAAdivinar);

            // Ejecucion

            Cercania cercaniaObtenida = juego.IntentoAdivinarNumero(intento);

            // Validacion

            Assert.Equal(Cercania.Frio, cercaniaObtenida);
        }


        [Theory]
        [InlineData(70, 100)]
        [InlineData(1, 17)]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoElNumeroDeIntentoTieneUnaDiferenciaEntre17y30ConElNumeroAAdivinarEntoncesObtengoElValorDeCercaniaTibio(int intento, int numeroAAdivinar)
        {
            // Preparacion

            AdivinarNumero juego = new AdivinarNumero(numeroAAdivinar);

            // Ejecucion

            Cercania cercaniaObtenida = juego.IntentoAdivinarNumero(intento);

            // Validacion

            Assert.Equal(Cercania.Tibio, cercaniaObtenida);
        }

        [Theory]
        [InlineData(94, 100)]
        [InlineData(1, 16)]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoElNumeroDeIntentoTieneUnaDiferenciaEntre6y15ConElNumeroAAdivinarEntoncesObtengoElValorDeCercaniaCaliente(int intento, int numeroAAdivinar)
        {
            // Preparacion

            AdivinarNumero juego = new AdivinarNumero(numeroAAdivinar);

            // Ejecucion

            Cercania cercaniaObtenida = juego.IntentoAdivinarNumero(intento);

            // Validacion

            Assert.Equal(Cercania.Caliente, cercaniaObtenida);
        }

        [Theory]
        [InlineData(95, 100)]
        [InlineData(1, 2)]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoElNumeroDeIntentoTieneUnaDiferenciaMenorA5ConElNumeroAAdivinarEntoncesObtengoElValorDeCercaniaMuyCaliente(int intento, int numeroAAdivinar)
        {
            // Preparacion

            AdivinarNumero juego = new AdivinarNumero(numeroAAdivinar);

            // Ejecucion

            Cercania cercaniaObtenida = juego.IntentoAdivinarNumero(intento);

            // Validacion

            Assert.Equal(Cercania.MuyCaliente, cercaniaObtenida);
        }

        [Fact]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoAdivinoElNumeroEntoncesElJuegoFinaliza()
        {

            // Preparacion

            AdivinarNumero juego = new AdivinarNumero(1);
            juego.IntentoAdivinarNumero(1);

            // Ejecucion

            bool juegoFinalizadoObtenido = juego.JuegoFinalizo();

            // Validacion

            Assert.True(juegoFinalizadoObtenido);

        }

        [Fact]
        public void DadoQueExisteUnJuegoAdivinarNumeroCuandoNoAdivinoElNumeroEntoncesElJuegoNoFinaliza()
        {
            // Preparacion
            AdivinarNumero juego = new AdivinarNumero(50);
            juego.IntentoAdivinarNumero(25); // Intento incorrecto

            // Ejecucion
            bool juegoFinalizadoObtenido = juego.JuegoFinalizo();

            // Validacion
            Assert.False(juegoFinalizadoObtenido);
        }

    }
}