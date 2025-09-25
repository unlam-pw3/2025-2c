using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE4_POO_Entidades
{
    public class Vaca : Animal
    {
        public Vaca(string nombre) : base(nombre)
        {
        }
    
        public override string HacerSonido()
        {
            return "Muuuuuu";
        }

        public override int ObtenerCantidadDePatas()
        {
            return base.setCantidadDePatas("cuadrupedo");
        }
    }
   
}
