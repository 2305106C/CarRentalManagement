using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6273), "Black", "System" },
                    { 2, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6278), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6608), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6609), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6612), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6613), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6730), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6731), "i4", "System" },
                    { 2, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6735), "X5", "System" },
                    { 3, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6738), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6739), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6741), new DateTime(2024, 12, 1, 18, 30, 5, 931, DateTimeKind.Local).AddTicks(6742), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
