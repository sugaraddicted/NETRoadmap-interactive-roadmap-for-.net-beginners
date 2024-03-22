using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETRoadmap.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTestModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Tests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Tests",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
