using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NETRoadmap.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RoadmapEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoadmapId",
                table: "Modules",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Roadmap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roadmap", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modules_RoadmapId",
                table: "Modules",
                column: "RoadmapId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Roadmap_RoadmapId",
                table: "Modules",
                column: "RoadmapId",
                principalTable: "Roadmap",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Roadmap_RoadmapId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "Roadmap");

            migrationBuilder.DropIndex(
                name: "IX_Modules_RoadmapId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "RoadmapId",
                table: "Modules");
        }
    }
}
