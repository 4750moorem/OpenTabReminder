using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTabReminder.Models
{
    public class User
    {
        public string Name { get; set; }
        public bool OpenTab;
        public Location ActiveLocation;
        public Location TabLocation { get; set; }
        public User()
        {
            Name = "Dukes";
            OpenTab = false;
            ActiveLocation = new Location();
            TabLocation = new Location();
        }
    }
}
