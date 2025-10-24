using Clase6.EF_BusquedaTesoro.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.EF_BusquedaTesoro.Logica
{


    public interface ICazatesorosLogica
    {
        void AgregarCazatesoro(Cazatesoro cazatesoro);
        void EliminarCazatesoro(int idCazatesoro);
        List<Cazatesoro> ObtenerCazatesoros();
        Cazatesoro ObtenerCazatesoroPorId(int idCazatesoro);
        void ActualizarCazatesoro(Cazatesoro cazatesoro);


    }

    public class CazatesorosLogica : ICazatesorosLogica
    {

        private readonly Pw320252cBusquedaTesoroContext _context;
        public CazatesorosLogica(Pw320252cBusquedaTesoroContext context)
        {
            _context = context;
        }


        public void AgregarCazatesoro(Cazatesoro cazatesoro)
        {
          _context.Cazatesoros.Add(cazatesoro);
           _context.SaveChanges();
        }

        public void EliminarCazatesoro(int idCazatesoro)
        {
            var cazatesoro = _context.Cazatesoros.Find(idCazatesoro);
            if (cazatesoro != null)
            {
                _context.Cazatesoros.Remove(cazatesoro);
                _context.SaveChanges();
            }
        }
        public void ActualizarCazatesoro(Cazatesoro cazatesoro)
        {
            _context.Cazatesoros.Update(cazatesoro);
            _context.SaveChanges();
        }

        public Cazatesoro ObtenerCazatesoroPorId(int idCazatesoro)
        {
            return _context.Cazatesoros.Find(idCazatesoro);
        }

        public List<Cazatesoro> ObtenerCazatesoros()
        {
            return _context.Cazatesoros.ToList();
        }
    }
}
