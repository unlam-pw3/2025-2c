namespace Clase1.Tarea.Logica
{
   public class JuegoService : IJuegoService
   {
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

      public string DistanciaEntreNumeroIngresadoYNumeroSecreto(int numeroIngresado)
      {
         int diferencia = Math.Abs(_numeroSecreto - numeroIngresado);
         if (diferencia > 30)
         {
            return "Frío";
         }
         else if (diferencia >= 16 && diferencia <= 30)
         {
            return "Tibio";
         }
         else if (diferencia >= 6 && diferencia <= 15)
         {
            return "Caliente";
         }
         else
         {
            return "Muy caliente";
         }
      }
   }
}
