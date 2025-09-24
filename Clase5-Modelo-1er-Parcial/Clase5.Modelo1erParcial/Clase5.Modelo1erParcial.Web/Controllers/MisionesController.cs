using Clase5.Modelo1erParcial.Entidades;
using Clase5.Modelo1erParcial.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase5.Modelo1erParcial.Web.Controllers
{
    public class MisionesController : Controller
    {
        private readonly IMisionesSuperheroesLogica _misionesSuperheroesLogica;
        public MisionesController(IMisionesSuperheroesLogica misionesSuperheroesLogica)
        {
            _misionesSuperheroesLogica = misionesSuperheroesLogica;
        }

        [HttpGet]
        public IActionResult RegistrarMision()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarMision(Mision mision)
        {
            if (!ModelState.IsValid)
            {
                return View(mision);
            }

            _misionesSuperheroesLogica.AgregarMisionSuperheroe(mision);
            TempData["Mensaje"] = $"{mision.NombreSuperheroe} ({mision.IndiceEficiencia}).";
            return RedirectToAction("Resultados");
        }

        public IActionResult Resultados()
        {
            var misiones = _misionesSuperheroesLogica.ObtenerTodos();
            return View(misiones);
        }
    }
}
