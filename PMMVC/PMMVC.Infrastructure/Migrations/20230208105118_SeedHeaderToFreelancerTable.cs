using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMMVC.Infrastructure.Migrations
{
    public partial class SeedHeaderToFreelancerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Header", "TimeCreated", "TimeUpdated" },
                values: new object[] { "Machine Learning Engineer", new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(5941), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(5940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(5990), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6334), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6337), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6336), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeCreated",
                value: new DateTimeOffset(new DateTime(2023, 2, 8, 11, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6383), new TimeSpan(0, 1, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeCreated",
                value: new DateTimeOffset(new DateTime(2023, 2, 8, 11, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6385), new TimeSpan(0, 1, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6362), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6362), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6366), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6365), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Header", "TimeCreated", "TimeUpdated" },
                values: new object[] { null, new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2326), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2325), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2004), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2003), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2008), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2008), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2248), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2247), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2252), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeCreated",
                value: new DateTimeOffset(new DateTime(2023, 2, 8, 11, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2297), new TimeSpan(0, 1, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeCreated",
                value: new DateTimeOffset(new DateTime(2023, 2, 8, 11, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, 1, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2273), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2273), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2277), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 49, 11, 291, DateTimeKind.Unspecified).AddTicks(2276), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
