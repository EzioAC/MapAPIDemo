using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MapAPIDemo.Models.Location
{
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using location;
    //
    //    var data = Location.FromJson(jsonString);
    public partial class Location
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }
    }

    public partial class Content
    {
        [JsonProperty("address_detail")]
        public AddressDetail AddressDetail { get; set; }

        [JsonProperty("point")]
        public Point Point { get; set; }
    }

    public partial class Point
    {
        [JsonProperty("x")]
        public string X { get; set; }

        [JsonProperty("y")]
        public string Y { get; set; }
    }

    public partial class AddressDetail
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_code")]
        public long CityCode { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("street_number")]
        public string StreetNumber { get; set; }
    }

    public partial class Location
    {
        public static Location FromJson(string json) => JsonConvert.DeserializeObject<Location>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Location self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
