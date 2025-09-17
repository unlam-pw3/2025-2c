using CLASE4_POO_Entidades;
namespace CLASE4_POO_Servicio
{
    public interface IAnimalesServicio
    {
        List<Animal> ObtenerAnimales();
        void AgregarAnimal(Animal animal);
    }

    public class AnimalesServicio : IAnimalesServicio
    {
        private List<Animal> _animales;

        public AnimalesServicio()
        {
            _animales = new List<Animal>();
            // Agregar algunos animales de ejemplo
            _animales.Add(new Vaca("Lola"));
            _animales.Add(new Pato("Donald"));
            _animales.Add(new Vaca("Margarita"));
            _animales.Add(new Pato("Pato Lucas"));
        }
        public List<Animal> ObtenerAnimales()
        {
            return _animales;
        }
        public void AgregarAnimal(Animal animal)
        {
            _animales.Add(animal);
        }

    }
}
