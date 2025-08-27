
namespace TareaClase1.Logica
{
    public class AdivinarNumero
    {
        private int _numeroAAdivinar;
        private bool _juegoFinalizo;

        public AdivinarNumero()
        {
            this._numeroAAdivinar = new Random().Next(1, 100);
            this._juegoFinalizo = false;
        }

        public AdivinarNumero(int numeroAAdivinar)
        {
            this._numeroAAdivinar = numeroAAdivinar;
            this._juegoFinalizo = false;
        }

        public Cercania IntentoAdivinarNumero(int intentoDeAdivinarNumero)
        {
            int diferencia = _numeroAAdivinar- intentoDeAdivinarNumero;

            if (diferencia == 0) _juegoFinalizo = true;

            if (diferencia > 30) return Cercania.Frio;
            if (diferencia >= 16) return Cercania.Tibio;
            if (diferencia >= 6) return Cercania.Caliente;
            return Cercania.MuyCaliente;
        }

        public bool JuegoFinalizo()
        {
            return _juegoFinalizo;
        }

        public int ObtenerNumeroAAdivinar()
        {
            return _numeroAAdivinar; 
        }

    }
}