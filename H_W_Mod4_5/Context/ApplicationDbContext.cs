using H_W_Mod4_5.Configurations;
using Microsoft.EntityFrameworkCore;
using H_W_Mod4_5.Configurations;
using H_W_Mod4_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace H_W_Mod4_5.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BreedConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
        }
    }
}
