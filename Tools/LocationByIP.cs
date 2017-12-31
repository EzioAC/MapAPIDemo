using MapAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MapAPIDemo.Tools;
using MapAPIDemo.Models.Location;

namespace MapAPIDemo.Tools
{
    public class LocationByIP
    {
        public static Location GetLocation(string ip)
        {
            string url = "http://api.map.baidu.com/location/ip?coor=bd09ll&ak=" + AK.ak+"&ip="+ip;
            string json = HttpGetString.HttpGet(url);
            return Location.FromJson(json);
        }
    }
}
