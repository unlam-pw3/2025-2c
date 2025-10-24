namespace Clase3_Entidades
{
    public class Herramienta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadEnStock { get; set; }
        public string Imagen { get; set; }

        public Herramienta(int id, string nombre, decimal precio, int cantidadEnStock, string imagen)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            CantidadEnStock = cantidadEnStock;
            Imagen = imagen;
        }

        public Herramienta()
        {
        }
    }
}
