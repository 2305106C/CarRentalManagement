using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64858631-f034-40b0-893c-0c75b19ad34a", "AQAAAAIAAYagAAAAELfrh2g0DT0TKnpYxsiYX/LRCbH77sKLrX3qyj67K3wnwKihTshlqHIhT5q4mY/k0g==", "aab2e1d4-28ad-4107-a55c-12d8469783b6" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3589), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3766), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3836), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3838), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3840), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3842), new DateTime(2024, 12, 1, 20, 43, 16, 467, DateTimeKind.Local).AddTicks(3842) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
