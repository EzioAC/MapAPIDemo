using MapAPIDemo.Models;
using MapAPIDemo.Models.Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MapAPIDemo.Tools
{
    public class CodeFinder
    {
        public static Dictionary<string,Code> dic= null;
        public static Code GetCityID(string cityname)
        {
            if (dic==null)
            {
                string json = File.ReadAllText(@"JsonData/Code.json",System.Text.Encoding.Default);
                var code = Code.FromJson(json);
                dic = new Dictionary<string, Code>();
                foreach (var c in code)
                {
                    if (!dic.ContainsKey(c.CityName))
                        dic[c.CityName] = c;
                }
            }
            cityname = cityname.Replace("市", "");
            if (!dic.ContainsKey(cityname))
            {
                return null;
            }
            return dic[cityname];
        }
    }
}
