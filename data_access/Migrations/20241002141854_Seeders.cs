using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "StudyYear" },
                values: new object[,]
                {
                    { 1, "Group A", 1 },
                    { 2, "Group B", 2 },
                    { 3, "Group C", 3 },
                    { 4, "Group D", 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AverageGrade", "FullName", "GroupId", "StudyField" },
                values: new object[,]
                {
                    { 1, 4.5m, "Alice Smith", 1, "Computer Science" },
                    { 2, 3.9m, "John Doe", 1, "Computer Science" },
                    { 3, 4.1m, "Emily Clark", 2, "Mechanical Engineering" },
                    { 4, 3.7m, "Michael Johnson", 2, "Mechanical Engineering" },
                    { 5, 4.3m, "Sophia Williams", 3, "Electrical Engineering" },
                    { 6, 4.0m, "Liam Brown", 4, "Physics" },
                    { 7, 3.8m, "Olivia Davis", 4, "Physics" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4);

        }
    }
}
