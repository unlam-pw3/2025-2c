using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE4_POO_Entidades
{
    public class Pato : Animal
    {
        public Pato(string nombre) : base(nombre)
        {
        }

        public override string HacerSonido()
        {
            return "Cuac Cuac";
        }

        public override int ObtenerCantidadDePatas()
        {
            return base.setCantidadDePatas("bipedo");
        }
    }
}
