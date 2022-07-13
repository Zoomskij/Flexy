using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexy.Data.Migrations
{
    public partial class goalsUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Goals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goals_OwnerId",
                table: "Goals",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Users_OwnerId",
                table: "Goals",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Users_OwnerId",
                table: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_Goals_OwnerId",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Goals");
        }
    }
}
