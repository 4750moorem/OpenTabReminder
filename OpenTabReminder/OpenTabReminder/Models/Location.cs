using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OpenTabReminder.Models
{
    public class Location
    {
        public double Latitude { get; set; } = 0.00;
        public double Longitude { get; set; } = 0.00;
        public Location()
        {
            Latitude = 0.00;
            Longitude = 0.00;
        }
    }
}
