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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .ToTable("Category")
                .HasKey(p => p.CategoryId);

            builder
                .Property(p => p.CategoryId)
                .HasColumnName("CategoryId");

            builder.HasData
            (
                new Category { CategoryId = 1, CatagoryName = "Category 1" },
                new Category { CategoryId = 2, CatagoryName = "Category 2" },
                new Category { CategoryId = 3, CatagoryName = "Category 3" },
                new Category { CategoryId = 4, CatagoryName = "Category 4" }
            );
        }
    }
}
