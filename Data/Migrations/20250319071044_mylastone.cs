using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class mylastone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "price",
                value: 453);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "price",
                value: 553);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "price",
                value: 930);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "price",
                value: 806);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "price",
                value: 580);
        }
    }
}
