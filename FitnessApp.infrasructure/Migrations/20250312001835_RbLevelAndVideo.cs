using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.infrasructure.Migrations
{
    /// <inheritdoc />
    public partial class RbLevelAndVideo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Videos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Videos_LevelId",
                table: "Videos",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Levels_LevelId",
                table: "Videos",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Levels_LevelId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Videos_LevelId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Videos");
        }
    }
}
