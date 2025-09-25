using Clase2._2C2025.Logica;
using Clase2._202025.Entidad;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2._2C2025.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ReseñasController : ControllerBase
    {
        IReseñaServicio _reseñaServicio;
        public ReseñasController(IReseñaServicio reseñaServicio)
        {
            _reseñaServicio = reseñaServicio;
        }
        
        [HttpGet]
        public IActionResult GetReseña()
        {
            return Ok(_reseñaServicio.ObtenerReseñas());
        }
        
        [HttpPost]
        public IActionResult PostReseña( [FromBody] Reseña reseña)
        {
            _reseñaServicio.AgregarReseña(reseña);
            return Ok();
        }

    }
}
