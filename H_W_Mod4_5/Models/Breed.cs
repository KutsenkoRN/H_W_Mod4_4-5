using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod4_5.Models
{
    public class Breed
    {
        public int BreedId { get; set; }

        public string BreedName { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Pet> Pets { get; set; }
    }
}
