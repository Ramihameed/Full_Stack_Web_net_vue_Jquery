using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainingForDatabase.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { 6, "Operations" },
                    { 7, "Legal" },
                    { 8, "Customer Service" },
                    { 9, "Research and Development" },
                    { 10, "Supply Chain" }
                });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "price",
                value: 198);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "price",
                value: 281);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "price",
                value: 724);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "price",
                value: 822);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "price",
                value: 943);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "price",
                value: 811);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DepartmentId", "Departmentname", "description", "name", "price" },
                values: new object[,]
                {
                    { 7, 2, null, "Description 7", "Item 7", 746 },
                    { 8, 3, null, "Description 8", "Item 8", 766 },
                    { 9, 4, null, "Description 9", "Item 9", 746 },
                    { 10, 5, null, "Description 10", "Item 10", 890 },
                    { 16, 1, null, "Description 16", "Item 16", 237 },
                    { 17, 2, null, "Description 17", "Item 17", 909 },
                    { 18, 3, null, "Description 18", "Item 18", 981 },
                    { 19, 4, null, "Description 19", "Item 19", 747 },
                    { 20, 5, null, "Description 20", "Item 20", 623 },
                    { 26, 1, null, "Description 26", "Item 26", 883 },
                    { 27, 2, null, "Description 27", "Item 27", 538 },
                    { 28, 3, null, "Description 28", "Item 28", 526 },
                    { 29, 4, null, "Description 29", "Item 29", 273 },
                    { 30, 5, null, "Description 30", "Item 30", 869 },
                    { 36, 1, null, "Description 36", "Item 36", 761 },
                    { 37, 2, null, "Description 37", "Item 37", 352 },
                    { 38, 3, null, "Description 38", "Item 38", 472 },
                    { 39, 4, null, "Description 39", "Item 39", 867 },
                    { 40, 5, null, "Description 40", "Item 40", 429 },
                    { 46, 1, null, "Description 46", "Item 46", 796 },
                    { 47, 2, null, "Description 47", "Item 47", 701 },
                    { 48, 3, null, "Description 48", "Item 48", 360 },
                    { 49, 4, null, "Description 49", "Item 49", 968 },
                    { 50, 5, null, "Description 50", "Item 50", 881 },
                    { 11, 6, null, "Description 11", "Item 11", 751 },
                    { 12, 7, null, "Description 12", "Item 12", 197 },
                    { 13, 8, null, "Description 13", "Item 13", 911 },
                    { 14, 9, null, "Description 14", "Item 14", 915 },
                    { 15, 10, null, "Description 15", "Item 15", 449 },
                    { 21, 6, null, "Description 21", "Item 21", 325 },
                    { 22, 7, null, "Description 22", "Item 22", 136 },
                    { 23, 8, null, "Description 23", "Item 23", 849 },
                    { 24, 9, null, "Description 24", "Item 24", 835 },
                    { 25, 10, null, "Description 25", "Item 25", 812 },
                    { 31, 6, null, "Description 31", "Item 31", 420 },
                    { 32, 7, null, "Description 32", "Item 32", 90 },
                    { 33, 8, null, "Description 33", "Item 33", 188 },
                    { 34, 9, null, "Description 34", "Item 34", 582 },
                    { 35, 10, null, "Description 35", "Item 35", 912 },
                    { 41, 6, null, "Description 41", "Item 41", 423 },
                    { 42, 7, null, "Description 42", "Item 42", 895 },
                    { 43, 8, null, "Description 43", "Item 43", 217 },
                    { 44, 9, null, "Description 44", "Item 44", 404 },
                    { 45, 10, null, "Description 45", "Item 45", 411 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

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
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "price",
                value: 433);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "price",
                value: 463);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "price",
                value: 858);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "price",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "price",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                column: "price",
                value: 80);
        }
    }
}
