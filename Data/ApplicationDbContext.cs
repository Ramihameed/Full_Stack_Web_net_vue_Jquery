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

        public DbSet<Media> Media { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentCourses>()
               .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourses>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourses>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
    new Department { Id = 1, name = "HR" },
    new Department { Id = 2, name = "IT" },
    new Department { Id = 3, name = "Finance" },
    new Department { Id = 4, name = "Marketing" },
    new Department { Id = 5, name = "Sales" },
    new Department { Id = 6, name = "Operations" },
    new Department { Id = 7, name = "Legal" },
    new Department { Id = 8, name = "Customer Service" },
    new Department { Id = 9, name = "Research and Development" },
    new Department { Id = 10, name = "Supply Chain"}
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


            modelBuilder.Entity<Student>().HasData(
    new Student { StudentId = 1, Name = "Student 1" },
    new Student { StudentId = 2, Name = "Student 2" },
    new Student { StudentId = 3, Name = "Student 3" },
    new Student { StudentId = 4, Name = "Student 4" },
    new Student { StudentId = 5, Name = "Student 5" },
    new Student { StudentId = 6, Name = "Student 6" },
    new Student { StudentId = 7, Name = "Student 7" },
    new Student { StudentId = 8, Name = "Student 8" },
    new Student { StudentId = 9, Name = "Student 9" },
    new Student { StudentId = 10, Name = "Student 10" },
    new Student { StudentId = 11, Name = "Student 11" },
    new Student { StudentId = 12, Name = "Student 12" },
    new Student { StudentId = 13, Name = "Student 13" },
    new Student { StudentId = 14, Name = "Student 14" },
    new Student { StudentId = 15, Name = "Student 15" },
    new Student { StudentId = 16, Name = "Student 16" },
    new Student { StudentId = 17, Name = "Student 17" },
    new Student { StudentId = 18, Name = "Student 18" },
    new Student { StudentId = 19, Name = "Student 19" },
    new Student { StudentId = 20, Name = "Student 20" },
    new Student { StudentId = 21, Name = "Student 21" },
    new Student { StudentId = 22, Name = "Student 22" },
    new Student { StudentId = 23, Name = "Student 23" },
    new Student { StudentId = 24, Name = "Student 24" },
    new Student { StudentId = 25, Name = "Student 25" },
    new Student { StudentId = 26, Name = "Student 26" },
    new Student { StudentId = 27, Name = "Student 27" },
    new Student { StudentId = 28, Name = "Student 28" },
    new Student { StudentId = 29, Name = "Student 29" },
    new Student { StudentId = 30, Name = "Student 30" },
    new Student { StudentId = 31, Name = "Student 31" },
    new Student { StudentId = 32, Name = "Student 32" },
    new Student { StudentId = 33, Name = "Student 33" },
    new Student { StudentId = 34, Name = "Student 34" },
    new Student { StudentId = 35, Name = "Student 35" },
    new Student { StudentId = 36, Name = "Student 36" },
    new Student { StudentId = 37, Name = "Student 37" },
    new Student { StudentId = 38, Name = "Student 38" },
    new Student { StudentId = 39, Name = "Student 39" },
    new Student { StudentId = 40, Name = "Student 40" }
);

            // Seed data for Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseName = "Course 1" },
                new Course { CourseId = 2, CourseName = "Course 2" },
                new Course { CourseId = 3, CourseName = "Course 3" },
                new Course { CourseId = 4, CourseName = "Course 4" },
                new Course { CourseId = 5, CourseName = "Course 5" },
                new Course { CourseId = 6, CourseName = "Course 6" },
                new Course { CourseId = 7, CourseName = "Course 7" },
                new Course { CourseId = 8, CourseName = "Course 8" },
                new Course { CourseId = 9, CourseName = "Course 9" },
                new Course { CourseId = 10, CourseName = "Course 10" },
                new Course { CourseId = 11, CourseName = "Course 11" },
                new Course { CourseId = 12, CourseName = "Course 12" },
                new Course { CourseId = 13, CourseName = "Course 13" },
                new Course { CourseId = 14, CourseName = "Course 14" },
                new Course { CourseId = 15, CourseName = "Course 15" },
                new Course { CourseId = 16, CourseName = "Course 16" },
                new Course { CourseId = 17, CourseName = "Course 17" },
                new Course { CourseId = 18, CourseName = "Course 18" },
                new Course { CourseId = 19, CourseName = "Course 19" },
                new Course { CourseId = 20, CourseName = "Course 20" },
                new Course { CourseId = 21, CourseName = "Course 21" },
                new Course { CourseId = 22, CourseName = "Course 22" },
                new Course { CourseId = 23, CourseName = "Course 23" },
                new Course { CourseId = 24, CourseName = "Course 24" },
                new Course { CourseId = 25, CourseName = "Course 25" },
                new Course { CourseId = 26, CourseName = "Course 26" },
                new Course { CourseId = 27, CourseName = "Course 27" },
                new Course { CourseId = 28, CourseName = "Course 28" },
                new Course { CourseId = 29, CourseName = "Course 29" },
                new Course { CourseId = 30, CourseName = "Course 30" },
                new Course { CourseId = 31, CourseName = "Course 31" },
                new Course { CourseId = 32, CourseName = "Course 32" },
                new Course { CourseId = 33, CourseName = "Course 33" },
                new Course { CourseId = 34, CourseName = "Course 34" },
                new Course { CourseId = 35, CourseName = "Course 35" },
                new Course { CourseId = 36, CourseName = "Course 36" },
                new Course { CourseId = 37, CourseName = "Course 37" },
                new Course { CourseId = 38, CourseName = "Course 38" },
                new Course { CourseId = 39, CourseName = "Course 39" },
                new Course { CourseId = 40, CourseName = "Course 40" }
            );

            // Create relationships using navigation properties
            modelBuilder.Entity<StudentCourses>().HasData(
                new StudentCourses { StudentId = 1, CourseId = 1 }, // John Doe takes Mathematics 101
                new StudentCourses { StudentId = 1, CourseId = 2 }, // John Doe takes History 202
                new StudentCourses { StudentId = 2, CourseId = 3 }, // Jane Smith takes Computer Science 303
                new StudentCourses { StudentId = 3, CourseId = 1 }, // David Johnson takes Mathematics 101
                new StudentCourses { StudentId = 3, CourseId = 3 }  // David Johnson takes Computer Science 303
            );



        }
    }
    }

