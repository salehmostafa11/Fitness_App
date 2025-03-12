using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.infrasructure.Migrations
{
    /// <inheritdoc />
    public partial class RbLevelAndNutritionPlans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionPlans_LevelId",
                table: "NutritionPlans",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionPlans_Levels_LevelId",
                table: "NutritionPlans",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionPlans_Levels_LevelId",
                table: "NutritionPlans");

            migrationBuilder.DropIndex(
                name: "IX_NutritionPlans_LevelId",
                table: "NutritionPlans");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "NutritionPlans");
        }
    }
}
