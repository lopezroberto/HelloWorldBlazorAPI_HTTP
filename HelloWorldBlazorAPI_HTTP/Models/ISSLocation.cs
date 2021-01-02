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
    }

}
