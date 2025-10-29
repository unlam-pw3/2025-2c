using Clase6.EF_BusquedaTesoro.Logica;
using Clase6.EF_BusquedaTesoro.Data.Entidades;

using Microsoft.AspNetCore.Mvc;

namespace Clase6.EF_BusquedaTesoro.Web.Controllers
{
    public class CazatesorosController : Controller
    {

        private ICazatesorosLogica _cazatezorosLogica;

        public CazatesorosController(ICazatesorosLogica cazatesorosLogica)
        {
            _cazatezorosLogica = cazatesorosLogica;
        }

        public IActionResult Lista()
        {
            return View(_cazatezorosLogica.ObtenerCazatesoros());
        }

        public IActionResult Agregar() {
            return View(new Cazatesoro());
        }


        [HttpPost]
        public IActionResult Agregar(Cazatesoro cazatesoro)
        {
            if (!ModelState.IsValid)
                return View(cazatesoro);
            _cazatezorosLogica.AgregarCazatesoro(cazatesoro);
            return RedirectToAction("Lista");
        }


        public IActionResult Eliminar(int id)
        {
            _cazatezorosLogica.EliminarCazatesoro(id);
            return RedirectToAction("Lista");
        }


        //Editar
        public IActionResult Editar(int id)
        {
            var cazatesoro = _cazatezorosLogica.ObtenerCazatesoroPorId(id);
            if (cazatesoro == null)
                return NotFound();
            return View(cazatesoro);
        }

        [HttpPost]
        public IActionResult Editar(Cazatesoro cazatesoro)
        {
            if (!ModelState.IsValid)
                return View(cazatesoro);
            _cazatezorosLogica.ActualizarCazatesoro(cazatesoro);
            return RedirectToAction("Lista");
        }
    }
}
