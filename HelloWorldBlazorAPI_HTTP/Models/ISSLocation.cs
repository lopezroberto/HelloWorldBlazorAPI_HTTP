using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldBlazorAPI_HTTP.Models
{
    public class ISSLocation
    {
        public int TimeStamp { get; set; }
        public string Message { get; set; }
        public ISSLocationPosition Iss_Position { get; set; }
    }

    public class ISSLocationPosition
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

}
