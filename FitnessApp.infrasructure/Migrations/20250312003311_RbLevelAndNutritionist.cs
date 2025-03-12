using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.infrasructure.Migrations
{
    /// <inheritdoc />
    public partial class RbLevelAndNutritionist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Nutritionists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Nutritionists_LevelId",
                table: "Nutritionists",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nutritionists_Levels_LevelId",
                table: "Nutritionists",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nutritionists_Levels_LevelId",
                table: "Nutritionists");

            migrationBuilder.DropIndex(
                name: "IX_Nutritionists_LevelId",
                table: "Nutritionists");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Nutritionists");
        }
    }
}
