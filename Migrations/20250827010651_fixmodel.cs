using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspTest.Migrations
{
    /// <inheritdoc />
    public partial class fixmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestSessions_Tests_TestId",
                table: "TestSessions");

            migrationBuilder.DropIndex(
                name: "IX_TestSessions_TestId",
                table: "TestSessions");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "TestSessions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TestId",
                table: "TestSessions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TestSessions_TestId",
                table: "TestSessions",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestSessions_Tests_TestId",
                table: "TestSessions",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
