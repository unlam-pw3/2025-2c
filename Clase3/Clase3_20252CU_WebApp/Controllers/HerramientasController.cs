using Clase3_Entidades;
using Clase3_Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3_20252CU_WebApp.Controllers
{
    public class HerramientasController : Controller
    {
        private IHerramientaServicio _herramientaServicio;

        public HerramientasController(IHerramientaServicio herramientaServicio)
        {
            _herramientaServicio = herramientaServicio;
        }
        public IActionResult Index()
        {
            return View(_herramientaServicio.ObtenerHerramientas());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Herramienta herramienta)
        {
            _herramientaServicio.AgregarHerramienta(herramienta);
            return RedirectToAction("Index");
        }
    }
}
