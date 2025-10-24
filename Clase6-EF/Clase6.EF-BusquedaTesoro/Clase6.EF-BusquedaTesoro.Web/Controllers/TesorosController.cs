using Clase6.EF_BusquedaTesoro.Data.Entidades;
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

    public IActionResult Agregar()
    {
        return View(new Tesoro());
    }

    [HttpPost]
    public IActionResult Agregar(Tesoro tesoro)
    {
        if (!ModelState.IsValid)
            return View(tesoro);

        _tesorosLogica.AgregarTesoro(tesoro);

        return RedirectToAction("Lista");
    }
    public IActionResult Eliminar(int id)
    {
        _tesorosLogica.EliminarTesoro(id);
        return RedirectToAction("Lista");
    }

    // Editar
    public IActionResult Editar(int id)
    {
        var tesoro = _tesorosLogica.ObtenerTesoroPorId(id);
        if (tesoro == null)
            return NotFound();
        return View(tesoro);
    }

    [HttpPost]
    public IActionResult Editar(Tesoro tesoro)
    {
        if (!ModelState.IsValid)
            return View(tesoro);
        _tesorosLogica.ActualizarTesoro(tesoro);
        return RedirectToAction("Lista");
    }
}
