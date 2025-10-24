using Clase2._202025.Entidad;

namespace Clase2._2C2025.Logica
{

    public interface IReseñaServicio
    {
        void AgregarReseña(Reseña reseña);
        List<Reseña> ObtenerReseñas();
    }


    public class ReseñaServicio: IReseñaServicio
    {
        private List<Reseña> _listReseñas;

        public ReseñaServicio()
        {
            _listReseñas = new List<Reseña>();
        }
        public void AgregarReseña(Reseña reseña)
        {
            _listReseñas.Add(reseña);
        }
        public List<Reseña> ObtenerReseñas()
        {
            return _listReseñas;
        }

    }
}
