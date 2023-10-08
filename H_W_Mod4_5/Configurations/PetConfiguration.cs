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
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder
                .ToTable("Pet")
                .HasKey(p => p.PetId);

            builder
                .Property(p => p.PetId)
                .HasColumnName("PetId");

            builder.HasData
            (
                new Pet { PetId = 1, Name = "Pet 1", Age = 1, ImageUrl = "Image 1", Description = "Description 1", BreedId = 1, CategoryId = 1, LocationId = 1 },
                new Pet { PetId = 2, Name = "Pet 2", Age = 2, ImageUrl = "Image 2", Description = "Description 2", BreedId = 2, CategoryId = 2, LocationId = 2 },
                new Pet { PetId = 3, Name = "Pet 3", Age = 3, ImageUrl = "Image 3", Description = "Description 3", BreedId = 3, CategoryId = 3, LocationId = 3 },
                new Pet { PetId = 4, Name = "Pet 4", Age = 4, ImageUrl = "Image 4", Description = "Description 4", BreedId = 4, CategoryId = 4, LocationId = 4 }
            );
        }
    }
}
