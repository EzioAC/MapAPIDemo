using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapAPIDemo.Models.Code
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class Code
    {
        [JsonProperty("cityId")]
        public string CityId { get; set; }

        [JsonProperty("cityName")]
        public string CityName { get; set; }

        [JsonProperty("provinceId")]
        public string ProvinceId { get; set; }
    }

    public partial class Code
    {
        public static Code[] FromJson(string json) => JsonConvert.DeserializeObject<Code[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Code[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
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

