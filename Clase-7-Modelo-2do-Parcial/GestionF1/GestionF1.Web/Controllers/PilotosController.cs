using GestionF1.Data.Entidades;
using GestionF1.Logica;
using GestionF1.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionF1.Web.Controllers
{
    public class PilotosController : Controller
    {
        private readonly IPilotoLogica _pilotoLogica;
        private readonly IEscuderiaLogica _escuderiaLogica;

        public PilotosController(IPilotoLogica pilotoLogica, IEscuderiaLogica escuderiaLogica)
        {
            _pilotoLogica = pilotoLogica;
            _escuderiaLogica = escuderiaLogica;
        }
        public IActionResult Index()
        {
            return View(_pilotoLogica.ObtnenerTodosLosPilotos());
        }

        //Agregar Piloto
        [HttpGet]
        public IActionResult AgregarPiloto()
        {
            var escuderias = _escuderiaLogica.ObtenerEscuderias();
            ViewBag.Escuderias = escuderias;

            return View();
        }

        [HttpPost]
        public IActionResult AgregarPiloto(PilotoViewModel piloto)
        {
            if (!ModelState.IsValid)
            {
                CargarDropdownEscuderias();
                return View(piloto);
            }

            var escuderia = _escuderiaLogica.ObtenerEscuderiaPorId(piloto.IdEscuderia);
            if (escuderia == null)
            {
                ModelState.AddModelError("IdEscuderia", "La escudería seleccionada no es válida.");
                
                CargarDropdownEscuderias();
                return View(piloto);
            }

            var pilotoEntidad = new Piloto
            {
                NombrePiloto = piloto.NombrePiloto,
                IdEscuderia = piloto.IdEscuderia,
                Eliminado = false
            };

            _pilotoLogica.AgregarPiloto(pilotoEntidad);
            return RedirectToAction("Index");
        }

        private void CargarDropdownEscuderias()
        {
            var escuderias = _escuderiaLogica.ObtenerEscuderias();
            ViewBag.Escuderias = escuderias;
        }

        //Eliminar Piloto
        public IActionResult EliminarPiloto(int id)
        {
            _pilotoLogica.EliminarPiloto(id);
            return RedirectToAction("Index");
        }

    }
}
