using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Logica
{
    public class JuegoAdivinarNumero
    {


        public int IniciarJuego()
        {
            Random rand = new Random();
            int numeroSecreto = rand.Next(1, 101); // Numero aleatorio entre 1 y 100
            return numeroSecreto;

        }
        public int CalcularDiferencia(int numeroIngresado, int numeroAleatorio)
        {
            int diferencia = Math.Abs(numeroIngresado - numeroAleatorio);

            return diferencia;
        }

        public string ObtenerResultado(int diferencia)
        {
            if (diferencia == 0)
            {
                return "¡Felicidades! Has adivinado el numero.";
            }
            else if (diferencia <= 5)
            {
                return "Muy caliente";
            }
            else if (diferencia >= 6 && diferencia <= 15)
            {
                return "Caliente";
            }
            else if (diferencia >= 16 && diferencia <= 30)
            {
                return "Tibio";
            }
            else if (diferencia >= 31)
            {
                return "Frio";
            }
            return "El numero ingresado no esta entre 1 y 100, intente nuevamente.";
        }

        public bool JuegoTerminado()
        {
            return true;
        }
    }
}
