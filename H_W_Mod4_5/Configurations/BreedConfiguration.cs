using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using H_W_Mod4_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace H_W_Mod4_5.Configurations
{
    public class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            builder
                .ToTable("Breed")
                .HasKey(p => p.BreedId);

            builder
                .Property(p => p.BreedId)
                .HasColumnName("BreedId");

            builder.HasData
            (
                new Breed { BreedId = 1, BreedName = "Breed 1", CategoryId = 1 },
                new Breed { BreedId = 2, BreedName = "Breed 2", CategoryId = 2 },
                new Breed { BreedId = 3, BreedName = "Breed 3", CategoryId = 3 },
                new Breed { BreedId = 4, BreedName = "Breed 4", CategoryId = 4 }
            );
        }
    }
}
