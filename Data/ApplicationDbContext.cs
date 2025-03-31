using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
    new Department { Id = 1, name = "HR", items = new List<Item>() },
    new Department { Id = 2, name = "IT", items = new List<Item>() },
    new Department { Id = 3, name = "Finance", items = new List<Item>() },
    new Department { Id = 4, name = "Marketing", items = new List<Item>() },
    new Department { Id = 5, name = "Sales", items = new List<Item>() },
    new Department { Id = 6, name = "Operations", items = new List<Item>() },
    new Department { Id = 7, name = "Legal", items = new List<Item>() },
    new Department { Id = 8, name = "Customer Service", items = new List<Item>() },
    new Department { Id = 9, name = "Research and Development", items = new List<Item>() },
    new Department { Id = 10, name = "Supply Chain", items = new List<Item>() }
);

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, name = "Item 1", description = "Description 1", price = new Random().Next(1, 1000), DepartmentId = 1},
                new Item { Id = 2, name = "Item 2", description = "Description 2", price = new Random().Next(1, 1000), DepartmentId = 2 },
                new Item { Id = 3, name = "Item 3", description = "Description 3", price = new Random().Next(1, 1000), DepartmentId = 3 },
                new Item { Id = 4, name = "Item 4", description = "Description 4", price = new Random().Next(1, 1000), DepartmentId = 4 },
                new Item { Id = 5, name = "Item 5", description = "Description 5", price = new Random().Next(1, 1000), DepartmentId = 5 },
                new Item { Id = 6, name = "Item 6", description = "Description 6", price = new Random().Next(1, 1000), DepartmentId = 1 },
                new Item { Id = 7, name = "Item 7", description = "Description 7", price = new Random().Next(1, 1000), DepartmentId = 2 },
                new Item { Id = 8, name = "Item 8", description = "Description 8", price = new Random().Next(1, 1000), DepartmentId = 3 },
                new Item { Id = 9, name = "Item 9", description = "Description 9", price = new Random().Next(1, 1000), DepartmentId = 4 },
                new Item { Id = 10, name = "Item 10", description = "Description 10", price = new Random().Next(1, 1000), DepartmentId = 5 },
                new Item { Id = 11, name = "Item 11", description = "Description 11", price = new Random().Next(1, 1000), DepartmentId = 6 },
                new Item { Id = 12, name = "Item 12", description = "Description 12", price = new Random().Next(1, 1000), DepartmentId = 7 },
                new Item { Id = 13, name = "Item 13", description = "Description 13", price = new Random().Next(1, 1000), DepartmentId = 8 },
                new Item { Id = 14, name = "Item 14", description = "Description 14", price = new Random().Next(1, 1000), DepartmentId = 9 },
                new Item { Id = 15, name = "Item 15", description = "Description 15", price = new Random().Next(1, 1000), DepartmentId = 10 },
                new Item { Id = 16, name = "Item 16", description = "Description 16", price = new Random().Next(1, 1000), DepartmentId = 1 },
                new Item { Id = 17, name = "Item 17", description = "Description 17", price = new Random().Next(1, 1000), DepartmentId = 2 },
                new Item { Id = 18, name = "Item 18", description = "Description 18", price = new Random().Next(1, 1000), DepartmentId = 3 },
                new Item { Id = 19, name = "Item 19", description = "Description 19", price = new Random().Next(1, 1000), DepartmentId = 4 },
                new Item { Id = 20, name = "Item 20", description = "Description 20", price = new Random().Next(1, 1000), DepartmentId = 5 },
                new Item { Id = 21, name = "Item 21", description = "Description 21", price = new Random().Next(1, 1000), DepartmentId = 6 },
                new Item { Id = 22, name = "Item 22", description = "Description 22", price = new Random().Next(1, 1000), DepartmentId = 7 },
                new Item { Id = 23, name = "Item 23", description = "Description 23", price = new Random().Next(1, 1000), DepartmentId = 8 },
                new Item { Id = 24, name = "Item 24", description = "Description 24", price = new Random().Next(1, 1000), DepartmentId = 9 },
                new Item { Id = 25, name = "Item 25", description = "Description 25", price = new Random().Next(1, 1000), DepartmentId = 10 },
                new Item { Id = 26, name = "Item 26", description = "Description 26", price = new Random().Next(1, 1000), DepartmentId = 1 },
                new Item { Id = 27, name = "Item 27", description = "Description 27", price = new Random().Next(1, 1000), DepartmentId = 2 },
                new Item { Id = 28, name = "Item 28", description = "Description 28", price = new Random().Next(1, 1000), DepartmentId = 3 },
                new Item { Id = 29, name = "Item 29", description = "Description 29", price = new Random().Next(1, 1000), DepartmentId = 4 },
                new Item { Id = 30, name = "Item 30", description = "Description 30", price = new Random().Next(1, 1000), DepartmentId = 5 },
                new Item { Id = 31, name = "Item 31", description = "Description 31", price = new Random().Next(1, 1000), DepartmentId = 6 },
                new Item { Id = 32, name = "Item 32", description = "Description 32", price = new Random().Next(1, 1000), DepartmentId = 7 },
                new Item { Id = 33, name = "Item 33", description = "Description 33", price = new Random().Next(1, 1000), DepartmentId = 8 },
                new Item { Id = 34, name = "Item 34", description = "Description 34", price = new Random().Next(1, 1000), DepartmentId = 9 },
                new Item { Id = 35, name = "Item 35", description = "Description 35", price = new Random().Next(1, 1000), DepartmentId = 10 },
                new Item { Id = 36, name = "Item 36", description = "Description 36", price = new Random().Next(1, 1000), DepartmentId = 1 },
                new Item { Id = 37, name = "Item 37", description = "Description 37", price = new Random().Next(1, 1000), DepartmentId = 2 },
                new Item { Id = 38, name = "Item 38", description = "Description 38", price = new Random().Next(1, 1000), DepartmentId = 3 },
                new Item { Id = 39, name = "Item 39", description = "Description 39", price = new Random().Next(1, 1000), DepartmentId = 4 },
                new Item { Id = 40, name = "Item 40", description = "Description 40", price = new Random().Next(1, 1000), DepartmentId = 5 },
                new Item { Id = 41, name = "Item 41", description = "Description 41", price = new Random().Next(1, 1000), DepartmentId = 6 },
                new Item { Id = 42, name = "Item 42", description = "Description 42", price = new Random().Next(1, 1000), DepartmentId = 7 },
                new Item { Id = 43, name = "Item 43", description = "Description 43", price = new Random().Next(1, 1000), DepartmentId = 8 },
                new Item { Id = 44, name = "Item 44", description = "Description 44", price = new Random().Next(1, 1000), DepartmentId = 9 },
                new Item { Id = 45, name = "Item 45", description = "Description 45", price = new Random().Next(1, 1000), DepartmentId = 10 },
                new Item { Id = 46, name = "Item 46", description = "Description 46", price = new Random().Next(1, 1000), DepartmentId = 1 },
                new Item { Id = 47, name = "Item 47", description = "Description 47", price = new Random().Next(1, 1000), DepartmentId = 2 },
                new Item { Id = 48, name = "Item 48", description = "Description 48", price = new Random().Next(1, 1000), DepartmentId = 3 },
                new Item { Id = 49, name = "Item 49", description = "Description 49", price = new Random().Next(1, 1000), DepartmentId = 4 },
                new Item { Id = 50, name = "Item 50", description = "Description 50", price = new Random().Next(1, 1000), DepartmentId = 5 }
            );



        }
    }
    }

