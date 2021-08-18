using Microsoft.EntityFrameworkCore;
using Logic.RecipiesMicroservice;

namespace service.Data
{
    public class RecipiesMsDbContext : DbContext
    {
        public DbSet<RecipieBook> RecipiesBooks { get; set; }

        public DbSet<Recipie> Recipies { get; set; }

        public RecipiesMsDbContext(DbContextOptions<RecipiesMsDbContext> options) : base(options) { }
    }

}