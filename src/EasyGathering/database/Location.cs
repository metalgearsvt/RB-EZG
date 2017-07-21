using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGathering.database
{
    public class Location
    {
        public int ZoneId { get; set; }
        public String Name { get; set; }

        public Location(int ZoneId, String Name)
        {
            this.ZoneId = ZoneId;
            this.Name = Name;
        }


    }
}
