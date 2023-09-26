using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod4_5.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        public int? CategoryId { get; set; }

        public int? BreedId { get; set; }

        public int? LocationId { get; set; }

        public string Name { get; set; }

        public float Age { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public virtual Category Category { get; set; }

        public virtual Breed Breed { get; set; }

        public virtual Location Location { get; set; }
    }
}
