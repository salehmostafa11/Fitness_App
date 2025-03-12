using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.infrasructure.Migrations
{
    /// <inheritdoc />
    public partial class RbTraineeAndTraineer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Trainees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_TrainerId",
                table: "Trainees",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Trainers_TrainerId",
                table: "Trainees",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Trainers_TrainerId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_TrainerId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Trainees");
        }
    }
}
