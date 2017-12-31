using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapAPIDemo.Models.Weather
{
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using QuiS;
    //
    //    var data = Weather.FromJson(jsonString);

    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class Weather
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("shidu")]
        public string Shidu { get; set; }

        [JsonProperty("pm25")]
        public long Pm25 { get; set; }

        [JsonProperty("pm10")]
        public long Pm10 { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("wendu")]
        public string Wendu { get; set; }

        [JsonProperty("ganmao")]
        public string Ganmao { get; set; }

        [JsonProperty("yesterday")]
        public Forecast Yesterday { get; set; }

        [JsonProperty("forecast")]
        public Forecast[] Forecast { get; set; }
    }

    public partial class Forecast
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("high")]
        public string High { get; set; }

        [JsonProperty("low")]
        public string Low { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("aqi")]
        public long Aqi { get; set; }

        [JsonProperty("fx")]
        public string Fx { get; set; }

        [JsonProperty("fl")]
        public string Fl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }
    }

    public partial class Weather
    {
        public static Weather FromJson(string json) => JsonConvert.DeserializeObject<Weather>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Weather self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }


}
