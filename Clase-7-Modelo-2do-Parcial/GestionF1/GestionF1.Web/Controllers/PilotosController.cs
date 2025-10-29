using GestionF1.Logica;
using Microsoft.AspNetCore.Mvc;

namespace GestionF1.Web.Controllers
{
    public class PilotosController : Controller
    {
        private readonly IPilotoLogica _pilotoLogica;
        public PilotosController(IPilotoLogica pilotoLogica)
        {
            _pilotoLogica = pilotoLogica;
        }
        public IActionResult Index()
        {
            return View(_pilotoLogica.ObtnenerTodosLosPilotos());
        }

        //Agregar Piloto
        [HttpGet]
        public IActionResult AgregarPiloto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarPiloto(Data.Entidades.Piloto piloto)
        {
            if (ModelState.IsValid)
            {
                _pilotoLogica.AgregarPiloto(piloto);
                return RedirectToAction("Index");
            }
            return View(piloto);
        }

    }
}
