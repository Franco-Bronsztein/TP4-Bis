using Microsoft.AspNetCore.Mvc;

namespace TP4BIS.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        return View("Index");
    }

    public IActionResult DetallePais(string Pais)
    {
        ViewBag.PaisBuscado = Info.DetallePais(Pais);
        return View("DetallePais");
    }
}
