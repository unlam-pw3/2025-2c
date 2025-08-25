using System.Drawing;

namespace AdivinarNumero.Logica;

public class JuegoAdivinarNumero
{
   private int numero;
        private Random random;

        public JuegoAdivinarNumero()
        {
            random = new Random();
            numeroSecreto = random.Next(1, 101);
        }

        public JuegoAdivinarNumero(int numero)
        {
            numeroSecreto = numero;
        }

        public int ObtenerNumeroSecreto()
        {
            return numeroSecreto;
        }

        public string EvaluarIntento(int intento)
        {
            if (intento == numeroSecreto)
                return "¡Correcto!";

            int diferencia = Math.Abs(numeroSecreto - intento);

            if (diferencia > 30)
                return "Frío";
            if (diferencia >= 16 && diferencia <= 30)
                return "Tibio";
            if (diferencia >= 6 && diferencia <= 15)
                return "Caliente";
            
            return "Muy caliente";
        }
}
