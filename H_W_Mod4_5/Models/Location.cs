using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod4_5.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public virtual List<Pet> Pets { get; set; }
    }
}
