using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldBlazorAPI_HTTP.Models
{
    public class ISSLocation
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Altitude { get; set; }
        public decimal Velocity { get; set; }
        public string Visibility { get; set; }
        public decimal Footprint { get; set; }
        public int Timestamp { get; set; }
        public decimal Daynum { get; set; }
        public decimal Solar_lat { get; set; }
        public decimal Solar_lon { get; set; }
        public string Units{ get; set; }
    }

}
