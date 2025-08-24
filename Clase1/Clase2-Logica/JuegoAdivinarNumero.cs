
namespace Clase2_Logica
{
    public class JuegoAdivinarNumero
    {

        private int numeroAdivinar;
        private int intento;
        private static Random rand = new Random();




        public void ElegirNumero()
        {
            numeroAdivinar = rand.Next(1, 101);
        }

        public int ObtenerNumero()
        {
            return numeroAdivinar;
        }

        public string EvaluarIntento(int intento)
        {
            this.intento = intento;
            if (intento == numeroAdivinar)
                return "¡Correcto!";

            int diferencia = Math.Abs(numeroAdivinar - intento);

            if (diferencia > 30) return "Frío";
            if (diferencia >= 16) return "Tibio";
            if (diferencia >= 6) return "Caliente";
            return "Muy caliente";
        }

        public bool JuegoTerminado()
        {
            return intento == numeroAdivinar;
        }
    }
}
