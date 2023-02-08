using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMMVC.Infrastructure.Migrations
{
    public partial class AddFreelancerIdToProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Freelancers_Projects_ProjectId",
                table: "Freelancers");

            migrationBuilder.DropIndex(
                name: "IX_Freelancers_ProjectId",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Freelancers");

            migrationBuilder.AddColumn<long>(
                name: "FreelancerId",
                table: "Projects",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(207), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(206), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(215), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(214), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9651), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9649), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "GenderCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9657), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9656), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9983), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9981), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "HubbyCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9987), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 575, DateTimeKind.Unspecified).AddTicks(9987), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "FreelancerId", "TimeCreated" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2023, 2, 8, 13, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(58), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Documentation", "FreelancerId", "Name", "TimeCreated" },
                values: new object[] { "Analytics of the sales of XYZ company", 1L, "Data Analytics", new DateTimeOffset(new DateTime(2023, 2, 8, 13, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(65), new TimeSpan(0, 1, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Documentation", "FreelancerId", "Name", "TimeCreated", "TimeUpdated" },
                values: new object[] { 3L, "E-commerce (electronic commerce) is the buying and selling of goods and services, or the transmitting of funds or data, over an electronic network, primarily the internet. These business transactions occur either as business-to-business (B2B), business-to-consumer (B2C), consumer-to-consumer or consumer-to-business.", 2L, "Ecommerce", new DateTimeOffset(new DateTime(2023, 2, 8, 13, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(68), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(22), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(21), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "SkillCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "TimeCreated", "TimeUpdated" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(28), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 12, 57, 31, 576, DateTimeKind.Unspecified).AddTicks(27), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_FreelancerId",
                table: "Projects",
                column: "FreelancerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Freelancers_FreelancerId",
                table: "Projects",
                column: "FreelancerId",
                principalTable: "Freelancers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Freelancers_FreelancerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_FreelancerId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DropColumn(
                name: "FreelancerId",
                table: "Projects");

            migrationBuilder.AddColumn<long>(
                name: "ProjectId",
                table: "Freelancers",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ProjectId", "TimeCreated", "TimeUpdated" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6413), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ProjectId", "TimeCreated", "TimeUpdated" },
                values: new object[] { 2L, new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6419), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 2, 8, 10, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6418), new TimeSpan(0, 0, 0, 0, 0)) });

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
                columns: new[] { "Documentation", "Name", "TimeCreated" },
                values: new object[] { "E-commerce (electronic commerce) is the buying and selling of goods and services, or the transmitting of funds or data, over an electronic network, primarily the internet. These business transactions occur either as business-to-business (B2B), business-to-consumer (B2C), consumer-to-consumer or consumer-to-business.", "Ecommerce", new DateTimeOffset(new DateTime(2023, 2, 8, 11, 51, 17, 739, DateTimeKind.Unspecified).AddTicks(6385), new TimeSpan(0, 1, 0, 0, 0)) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_ProjectId",
                table: "Freelancers",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Freelancers_Projects_ProjectId",
                table: "Freelancers",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
