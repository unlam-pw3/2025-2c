using Clase3_Entidades;

namespace Clase3_Servicio
{

    public interface IHerramientaServicio
    {
        List<Herramienta> ObtenerHerramientas();
        Herramienta ObtenerHerramientaPorId(int id);
        void AgregarHerramienta(Herramienta herramienta);
    }

    public class HerramientaServicio : IHerramientaServicio
    {
        private static List<Herramienta> _herramientas { get; set; }
        private static int _nextId = 4;
        public HerramientaServicio()  
        {
            

            if (_herramientas == null)
            {
                _herramientas = new List<Herramienta> ();
                _herramientas.Add(new Herramienta(1, "Martillo", 1500, 10, "\\imagenes\\martillo.jpg"));
                _herramientas.Add(new Herramienta(2, "Destornillador", 800, 15, "\\imagenes\\destornillador.jpg"));
                _herramientas.Add(new Herramienta(3, "Taladro", 5000, 5, "\\imagenes\\taladro.jpg"));
            }
            
        }
        
        public List<Herramienta> ObtenerHerramientas()
        {
            return _herramientas;
        }
        public Herramienta ObtenerHerramientaPorId(int id)
        {
            return _herramientas.FirstOrDefault(h => h.Id == id);
        }
        public void AgregarHerramienta(Herramienta herramienta)
        {
            herramienta.Id = _nextId;

            if (string.IsNullOrEmpty(herramienta.Imagen))
                herramienta.Imagen = "\\imagenes\\sinimagen.jpg";
            else
                herramienta.Imagen = "\\imagenes\\" + herramienta.Imagen;

            _herramientas.Add(herramienta);

            _nextId = _nextId + 1;
        }
        public void EliminarHerramienta(int id)
        {
            var herramienta = ObtenerHerramientaPorId(id);
            if (herramienta != null)
            {
                _herramientas.Remove(herramienta);
            }
        }

    }
}
