using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETRoadmap.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestConfigurationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_SubTopics_SubTopicId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "SubTopicId",
                table: "Tests",
                newName: "TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_SubTopicId",
                table: "Tests",
                newName: "IX_Tests_TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Topics_TopicId",
                table: "Tests",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Topics_TopicId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Tests",
                newName: "SubTopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_TopicId",
                table: "Tests",
                newName: "IX_Tests_SubTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_SubTopics_SubTopicId",
                table: "Tests",
                column: "SubTopicId",
                principalTable: "SubTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
