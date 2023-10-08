using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod4_5.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CatagoryName { get; set; }

        public virtual List<Breed> Breeds { get; set; }

        public virtual List<Pet> Pets { get; set; }
    }
}
