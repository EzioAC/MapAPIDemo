using MapAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapAPIDemo.Models.Weather;
namespace MapAPIDemo.Tools
{
    public class WeatherByCity
    {
        public static Weather GetWeather(string city)
        {
            string url = "http://www.sojson.com/open/api/weather/json.shtml?city="+city;
            var json = HttpGetString.HttpGet(url);
            return Weather.FromJson(json); 
        }

    }
}
