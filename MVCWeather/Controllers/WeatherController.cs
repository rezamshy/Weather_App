using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCWeather.Models;

namespace MVCWeather.Controllers;

public class WeatherController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
