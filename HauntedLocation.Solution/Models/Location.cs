using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HauntedLocation.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public string Name { get; set; }

        public string Keyword { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }
    }
}
