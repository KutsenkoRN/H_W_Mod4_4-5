using Microsoft.EntityFrameworkCore.ChangeTracking;
using H_W_Mod4_5.Context;
using H_W_Mod4_5.Models;

namespace H_W_Mod4_5
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using (var context = new ApplicationDbContextFactory().CreateDbContext())
            {
                await AddAsync(context);
            }
        }
        public static async Task AddAsync(ApplicationDbContext context)
        {
            var newCategory1 = new Category { CatagoryName = "One" };
            var newCategory2 = new Category { CatagoryName = "Two" };

            await context.Categories.AddAsync(newCategory1);
            await context.Categories.AddAsync(newCategory2);


            var newBreed1 = new Breed { BreedName = "New Breed 1", CategoryId = newCategory1.CategoryId };
            var newBreed2 = new Breed { BreedName = "New Breed 2", CategoryId = newCategory2.CategoryId };

            await context.Breeds.AddAsync(newBreed1);
            await context.Breeds.AddAsync(newBreed2);

            var newLocation1 = new Location { LocationName = "New Location 1" };
            var newLocation2 = new Location { LocationName = "New Location 2" };

            await context.Locations.AddAsync(newLocation1);
            await context.Locations.AddAsync(newLocation2);

            await context.SaveChangesAsync();

            var newPet1 = new Pet { Name = "New Pet 1", Description = "New Description 1", ImageUrl = "New Image Url 1", CategoryId = newCategory1.CategoryId, BreedId = newBreed1.BreedId, LocationId = newLocation1.LocationId };
            var newPet2 = new Pet { Name = "New Pet 2", Description = "New Description 2", ImageUrl = "New Image Url 2", CategoryId = newCategory2.CategoryId, BreedId = newBreed2.BreedId, LocationId = newLocation2.LocationId };

            await context.Pets.AddAsync(newPet1);
            await context.Pets.AddAsync(newPet2);

            await context.SaveChangesAsync();
        }



    }
}