using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using admin_edoctor.Models;

namespace admin_edoctor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.ShowSlider = true;
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.ShowSlider = false;
        return View();
    }
    
    public IActionResult About()
    {
        ViewBag.ShowSlider = false;
        return View();
    }
    
    public IActionResult Testimonial()
    {
        ViewBag.ShowSlider = false;
        return View();
    }
    
    public IActionResult Product()
    {
        ViewBag.ShowSlider = false;
        return View();
    }
    
    public IActionResult Blog_list()
    {
        ViewBag.ShowSlider = false;
        return View();
    }
    
    public IActionResult Contact()
    {
        ViewBag.ShowSlider = false;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}