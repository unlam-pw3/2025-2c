using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Tarea.Logica
{
   internal interface IJuegoService
   {
      void IngresarNumero(int numero);
      void IncrementarIntentos();
      bool EvaluarRangoPermitido(int numero);
      string VerificarNumeroIngresado(int numero);
      string DistanciaEntreNumeroIngresadoYNumeroSecreto(int numeroIngresado);
   }
}
