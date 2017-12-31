using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapAPIDemo.Models.Place;
namespace MapAPIDemo.Tools
{
    public class ScenerySearch
    {
        private static string url = "http://apis.haoservice.com/lifeservice/travel/scenery?key=" + AK.ak2;
        public static Scenery[] GetScenery(string pid, string cid)        
        {
            List<Scenery> result = new List<Scenery>();
            for (int i = 0; i < 1; i++)
            {
                var json = HttpGetString.HttpGet(string.Format(url+"&pid={0}&cid={1}&page={2}",pid,cid,i.ToString()));
                var scenery = Scenery.FromJson(json);
                result.Add(scenery);
                if (scenery.Result.Length < 10)
                {
                    break;
                }
            }
            return result.ToArray();
        }
    }
}
