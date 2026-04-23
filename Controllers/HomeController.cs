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
        ViewBag.Grupo = new grupo(); 
        return View();
    }
    
    public IActionResult SelectIntegrante(int dni)
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult selectIntegrante(int dni)
    {
        // Inicializar grupo (carga datos manuales) y obtener el diccionario
        grupo g = new grupo();
        var integrantes = g.devolverIntegrantes();

        // Buscar el integrante por DNI
        Integrante integrante = null;
        if (integrantes != null && integrantes.ContainsKey(dni))
        {
            integrante = integrantes[dni];
        }

        // Cargar en ViewBag: la información del integrante y el DNI buscado
        ViewBag.Integrante = integrante;
        ViewBag.DNI = dni;

        // Retornar la vista infoIntegrante
        return View("infoIntegrante");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
