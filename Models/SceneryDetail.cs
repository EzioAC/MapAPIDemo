// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MapAPIDemo.Models.SceneryDetail;
//
//    var data = SceneryDetail.FromJson(jsonString);

namespace MapAPIDemo.Models.SceneryDetail
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class SceneryDetail
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

        [JsonProperty("referral")]
        public string Referral { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }
    }

    public partial class SceneryDetail
    {
        public static SceneryDetail FromJson(string json) => JsonConvert.DeserializeObject<SceneryDetail>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SceneryDetail self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
