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
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6205), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6207), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 11, 20, 1, 33, 27, 794, DateTimeKind.Local).AddTicks(6281) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8667), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8669), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 11, 20, 1, 32, 46, 845, DateTimeKind.Local).AddTicks(8733) });
        }
    }
}
