using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingDataDiaryEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Watched Snow white and the axe man", new DateTime(2025, 1, 2, 15, 40, 5, 151, DateTimeKind.Local).AddTicks(6760), "Watched a movie" },
                    { 2, "Did an 8km walk", new DateTime(2025, 1, 2, 15, 40, 5, 151, DateTimeKind.Local).AddTicks(7162), "Went for a walk" },
                    { 3, "Visited Hillary to discuss his bricked phone", new DateTime(2025, 1, 2, 15, 40, 5, 151, DateTimeKind.Local).AddTicks(7164), "Visited Hillary" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
