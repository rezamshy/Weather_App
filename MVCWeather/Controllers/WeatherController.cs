using Microsoft.AspNetCore.Mvc;
using MVCWeather.Models;

namespace MVCWeather.Controllers;

public class WeatherController : Controller
{
    public IActionResult Index()
    {
        Weather weather = new Weather(1, "Edmonton", 23);
        return View(weather);
    }
}
