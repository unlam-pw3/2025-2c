namespace CLASE4_POO_Entidades
{
    public abstract class Animal
    {
        public string Nombre { get; set; }

        internal int setCantidadDePatas(string Tipo)
        { 
            //usar swith para la variable tipo
            switch (Tipo.ToLower())
            {
                case "cuadrupedo":
                    return 4;
                case "bipedo":
                    return 2;
                default:
                    return -1; // Desconocido
            }
        }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public abstract string HacerSonido();
        public abstract int ObtenerCantidadDePatas();

    }
}
