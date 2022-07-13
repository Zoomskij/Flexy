using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexy.Data.Migrations
{
    public partial class Meetings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MeetingGuid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMetro = table.Column<bool>(type: "bit", nullable: false),
                    Metro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Meetings_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_MeetingGuid",
                table: "Users",
                column: "MeetingGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_OwnerId",
                table: "Meetings",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Meetings_MeetingGuid",
                table: "Users",
                column: "MeetingGuid",
                principalTable: "Meetings",
                principalColumn: "Guid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Meetings_MeetingGuid",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Users_MeetingGuid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MeetingGuid",
                table: "Users");
        }
    }
}
