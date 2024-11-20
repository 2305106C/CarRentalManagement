using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "53682393-4ead-4273-8906-968de6e32562", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFSessRwbpEVfQdQ/D3f5U1yqfAp7eeXR9T9tWv+2sOnFm/+U0r6S//gNEE4SCMwbQ==", null, false, "835be2c0-a4b2-4e62-b3ab-4b4d876790ae", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(1996), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2176), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2178), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2241), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2245), new DateTime(2024, 11, 20, 1, 43, 4, 992, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(3894), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4076), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4143), new DateTime(2024, 11, 20, 1, 36, 6, 210, DateTimeKind.Local).AddTicks(4143) });
        }
    }
}
