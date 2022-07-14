using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexy.Data.Migrations
{
    public partial class DIary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DiaryGuid",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Diary",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diary", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "DiaryComment",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaryCommentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiaryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryComment", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_DiaryComment_Diary_DiaryGuid",
                        column: x => x.DiaryGuid,
                        principalTable: "Diary",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_DiaryComment_DiaryComment_DiaryCommentGuid",
                        column: x => x.DiaryCommentGuid,
                        principalTable: "DiaryComment",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_DiaryComment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DiaryGuid",
                table: "Users",
                column: "DiaryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_DiaryComment_DiaryCommentGuid",
                table: "DiaryComment",
                column: "DiaryCommentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_DiaryComment_DiaryGuid",
                table: "DiaryComment",
                column: "DiaryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_DiaryComment_UserId",
                table: "DiaryComment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Diary_DiaryGuid",
                table: "Users",
                column: "DiaryGuid",
                principalTable: "Diary",
                principalColumn: "Guid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Diary_DiaryGuid",
                table: "Users");

            migrationBuilder.DropTable(
                name: "DiaryComment");

            migrationBuilder.DropTable(
                name: "Diary");

            migrationBuilder.DropIndex(
                name: "IX_Users_DiaryGuid",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DiaryGuid",
                table: "Users");
        }
    }
}
