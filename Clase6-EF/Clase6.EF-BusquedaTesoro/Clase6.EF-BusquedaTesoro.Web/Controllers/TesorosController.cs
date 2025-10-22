using Clase6.EF_BusquedaTesoro.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.EF_BusquedaTesoro.Web.Controllers;

public class TesorosController : Controller
{
    private ITesorosLogica _tesorosLogica;
    public TesorosController(ITesorosLogica tesorosLogica)
    {
        _tesorosLogica = tesorosLogica;
    }
    public IActionResult Lista()
    {
        return View(_tesorosLogica.ObtenerTesoros());
    }
}
