using Microsoft.EntityFrameworkCore.Migrations;

namespace SFMS.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BatchId",
                table: "Student",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_BatchId",
                table: "Student",
                column: "BatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Batch_BatchId",
                table: "Student",
                column: "BatchId",
                principalTable: "Batch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Batch_BatchId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_BatchId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "Student");
        }
    }
}
