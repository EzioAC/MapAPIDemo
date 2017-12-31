using MapAPIDemo.Models;
using MapAPIDemo.Models.Location;
using MapAPIDemo.Models.Weather;
using MapAPIDemo.Tools;
using Microsoft.AspNetCore.Mvc;

namespace MapAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult Index(string ip="")
        {
            var location = MapAPIDemo.Tools.LocationByIP.GetLocation(ip);
            Point point = location.Content.Point;
            Weather weather = WeatherByCity.GetWeather(location.Content.AddressDetail.City);
            var code = CodeFinder.GetCityID(location.Content.AddressDetail.City);
            var scenery = ScenerySearch.GetScenery(code.ProvinceId, code.CityId);
            ViewData["weather"] = weather;
            ViewData["code"] = code;
            ViewData["scenery"] = scenery;
            return View(point);
        }

        public IActionResult Map(string ip="")
        {
            var location = MapAPIDemo.Tools.LocationByIP.GetLocation(ip);
            return View(location);
        }

        public IActionResult Scene(string ip="")
        {
            var location = MapAPIDemo.Tools.LocationByIP.GetLocation(ip);
            Point point = location.Content.Point;
            Weather weather = WeatherByCity.GetWeather(location.Content.AddressDetail.City);
            var code = CodeFinder.GetCityID(location.Content.AddressDetail.City);
            var scenery = ScenerySearch.GetScenery(code.ProvinceId, code.CityId);
            var laohuang = GetLaoHuang.GetLaoHuangLi();
            ViewData["weather"] = weather;
            ViewData["code"] = code;
            ViewData["scenery"] = scenery;
            ViewData["laohuang"] = laohuang;
            return View(point);
        }
    }
}
