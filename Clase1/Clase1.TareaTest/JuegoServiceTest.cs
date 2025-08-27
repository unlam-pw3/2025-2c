using Clase1.Tarea.Logica;

namespace Clase1.TareaTest
{
   public class JuegoServiceTest
   {
      private const int NUMERO_A_ADIVINAR = 50;

      [Fact]
      public void DadoElServicioConNumeroAdivinar_DebeVerificarNumeroIngresadoYRetornarTibio()
      {
         IJuegoService juegoService = new JuegoService(NUMERO_A_ADIVINAR);

         string resultado = juegoService.VerificarNumeroIngresado(30);
         
         Assert.Equal("Tibio", resultado);
      }

      [Fact]
      public void DadoElServicioConNumeroAdivinar_DebeVerificarNumeroIngresadoYRetornarGanaste()
      {
         IJuegoService juegoService = new JuegoService(NUMERO_A_ADIVINAR);

         string resultado = juegoService.VerificarNumeroIngresado(50);
         
         Assert.Equal("GANASTE!", resultado);
      }

      [Fact]
      public void DadoElServicioConNumeroAdivinar_DebeVerificarNumeroIngresadoYRetornarFrio()
      {
         IJuegoService juegoService = new JuegoService(NUMERO_A_ADIVINAR);

         string resultado = juegoService.VerificarNumeroIngresado(19);
         
         Assert.Equal("Frío", resultado);
      }

      [Fact]
      public void DadoElServicioConNumeroAdivinar_DebeVerificarNumeroIngresadoYRetornarCaliente()
      {
         IJuegoService juegoService = new JuegoService(NUMERO_A_ADIVINAR);

         string resultado = juegoService.VerificarNumeroIngresado(44);
         
         Assert.Equal("Caliente", resultado);
      }

      [Fact]
      public void DadoElServicioConNumeroAdivinar_DebeVerificarNumeroIngresadoYRetornarMuyCaliente()
      {
         IJuegoService juegoService = new JuegoService(NUMERO_A_ADIVINAR);

         string resultado = juegoService.VerificarNumeroIngresado(46);
         
         Assert.Equal("Muy caliente", resultado);
      }
   }
}