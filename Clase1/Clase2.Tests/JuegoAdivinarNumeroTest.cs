using Clase2_Logica;


namespace Clase2.Tests
{
    public class JuegoAdivinarNumeroTest
    {
        [Fact]
        public void ElegirUnNumero_NoSeaCero()
        {
            //Arrange
            var juego = new JuegoAdivinarNumero();
            //Act
            juego.ElegirNumero();
            // Assert
            Assert.NotEqual(0, juego.ObtenerNumero());
        }


        [Fact]
        public void EvaluarIntento_DeberiaRetornarFrio()
        {
            var juego = new JuegoAdivinarNumero();
            juego.ElegirNumero();

            int numeroForzado = juego.ObtenerNumero() + 31; //Mayor a 30 es frio
            if (numeroForzado > 100) numeroForzado = juego.ObtenerNumero() - 31;

            var resultado = juego.EvaluarIntento(numeroForzado);

            Assert.Equal("Frío", resultado);
        }

        [Fact]
        public void EvaluarIntento_DeberiaRetornarTibio()
        {
            var juego = new JuegoAdivinarNumero();
            juego.ElegirNumero();

           
            int numeroForzado = juego.ObtenerNumero() + 20; //Entre 16 y 30 es tibio
            if (numeroForzado > 100) numeroForzado = juego.ObtenerNumero() - 20;

            var resultado = juego.EvaluarIntento(numeroForzado);

            Assert.Equal("Tibio", resultado);
        }

        [Fact]
        public void EvaluarIntento_DeberiaRetornarCaliente()
        {
            var juego = new JuegoAdivinarNumero();
            juego.ElegirNumero();

            int numeroForzado = juego.ObtenerNumero() + 10; //Entre 6 y 15 es caliente
            if (numeroForzado > 100) numeroForzado = juego.ObtenerNumero() - 10;

            var resultado = juego.EvaluarIntento(numeroForzado);

            Assert.Equal("Caliente", resultado);
        }

        [Fact]
        public void EvaluarIntento_DeberiaRetornarMuyCaliente()
        {
            var juego = new JuegoAdivinarNumero();
            juego.ElegirNumero();


            int numeroForzado = juego.ObtenerNumero() + 3; //5 o menos es muy caliente
            if (numeroForzado > 100) numeroForzado = juego.ObtenerNumero() - 3;

            var resultado = juego.EvaluarIntento(numeroForzado);

            Assert.Equal("Muy caliente", resultado);
        }

        [Fact]
        public void EvaluarIntento_DeberiaRetornarCorrecto()
        {
            var juego = new JuegoAdivinarNumero();
            juego.ElegirNumero();
            int numeroForzado = juego.ObtenerNumero(); //El mismo numero es correcto
            var resultado = juego.EvaluarIntento(numeroForzado);
            Assert.True(juego.JuegoTerminado());
    
        }

    }
}
