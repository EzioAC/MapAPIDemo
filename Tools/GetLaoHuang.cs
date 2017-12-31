using MapAPIDemo.Models.LaoHuangLi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapAPIDemo.Tools
{
    public class GetLaoHuang
    {
        private static readonly string url = "http://www.sojson.com/open/api/lunar/json.shtml";
        public static LaoHuangLi GetLaoHuangLi()
        {
            var json = HttpGetString.HttpGet(url);
            return LaoHuangLi.FromJson(json);
        }
    }
}
