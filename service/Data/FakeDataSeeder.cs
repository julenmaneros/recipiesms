using System;
using System.Linq;
using System.Threading.Tasks;
using Logic.RecipiesMicroservice;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace service.Data
{
    public class FakeDataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new RecipiesMsDbContext(serviceProvider.GetRequiredService<DbContextOptions<RecipiesMsDbContext>>());

            if (context.RecipiesBooks.Any())
            {
                return;
            }

            var recipieBook = RecipieBook.Create();
            
            if (recipieBook.IsSuccess)
            {
                var recipie = Recipie.Create("Acelgas a la vasca");
                recipieBook.Value.AddRecipie(recipie.Value);
                recipie = Recipie.Create("Crema de calabaza");
                recipieBook.Value.AddRecipie(recipie.Value);
            }

            context.RecipiesBooks.Add(recipieBook.Value);
            context.SaveChanges();
        }
    }
}