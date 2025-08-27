namespace Clase1.Tarea.Logica
{
   public class JuegoService : IJuegoService
   {
      private const int LIMITE_MUY_CALIENTE = 5;
      private const int LIMITE_CALIENTE = 15;
      private const int LIMITE_TIBIO = 30;

      private int _cantidadIntentos = 0;
      private readonly int _numeroSecreto;
      private readonly int _rangoMinimo = 1;
      private readonly int _rangoMaximo = 100;


      public int CantidadIntentos => _cantidadIntentos;


      public JuegoService(int numeroSecreto)
      {
         this._numeroSecreto = numeroSecreto;
      }


      public bool EvaluarRangoPermitido(int numero)
      {
         return numero >= _rangoMinimo && numero <= _rangoMaximo;
      }
      public void IncrementarIntentos()
      {
         _cantidadIntentos++;
      }

      public string VerificarNumeroIngresado(int numero)
      {
         if (numero != _numeroSecreto)
         {
            return DistanciaEntreNumeroIngresadoYNumeroSecreto(numero);
         }
         else
         {
            return "GANASTE!";
         }

      }

      private string DistanciaEntreNumeroIngresadoYNumeroSecreto(int numeroIngresado)
      {

         //la diferencia siempre va a ser positiva con el valor absoluto
         int diferencia = Math.Abs(_numeroSecreto - numeroIngresado);

         if (diferencia <= LIMITE_MUY_CALIENTE)
         {
            return "Muy caliente";
         }
         else if (diferencia <= LIMITE_CALIENTE)
         {
            return "Caliente";
         }
         else if (diferencia <= LIMITE_TIBIO)
         {
            return "Tibio";
         }
         else
         {
            return "Frío";
         }
      }
   }
}
