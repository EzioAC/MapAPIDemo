using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapAPIDemo.Models.SceneryDetail;

namespace MapAPIDemo.Tools
{
    public class GetSceneryDetail
    {
        public static SceneryDetail GetDetail(string sid)
        {
            string url = @"http://apis.haoservice.com/lifeservice/travel/GetScenery?key+" + AK.ak2;
            string json = HttpGetString.HttpGet(url + "&sid=" + sid);
            var detail = SceneryDetail.FromJson(json);
            return detail;
        }

        
    }
}
