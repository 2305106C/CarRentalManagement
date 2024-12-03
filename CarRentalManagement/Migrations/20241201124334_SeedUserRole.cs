using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa2ac3eb-44c4-4c59-831f-a1fa452e00b5", "AQAAAAIAAYagAAAAEAWCH4X/Fk/Z0AiP8+JQ7Hg6HmUbT3YGN7DUgpoel0T3XR5YvRQdizwLxAECw2CxIQ==", "7af57dbc-7c28-4870-889a-7e374aeb9b04" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8742), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8929), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8931), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8998), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(9000), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 12, 1, 20, 43, 33, 487, DateTimeKind.Local).AddTicks(9001) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
