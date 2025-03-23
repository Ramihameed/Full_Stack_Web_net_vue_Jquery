﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingForDatabase.Data.Migrations
{
    /// <inheritdoc />
    public partial class mn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "price",
                value: 362);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "price",
                value: 966);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "price",
                value: 320);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "price",
                value: 261);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "price",
                value: 217);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6,
                column: "price",
                value: 109);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 1,
                column: "price",
                value: 793);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 2,
                column: "price",
                value: 668);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 3,
                column: "price",
                value: 174);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 4,
                column: "price",
                value: 176);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 5,
                column: "price",
                value: 869);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "id",
                keyValue: 6,
                column: "price",
                value: 699);
        }
    }
}
