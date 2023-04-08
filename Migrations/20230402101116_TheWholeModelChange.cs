using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SFMS.Migrations
{
    public partial class TheWholeModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {   migrationBuilder.CreateTable(
                name: "FinePolicy",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Ip = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rule = table.Column<string>(nullable: true),
                    FineAmount = table.Column<int>(nullable: false),
                    FineAfterMinutes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinePolicy", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "FineTransition",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Ip = table.Column<string>(nullable: true),
                    FinedDate = table.Column<DateTime>(nullable: false),
                    FineAmount = table.Column<int>(nullable: false),
                    InTime = table.Column<string>(nullable: true),
                    OutTime = table.Column<string>(nullable: true),
                    FinePolicyId = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FineTransition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FineTransition_FinePolicy_FinePolicyId",
                        column: x => x.FinePolicyId,
                        principalTable: "FinePolicy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FineTransition_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_FineTransition_FinePolicyId",
                table: "FineTransition",
                column: "FinePolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_FineTransition_StudentId",
                table: "FineTransition",
                column: "StudentId");

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.DropTable(
                name: "FineTransition");


            migrationBuilder.DropTable(
                name: "FinePolicy");

        }
    }
}
