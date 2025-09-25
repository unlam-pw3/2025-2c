using Microsoft.AspNetCore.Mvc;
using CLASE4_POO_Servicio;

namespace CLASE4_POO_20252C_WebApp.Controllers
{
    public class AnimalesController : Controller
    {
        private IAnimalesServicio _animalesServicio;

        public AnimalesController(IAnimalesServicio animalesServicio)
        {
            _animalesServicio = animalesServicio;
        }

        public IActionResult Listar()
        {
            return View(_animalesServicio.ObtenerAnimales());
        }

        


    }
}
