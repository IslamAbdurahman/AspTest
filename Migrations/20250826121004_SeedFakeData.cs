using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspTest.Migrations
{
    /// <inheritdoc />
    public partial class SeedFakeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "CreatedAt", "IsActive", "QuestionText" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 1?" },
                    { 2L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 2?" },
                    { 3L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 3?" },
                    { 4L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 4?" },
                    { 5L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 5?" },
                    { 6L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 6?" },
                    { 7L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 7?" },
                    { 8L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 8?" },
                    { 9L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 9?" },
                    { 10L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 10?" },
                    { 11L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 11?" },
                    { 12L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 12?" },
                    { 13L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 13?" },
                    { 14L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 14?" },
                    { 15L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 15?" },
                    { 16L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 16?" },
                    { 17L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 17?" },
                    { 18L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 18?" },
                    { 19L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 19?" },
                    { 20L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Question 20?" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "CreatedAt", "IsCorrect", "OptionText", "TestId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 1", 1L },
                    { 2L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 1L },
                    { 3L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 1L },
                    { 4L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 1L },
                    { 5L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 2L },
                    { 6L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 2", 2L },
                    { 7L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 2L },
                    { 8L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 2L },
                    { 9L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 3L },
                    { 10L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 3L },
                    { 11L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 3", 3L },
                    { 12L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 3L },
                    { 13L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 4L },
                    { 14L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 4L },
                    { 15L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 4L },
                    { 16L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 4", 4L },
                    { 17L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 1", 5L },
                    { 18L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 5L },
                    { 19L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 5L },
                    { 20L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 5L },
                    { 21L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 6L },
                    { 22L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 2", 6L },
                    { 23L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 6L },
                    { 24L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 6L },
                    { 25L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 7L },
                    { 26L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 7L },
                    { 27L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 3", 7L },
                    { 28L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 7L },
                    { 29L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 8L },
                    { 30L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 8L },
                    { 31L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 8L },
                    { 32L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 4", 8L },
                    { 33L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 1", 9L },
                    { 34L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 9L },
                    { 35L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 9L },
                    { 36L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 9L },
                    { 37L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 10L },
                    { 38L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 2", 10L },
                    { 39L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 10L },
                    { 40L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 10L },
                    { 41L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 11L },
                    { 42L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 11L },
                    { 43L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 3", 11L },
                    { 44L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 11L },
                    { 45L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 12L },
                    { 46L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 12L },
                    { 47L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 12L },
                    { 48L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 4", 12L },
                    { 49L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 1", 13L },
                    { 50L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 13L },
                    { 51L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 13L },
                    { 52L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 13L },
                    { 53L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 14L },
                    { 54L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 2", 14L },
                    { 55L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 14L },
                    { 56L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 14L },
                    { 57L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 15L },
                    { 58L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 15L },
                    { 59L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 3", 15L },
                    { 60L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 15L },
                    { 61L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 16L },
                    { 62L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 16L },
                    { 63L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 16L },
                    { 64L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 4", 16L },
                    { 65L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 1", 17L },
                    { 66L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 17L },
                    { 67L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 17L },
                    { 68L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 17L },
                    { 69L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 18L },
                    { 70L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 2", 18L },
                    { 71L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 18L },
                    { 72L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 18L },
                    { 73L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 19L },
                    { 74L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 19L },
                    { 75L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 3", 19L },
                    { 76L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 4", 19L },
                    { 77L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 1", 20L },
                    { 78L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 2", 20L },
                    { 79L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Option 3", 20L },
                    { 80L, new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Option 4", 20L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 20L);
        }
    }
}
