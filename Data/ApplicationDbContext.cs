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
            //
            modelBuilder.Entity<Department>().HasData(
    new Department { Id = 1, name = "Human Resources" },
    new Department { Id = 2, name = "Information Technology" },
    new Department { Id = 3, name = "Finance" },
    new Department { Id = 4, name = "Marketing" },
    new Department { Id = 5, name = "Sales" },
    new Department { Id = 6, name = "Operations" },
    new Department { Id = 7, name = "Legal" },
    new Department { Id = 8, name = "Customer Support" },
    new Department { Id = 9, name = "Research & Development" },
    new Department { Id = 10, name = "Supply Chain" }
);

            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, name = "Laptop", description = "Dell XPS 13", price = 999, DepartmentId = 2 },
                new Item { Id = 2, name = "Office Chair", description = "Ergonomic Office Chair", price = 150, DepartmentId = 1 },
                new Item { Id = 3, name = "Smartphone", description = "Apple iPhone 14", price = 799, DepartmentId = 2 },
                new Item { Id = 4, name = "Printer", description = "HP LaserJet Pro", price = 200, DepartmentId = 1 },
                new Item { Id = 5, name = "Conference Room Projector", description = "Epson Projector 1080p", price = 1200, DepartmentId = 4 },
                new Item { Id = 6, name = "Desk", description = "Wooden Executive Desk", price = 300, DepartmentId = 1 },
                new Item { Id = 7, name = "Headphones", description = "Bose QuietComfort 35", price = 350, DepartmentId = 2 },
                new Item { Id = 8, name = "Webcam", description = "Logitech C920", price = 80, DepartmentId = 8 },
                new Item { Id = 9, name = "Sales CRM Software", description = "Salesforce Subscription", price = 1500, DepartmentId = 5 },
                new Item { Id = 10, name = "Customer Support Software", description = "Zendesk Subscription", price = 500, DepartmentId = 8 },
                new Item { Id = 11, name = "Accounting Software", description = "QuickBooks Online", price = 300, DepartmentId = 3 },
                new Item { Id = 12, name = "Cloud Hosting Service", description = "AWS EC2 Subscription", price = 1000, DepartmentId = 2 },
                new Item { Id = 13, name = "R&D Software License", description = "Autodesk Fusion 360", price = 200, DepartmentId = 9 },
                new Item { Id = 14, name = "Supply Chain Management Tool", description = "SAP SCM License", price = 3000, DepartmentId = 10 },
                new Item { Id = 15, name = "Legal Compliance Software", description = "LexisNexis Subscription", price = 400, DepartmentId = 7 }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "John Doe" },
                new Student { StudentId = 2, Name = "Alice Johnson" },
                new Student { StudentId = 3, Name = "Chris Williams" },
                new Student { StudentId = 4, Name = "Mary Smith" },
                new Student { StudentId = 5, Name = "David Lee" },
                new Student { StudentId = 6, Name = "Sophia Brown" },
                new Student { StudentId = 7, Name = "James Wilson" },
                new Student { StudentId = 8, Name = "Linda Martinez" },
                new Student { StudentId = 9, Name = "Michael Taylor" },
                new Student { StudentId = 10, Name = "Sarah Anderson" },
                new Student { StudentId = 11, Name = "Daniel Thomas" },
                new Student { StudentId = 12, Name = "Emma Jackson" },
                new Student { StudentId = 13, Name = "Lucas White" },
                new Student { StudentId = 14, Name = "Mia Clark" },
                new Student { StudentId = 15, Name = "Ethan Hall" },
                new Student { StudentId = 16, Name = "Oliver Allen" },
                new Student { StudentId = 17, Name = "Charlotte Young" },
                new Student { StudentId = 18, Name = "Benjamin King" },
                new Student { StudentId = 19, Name = "Amelia Scott" },
                new Student { StudentId = 20, Name = "Henry Harris" },
                new Student { StudentId = 21, Name = "Ella Walker" },
                new Student { StudentId = 22, Name = "Samuel Lewis" },
                new Student { StudentId = 23, Name = "Victoria King" },
                new Student { StudentId = 24, Name = "Jack White" },
                new Student { StudentId = 25, Name = "Ava Green" },
                new Student { StudentId = 26, Name = "Liam Adams" },
                new Student { StudentId = 27, Name = "Isabella Nelson" },
                new Student { StudentId = 28, Name = "Henry Carter" },
                new Student { StudentId = 29, Name = "Sophia Mitchell" },
                new Student { StudentId = 30, Name = "Oliver Perez" },
                new Student { StudentId = 31, Name = "Charlotte Murphy" },
                new Student { StudentId = 32, Name = "Jack Robinson" },
                new Student { StudentId = 33, Name = "Liam Martinez" },
                new Student { StudentId = 34, Name = "Mia Evans" },
                new Student { StudentId = 35, Name = "Ethan Gonzalez" },
                new Student { StudentId = 36, Name = "Emily Reed" },
                new Student { StudentId = 37, Name = "Logan Cooper" },
                new Student { StudentId = 38, Name = "Scarlett Mitchell" },
                new Student { StudentId = 39, Name = "Mason Perez" },
                new Student { StudentId = 40, Name = "Zoe Stewart" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, CourseName = "Introduction to Computer Science" },
                new Course { CourseId = 2, CourseName = "History of Western Civilization" },
                new Course { CourseId = 3, CourseName = "Data Structures and Algorithms" },
                new Course { CourseId = 4, CourseName = "Principles of Marketing" },
                new Course { CourseId = 5, CourseName = "Financial Accounting" },
                new Course { CourseId = 6, CourseName = "Human Resource Management" },
                new Course { CourseId = 7, CourseName = "Operations Management" },
                new Course { CourseId = 8, CourseName = "Business Law" },
                new Course { CourseId = 9, CourseName = "Advanced Software Development" },
                new Course { CourseId = 10, CourseName = "Corporate Strategy" },
                new Course { CourseId = 11, CourseName = "Economics for Business" },
                new Course { CourseId = 12, CourseName = "International Business" },
                new Course { CourseId = 13, CourseName = "Supply Chain Management" },
                new Course { CourseId = 14, CourseName = "Project Management" },
                new Course { CourseId = 15, CourseName = "Digital Marketing" },
                new Course { CourseId = 16, CourseName = "Software Engineering" },
                new Course { CourseId = 17, CourseName = "Artificial Intelligence" },
                new Course { CourseId = 18, CourseName = "Cloud Computing" },
                new Course { CourseId = 19, CourseName = "Business Analytics" },
                new Course { CourseId = 20, CourseName = "Leadership and Management" },
                new Course { CourseId = 21, CourseName = "Managerial Accounting" },
                new Course { CourseId = 22, CourseName = "Legal Aspects of Business" },
                new Course { CourseId = 23, CourseName = "Cybersecurity" },
                new Course { CourseId = 24, CourseName = "Enterprise Resource Planning" },
                new Course { CourseId = 25, CourseName = "Supply Chain Logistics" },
                new Course { CourseId = 26, CourseName = "Corporate Governance" },
                new Course { CourseId = 27, CourseName = "Corporate Social Responsibility" },
                new Course { CourseId = 28, CourseName = "Business Intelligence" },
                new Course { CourseId = 29, CourseName = "Advanced Marketing Strategies" },
                new Course { CourseId = 30, CourseName = "Financial Management" },
                new Course { CourseId = 31, CourseName = "Human Behavior in Organizations" },
                new Course { CourseId = 32, CourseName = "Digital Transformation" },
                new Course { CourseId = 33, CourseName = "Mobile App Development" },
                new Course { CourseId = 34, CourseName = "Ethics in Business" },
                new Course { CourseId = 35, CourseName = "Global Supply Chain Strategies" },
                new Course { CourseId = 36, CourseName = "Cloud Security" },
                new Course { CourseId = 37, CourseName = "Data Science and Big Data" },
                new Course { CourseId = 38, CourseName = "Financial Planning" },
                new Course { CourseId = 39, CourseName = "E-commerce" },
                new Course { CourseId = 40, CourseName = "Innovation and Entrepreneurship" }
            );




        }
    }
    }

