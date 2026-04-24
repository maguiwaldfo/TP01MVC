using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01.Models;

namespace TP01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Grupo = new Grupo(); 
        return View();
    }
    
    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult SelectIntegrante(int dni)
    {
        Grupo g = new Grupo();
        Dictionary<int, Integrante> integrantes = g.devolverIntegrantes();
        Integrante integrante = null;
        if (integrantes != null && integrantes.ContainsKey(dni))
        {
            integrante = integrantes[dni];
        }
        ViewBag.Integrante = integrante;
        ViewBag.DNI = dni;

        return View("infointegrante");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
