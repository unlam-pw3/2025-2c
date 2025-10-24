namespace Clase1.Tarea.Logica
{
   public interface IJuegoService
   {
      int CantidadIntentos { get; }
      void IncrementarIntentos();
      bool EvaluarRangoPermitido(int numero);
      string VerificarNumeroIngresado(int numero);
      
   }
}

