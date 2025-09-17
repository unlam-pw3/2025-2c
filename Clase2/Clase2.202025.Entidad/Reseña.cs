namespace Clase2._202025.Entidad
{
    public class Reseña
    {
        public string Fecha { get; set; }
        public string Direccion { get; set; }
        public string TipoLocal { get; set; }
        public string Puntuacion { get; set; }

        public Reseña(string fecha, string direccion, string tipoLocal, string puntuacion)
        {
            Fecha = fecha;
            Direccion = direccion;
            TipoLocal = tipoLocal;
            Puntuacion = puntuacion;
        }

    }
}
