using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMMVC.Infrastructure.Migrations
{
    public partial class ModifyProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeUpdated",
                table: "Projects",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "Projects",
                newName: "EndDate");

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3504), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3502), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3514), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3513), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(2705), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(2716), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(2715), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3323), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                column: "EndDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                column: "EndDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                column: "EndDate",
                value: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3377), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3375), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 41, 45, 412, DateTimeKind.Unspecified).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Projects",
                newName: "TimeUpdated");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Projects",
                newName: "TimeCreated");

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9226), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9224), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9236), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9234), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(8577), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(8575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(8586), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(8585), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9040), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9038), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9049), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9046), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                column: "TimeCreated",
                value: new DateTimeOffset(new DateTime(2023, 2, 8, 14, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9149), new TimeSpan(0, 1, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                column: "TimeCreated",
                value: new DateTimeOffset(new DateTime(2023, 2, 8, 14, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9160), new TimeSpan(0, 1, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                column: "TimeCreated",
                value: new DateTimeOffset(new DateTime(2023, 2, 8, 14, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9165), new TimeSpan(0, 1, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9098), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9096), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9105), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 13, 0, 24, 219, DateTimeKind.Unspecified).AddTicks(9104), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
