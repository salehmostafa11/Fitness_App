using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.infrasructure.Migrations
{
    /// <inheritdoc />
    public partial class RbNutritionistAndNutritionPlans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NutritionistId",
                table: "NutritionPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NutritionPlans_NutritionistId",
                table: "NutritionPlans",
                column: "NutritionistId");

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionPlans_Nutritionists_NutritionistId",
                table: "NutritionPlans",
                column: "NutritionistId",
                principalTable: "Nutritionists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionPlans_Nutritionists_NutritionistId",
                table: "NutritionPlans");

            migrationBuilder.DropIndex(
                name: "IX_NutritionPlans_NutritionistId",
                table: "NutritionPlans");

            migrationBuilder.DropColumn(
                name: "NutritionistId",
                table: "NutritionPlans");
        }
    }
}
