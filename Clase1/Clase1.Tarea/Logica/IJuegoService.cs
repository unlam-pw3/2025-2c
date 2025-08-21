namespace Clase1.Tarea.Logica
{
   internal interface IJuegoService
   {
      int CantidadIntentos { get; }
      void IncrementarIntentos();
      bool EvaluarRangoPermitido(int numero);
      string VerificarNumeroIngresado(int numero);
      string DistanciaEntreNumeroIngresadoYNumeroSecreto(int numeroIngresado);
   }
}

