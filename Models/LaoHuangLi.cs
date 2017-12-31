// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MapAPIDemo.Models.LaoHuangLi;
//
//    var data = LaoHuangLi.FromJson(jsonString);

namespace MapAPIDemo.Models.LaoHuangLi
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class LaoHuangLi
    {
        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("month")]
        public long Month { get; set; }

        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("lunarYear")]
        public long LunarYear { get; set; }

        [JsonProperty("lunarMonth")]
        public long LunarMonth { get; set; }

        [JsonProperty("lunarDay")]
        public long LunarDay { get; set; }

        [JsonProperty("cnyear")]
        public string Cnyear { get; set; }

        [JsonProperty("cnmonth")]
        public string Cnmonth { get; set; }

        [JsonProperty("cnday")]
        public string Cnday { get; set; }

        [JsonProperty("hyear")]
        public string Hyear { get; set; }

        [JsonProperty("cyclicalYear")]
        public string CyclicalYear { get; set; }

        [JsonProperty("cyclicalMonth")]
        public string CyclicalMonth { get; set; }

        [JsonProperty("cyclicalDay")]
        public string CyclicalDay { get; set; }

        [JsonProperty("suit")]
        public string Suit { get; set; }

        [JsonProperty("taboo")]
        public string Taboo { get; set; }

        [JsonProperty("animal")]
        public string Animal { get; set; }

        [JsonProperty("week")]
        public string Week { get; set; }

        [JsonProperty("festivalList")]
        public object[] FestivalList { get; set; }

        [JsonProperty("jieqi")]
        public Jieqi Jieqi { get; set; }

        [JsonProperty("maxDayInMonth")]
        public long MaxDayInMonth { get; set; }

        [JsonProperty("leap")]
        public bool Leap { get; set; }

        [JsonProperty("bigMonth")]
        public bool BigMonth { get; set; }

        [JsonProperty("lunarYearString")]
        public string LunarYearString { get; set; }
    }

    public partial class Jieqi
    {
        [JsonProperty("4")]
        public string The4 { get; set; }

        [JsonProperty("19")]
        public string The19 { get; set; }
    }

    public partial class LaoHuangLi
    {
        public static LaoHuangLi FromJson(string json) => JsonConvert.DeserializeObject<LaoHuangLi>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LaoHuangLi self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
