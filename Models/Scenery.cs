using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapAPIDemo.Models.Place
{
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using Place;
    //
    //    var data = Scenery.FromJson(jsonString);
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class Scenery
    {
        [JsonProperty("error_code")]
        public long ErrorCode { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("result")]
        public Result[] Result { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("price_min")]
        public string PriceMin { get; set; }

        [JsonProperty("comm_cnt")]
        public object CommCnt { get; set; }

        [JsonProperty("cityId")]
        public string CityId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("imgurl")]
        public string Imgurl { get; set; }
    }

    public partial class Scenery
    {
        public static Scenery FromJson(string json) => JsonConvert.DeserializeObject<Scenery>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Scenery self) => JsonConvert.SerializeObject(self, Converter.Settings);
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

