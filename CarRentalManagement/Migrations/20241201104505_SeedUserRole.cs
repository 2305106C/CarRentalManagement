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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f9dcb230-acf9-43b3-ad86-b5cc898009c9", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOg1Ae1qPE3oNZ1Su/1gqFp83KcP4Z5wNOSuylG4nN9WmobwcA8HBeZi62PXD2nFcQ==", null, false, "7a797af8-18b9-4433-8ad4-f08d2b08f838", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9643), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9655), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9862), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9865), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9970), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9972), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9974), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 12, 1, 18, 45, 5, 369, DateTimeKind.Local).AddTicks(9976) });

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1631), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1644), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1801), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1803), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1876), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1877), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1879), new DateTime(2024, 12, 1, 18, 39, 4, 436, DateTimeKind.Local).AddTicks(1879) });
        }
    }
}
