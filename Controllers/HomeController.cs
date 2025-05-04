using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03PitaYKampel.Models;

namespace TP03PitaYKampel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
    {
        Discos.InicializarDiscos();
        ViewBag.discos = Discos.devolverDiccionario();
        return View();
    }
    public IActionResult SelectDisco(int id)
    {
        ViewBag.discos = Discos.devolverDiccionario();
        if (ViewBag.discos.ContainsKey(id))
        {
            ViewBag.infoDisco = Discos.devolverDiccionario()[id];
            ViewBag.ID = id;
        }
        else
        {
            ViewBag.Error = "Error, el disco no existe";
        }

        return View("infoDisco");
    }
    public IActionResult MostarArtista(int dni)
    {
        ViewBag.Disco = Discos.devolverDiccionario();
        if (ViewBag.Disco.ContainsKey(dni))
        {
            ViewBag.infoArtista = Discos.devolverDiccionario()[dni].artista;
            ViewBag.DNI = dni;
        }
        else
        {
            ViewBag.Error = "Error, el artista no existe";
        }

        return View("infoArtista");
    }
    public IActionResult MostrarProductor(int dni)
    {
        ViewBag.Disco = Discos.devolverDiccionario();
        if (ViewBag.integrantes.ContainsKey(dni))
        {
            ViewBag.infoProductor = Discos.devolverDiccionario()[dni].productor;
            ViewBag.DNI = dni;
        }
        else
        {
            ViewBag.Error = "Error, el productor no existe";
        }

        return View("infoProductor");
    }
    
}
