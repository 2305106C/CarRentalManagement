using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8393132c-6cc0-419c-af6a-d0890cd3b0fb", "AQAAAAIAAYagAAAAEPCYJAbJkc/ouSgkC8vebVsE4/tFN9LAO4GffcA3Akc78NCvfho2t9PjEmOYhHTw0A==", "df9aeec8-26e6-41e3-8346-18b5f56f98f8" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8572), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8574), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 12, 1, 20, 42, 53, 304, DateTimeKind.Local).AddTicks(8640) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e32bd1a1-727b-450c-9b58-31fe49d8b740", "AQAAAAIAAYagAAAAECtDct/sHFEjiqC3v0p9k2cve1LQpgtfv0j0qW7oYHF/WC/r7QFytC013SK6wHmykg==", "52301a66-ef3d-4b1a-abfe-e472900b487b" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8155), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8167), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8319), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8392), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 12, 1, 20, 40, 37, 24, DateTimeKind.Local).AddTicks(8394) });
        }
    }
}
