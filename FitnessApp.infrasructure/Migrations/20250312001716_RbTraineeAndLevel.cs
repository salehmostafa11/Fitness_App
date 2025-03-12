using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.infrasructure.Migrations
{
    /// <inheritdoc />
    public partial class RbTraineeAndLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Trainees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_LevelId",
                table: "Trainees",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Levels_LevelId",
                table: "Trainees",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Levels_LevelId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_LevelId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Trainees");
        }
    }
}
