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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder
                .ToTable("Location")
                .HasKey(p => p.LocationId);

            builder
                .Property(p => p.LocationId)
                .HasColumnName("LocationId");

            builder.HasData
            (
                new Location { LocationId = 1, LocationName = "Location 1" },
                new Location { LocationId = 2, LocationName = "Location 2" },
                new Location { LocationId = 3, LocationName = "Location 3" },
                new Location { LocationId = 4, LocationName = "Location 4" }
            );
        }
    }
}
