using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainingForDatabase.Migrations
{
    /// <inheritdoc />
    public partial class realistic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CourseName",
                value: "Introduction to Computer Science");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CourseName",
                value: "History of Western Civilization");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CourseName",
                value: "Data Structures and Algorithms");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CourseName",
                value: "Principles of Marketing");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CourseName",
                value: "Financial Accounting");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "CourseName",
                value: "Human Resource Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CourseName",
                value: "Operations Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "CourseName",
                value: "Business Law");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "CourseName",
                value: "Advanced Software Development");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CourseName",
                value: "Corporate Strategy");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11,
                column: "CourseName",
                value: "Economics for Business");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12,
                column: "CourseName",
                value: "International Business");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13,
                column: "CourseName",
                value: "Supply Chain Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14,
                column: "CourseName",
                value: "Project Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                column: "CourseName",
                value: "Digital Marketing");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CourseName",
                value: "Software Engineering");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17,
                column: "CourseName",
                value: "Artificial Intelligence");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18,
                column: "CourseName",
                value: "Cloud Computing");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19,
                column: "CourseName",
                value: "Business Analytics");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20,
                column: "CourseName",
                value: "Leadership and Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21,
                column: "CourseName",
                value: "Managerial Accounting");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22,
                column: "CourseName",
                value: "Legal Aspects of Business");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23,
                column: "CourseName",
                value: "Cybersecurity");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24,
                column: "CourseName",
                value: "Enterprise Resource Planning");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25,
                column: "CourseName",
                value: "Supply Chain Logistics");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26,
                column: "CourseName",
                value: "Corporate Governance");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27,
                column: "CourseName",
                value: "Corporate Social Responsibility");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28,
                column: "CourseName",
                value: "Business Intelligence");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29,
                column: "CourseName",
                value: "Advanced Marketing Strategies");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30,
                column: "CourseName",
                value: "Financial Management");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31,
                column: "CourseName",
                value: "Human Behavior in Organizations");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32,
                column: "CourseName",
                value: "Digital Transformation");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33,
                column: "CourseName",
                value: "Mobile App Development");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34,
                column: "CourseName",
                value: "Ethics in Business");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35,
                column: "CourseName",
                value: "Global Supply Chain Strategies");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36,
                column: "CourseName",
                value: "Cloud Security");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37,
                column: "CourseName",
                value: "Data Science and Big Data");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38,
                column: "CourseName",
                value: "Financial Planning");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39,
                column: "CourseName",
                value: "E-commerce");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40,
                column: "CourseName",
                value: "Innovation and Entrepreneurship");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "name",
                value: "Human Resources");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "name",
                value: "Information Technology");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "name",
                value: "Customer Support");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "name",
                value: "Research & Development");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 2, "Dell XPS 13", "Laptop", 999 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 1, "Ergonomic Office Chair", "Office Chair", 150 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 2, "Apple iPhone 14", "Smartphone", 799 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 1, "HP LaserJet Pro", "Printer", 200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 4, "Epson Projector 1080p", "Conference Room Projector", 1200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "description", "name", "price" },
                values: new object[] { "Wooden Executive Desk", "Desk", 300 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "description", "name", "price" },
                values: new object[] { "Bose QuietComfort 35", "Headphones", 350 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 8, "Logitech C920", "Webcam", 80 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 5, "Salesforce Subscription", "Sales CRM Software", 1500 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 8, "Zendesk Subscription", "Customer Support Software", 500 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 3, "QuickBooks Online", "Accounting Software", 300 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 2, "AWS EC2 Subscription", "Cloud Hosting Service", 1000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 9, "Autodesk Fusion 360", "R&D Software License", 200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 10, "SAP SCM License", "Supply Chain Management Tool", 3000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 7, "LexisNexis Subscription", "Legal Compliance Software", 400 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "Name",
                value: "John Doe");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "Name",
                value: "Alice Johnson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "Name",
                value: "Chris Williams");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "Name",
                value: "Mary Smith");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "Name",
                value: "David Lee");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                column: "Name",
                value: "Sophia Brown");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "Name",
                value: "James Wilson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "Name",
                value: "Linda Martinez");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "Name",
                value: "Michael Taylor");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "Name",
                value: "Sarah Anderson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11,
                column: "Name",
                value: "Daniel Thomas");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12,
                column: "Name",
                value: "Emma Jackson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13,
                column: "Name",
                value: "Lucas White");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14,
                column: "Name",
                value: "Mia Clark");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15,
                column: "Name",
                value: "Ethan Hall");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16,
                column: "Name",
                value: "Oliver Allen");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17,
                column: "Name",
                value: "Charlotte Young");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18,
                column: "Name",
                value: "Benjamin King");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19,
                column: "Name",
                value: "Amelia Scott");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20,
                column: "Name",
                value: "Henry Harris");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21,
                column: "Name",
                value: "Ella Walker");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22,
                column: "Name",
                value: "Samuel Lewis");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23,
                column: "Name",
                value: "Victoria King");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24,
                column: "Name",
                value: "Jack White");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25,
                column: "Name",
                value: "Ava Green");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26,
                column: "Name",
                value: "Liam Adams");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27,
                column: "Name",
                value: "Isabella Nelson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28,
                column: "Name",
                value: "Henry Carter");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29,
                column: "Name",
                value: "Sophia Mitchell");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30,
                column: "Name",
                value: "Oliver Perez");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31,
                column: "Name",
                value: "Charlotte Murphy");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32,
                column: "Name",
                value: "Jack Robinson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33,
                column: "Name",
                value: "Liam Martinez");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34,
                column: "Name",
                value: "Mia Evans");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35,
                column: "Name",
                value: "Ethan Gonzalez");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36,
                column: "Name",
                value: "Emily Reed");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37,
                column: "Name",
                value: "Logan Cooper");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38,
                column: "Name",
                value: "Scarlett Mitchell");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39,
                column: "Name",
                value: "Mason Perez");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40,
                column: "Name",
                value: "Zoe Stewart");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CourseName",
                value: "Course 1");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CourseName",
                value: "Course 2");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CourseName",
                value: "Course 3");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CourseName",
                value: "Course 4");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CourseName",
                value: "Course 5");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "CourseName",
                value: "Course 6");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CourseName",
                value: "Course 7");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "CourseName",
                value: "Course 8");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "CourseName",
                value: "Course 9");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CourseName",
                value: "Course 10");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11,
                column: "CourseName",
                value: "Course 11");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12,
                column: "CourseName",
                value: "Course 12");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13,
                column: "CourseName",
                value: "Course 13");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14,
                column: "CourseName",
                value: "Course 14");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                column: "CourseName",
                value: "Course 15");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CourseName",
                value: "Course 16");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17,
                column: "CourseName",
                value: "Course 17");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18,
                column: "CourseName",
                value: "Course 18");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19,
                column: "CourseName",
                value: "Course 19");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20,
                column: "CourseName",
                value: "Course 20");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21,
                column: "CourseName",
                value: "Course 21");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22,
                column: "CourseName",
                value: "Course 22");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23,
                column: "CourseName",
                value: "Course 23");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24,
                column: "CourseName",
                value: "Course 24");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25,
                column: "CourseName",
                value: "Course 25");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26,
                column: "CourseName",
                value: "Course 26");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27,
                column: "CourseName",
                value: "Course 27");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28,
                column: "CourseName",
                value: "Course 28");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29,
                column: "CourseName",
                value: "Course 29");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30,
                column: "CourseName",
                value: "Course 30");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31,
                column: "CourseName",
                value: "Course 31");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32,
                column: "CourseName",
                value: "Course 32");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33,
                column: "CourseName",
                value: "Course 33");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34,
                column: "CourseName",
                value: "Course 34");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35,
                column: "CourseName",
                value: "Course 35");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36,
                column: "CourseName",
                value: "Course 36");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37,
                column: "CourseName",
                value: "Course 37");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38,
                column: "CourseName",
                value: "Course 38");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39,
                column: "CourseName",
                value: "Course 39");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40,
                column: "CourseName",
                value: "Course 40");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "name",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "name",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "name",
                value: "Customer Service");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "name",
                value: "Research and Development");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 1, "Description 1", "Item 1", 397 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 2, "Description 2", "Item 2", 844 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 3, "Description 3", "Item 3", 321 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 4, "Description 4", "Item 4", 16 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 5, "Description 5", "Item 5", 109 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "description", "name", "price" },
                values: new object[] { "Description 6", "Item 6", 884 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "description", "name", "price" },
                values: new object[] { "Description 7", "Item 7", 290 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 3, "Description 8", "Item 8", 784 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 4, "Description 9", "Item 9", 281 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 5, "Description 10", "Item 10", 673 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 6, "Description 11", "Item 11", 322 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 7, "Description 12", "Item 12", 164 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 8, "Description 13", "Item 13", 240 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 9, "Description 14", "Item 14", 615 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "description", "name", "price" },
                values: new object[] { 10, "Description 15", "Item 15", 50 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DepartmentId", "description", "name", "price" },
                values: new object[,]
                {
                    { 16, 1, "Description 16", "Item 16", 113 },
                    { 17, 2, "Description 17", "Item 17", 735 },
                    { 18, 3, "Description 18", "Item 18", 625 },
                    { 19, 4, "Description 19", "Item 19", 101 },
                    { 20, 5, "Description 20", "Item 20", 293 },
                    { 21, 6, "Description 21", "Item 21", 318 },
                    { 22, 7, "Description 22", "Item 22", 737 },
                    { 23, 8, "Description 23", "Item 23", 294 },
                    { 24, 9, "Description 24", "Item 24", 85 },
                    { 25, 10, "Description 25", "Item 25", 865 },
                    { 26, 1, "Description 26", "Item 26", 828 },
                    { 27, 2, "Description 27", "Item 27", 341 },
                    { 28, 3, "Description 28", "Item 28", 775 },
                    { 29, 4, "Description 29", "Item 29", 101 },
                    { 30, 5, "Description 30", "Item 30", 483 },
                    { 31, 6, "Description 31", "Item 31", 682 },
                    { 32, 7, "Description 32", "Item 32", 490 },
                    { 33, 8, "Description 33", "Item 33", 414 },
                    { 34, 9, "Description 34", "Item 34", 243 },
                    { 35, 10, "Description 35", "Item 35", 100 },
                    { 36, 1, "Description 36", "Item 36", 811 },
                    { 37, 2, "Description 37", "Item 37", 532 },
                    { 38, 3, "Description 38", "Item 38", 611 },
                    { 39, 4, "Description 39", "Item 39", 139 },
                    { 40, 5, "Description 40", "Item 40", 114 },
                    { 41, 6, "Description 41", "Item 41", 266 },
                    { 42, 7, "Description 42", "Item 42", 895 },
                    { 43, 8, "Description 43", "Item 43", 471 },
                    { 44, 9, "Description 44", "Item 44", 401 },
                    { 45, 10, "Description 45", "Item 45", 407 },
                    { 46, 1, "Description 46", "Item 46", 940 },
                    { 47, 2, "Description 47", "Item 47", 896 },
                    { 48, 3, "Description 48", "Item 48", 178 },
                    { 49, 4, "Description 49", "Item 49", 724 },
                    { 50, 5, "Description 50", "Item 50", 277 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 1, 3 },
                    { 3, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "Name",
                value: "Student 1");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "Name",
                value: "Student 2");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "Name",
                value: "Student 3");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "Name",
                value: "Student 4");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "Name",
                value: "Student 5");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                column: "Name",
                value: "Student 6");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "Name",
                value: "Student 7");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "Name",
                value: "Student 8");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "Name",
                value: "Student 9");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "Name",
                value: "Student 10");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 11,
                column: "Name",
                value: "Student 11");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 12,
                column: "Name",
                value: "Student 12");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 13,
                column: "Name",
                value: "Student 13");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 14,
                column: "Name",
                value: "Student 14");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 15,
                column: "Name",
                value: "Student 15");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 16,
                column: "Name",
                value: "Student 16");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 17,
                column: "Name",
                value: "Student 17");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 18,
                column: "Name",
                value: "Student 18");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 19,
                column: "Name",
                value: "Student 19");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 20,
                column: "Name",
                value: "Student 20");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 21,
                column: "Name",
                value: "Student 21");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 22,
                column: "Name",
                value: "Student 22");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 23,
                column: "Name",
                value: "Student 23");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 24,
                column: "Name",
                value: "Student 24");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 25,
                column: "Name",
                value: "Student 25");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 26,
                column: "Name",
                value: "Student 26");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 27,
                column: "Name",
                value: "Student 27");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 28,
                column: "Name",
                value: "Student 28");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 29,
                column: "Name",
                value: "Student 29");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 30,
                column: "Name",
                value: "Student 30");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 31,
                column: "Name",
                value: "Student 31");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 32,
                column: "Name",
                value: "Student 32");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 33,
                column: "Name",
                value: "Student 33");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 34,
                column: "Name",
                value: "Student 34");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 35,
                column: "Name",
                value: "Student 35");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 36,
                column: "Name",
                value: "Student 36");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 37,
                column: "Name",
                value: "Student 37");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 38,
                column: "Name",
                value: "Student 38");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 39,
                column: "Name",
                value: "Student 39");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 40,
                column: "Name",
                value: "Student 40");
        }
    }
}
