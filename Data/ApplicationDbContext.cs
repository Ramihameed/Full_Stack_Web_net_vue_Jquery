using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrainingForDatabase.ItemVM;
using TrainingForDatabase.Models;

namespace TrainingForDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, name = "Item 1", description = "Description 1", price = new Random().Next(1, 1000) },
                new Item { Id = 2, name = "Item 2", description = "Description 2", price = new Random().Next(1, 1000) },
                new Item { Id = 3, name = "Item 3", description = "Description 3", price = new Random().Next(1, 1000) },
                new Item { Id = 4, name = "Item 4", description = "Description 4", price = new Random().Next(1, 1000) },
                new Item { Id = 5, name = "Item 5", description = "Description 5", price = new Random().Next(1, 1000) },
                new Item { Id = 6, name = "Item 5", description = "Description 5", price = new Random().Next(1, 1000) }
            );
        }
    }
}
