using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexy.Data.Migrations
{
    public partial class goals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Goals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Goals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Goals");
        }
    }
}
