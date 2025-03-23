using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class pen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "price",
                value: 930);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "price",
                value: 914);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "price",
                value: 382);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "price",
                value: 832);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "price",
                value: 204);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "id", "description", "name", "price" },
                values: new object[] { 6, "Description 5", "Item 5", 790 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "price",
                value: 654);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "price",
                value: 800);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "price",
                value: 957);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "price",
                value: 161);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "price",
                value: 969);
        }
    }
}
