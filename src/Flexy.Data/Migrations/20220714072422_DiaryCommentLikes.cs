using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexy.Data.Migrations
{
    public partial class DiaryCommentLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiaryComment_Diary_DiaryGuid",
                table: "DiaryComment");

            migrationBuilder.DropForeignKey(
                name: "FK_DiaryComment_DiaryComment_DiaryCommentGuid",
                table: "DiaryComment");

            migrationBuilder.DropForeignKey(
                name: "FK_DiaryComment_Users_UserId",
                table: "DiaryComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Diary_DiaryGuid",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiaryComment",
                table: "DiaryComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diary",
                table: "Diary");

            migrationBuilder.RenameTable(
                name: "DiaryComment",
                newName: "DiaryComments");

            migrationBuilder.RenameTable(
                name: "Diary",
                newName: "Diaries");

            migrationBuilder.RenameIndex(
                name: "IX_DiaryComment_UserId",
                table: "DiaryComments",
                newName: "IX_DiaryComments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DiaryComment_DiaryGuid",
                table: "DiaryComments",
                newName: "IX_DiaryComments_DiaryGuid");

            migrationBuilder.RenameIndex(
                name: "IX_DiaryComment_DiaryCommentGuid",
                table: "DiaryComments",
                newName: "IX_DiaryComments_DiaryCommentGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiaryComments",
                table: "DiaryComments",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries",
                column: "Guid");

            migrationBuilder.CreateTable(
                name: "DiaryCommentLikes",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DiaryCommentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reaction = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryCommentLikes", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_DiaryCommentLikes_DiaryComments_DiaryCommentGuid",
                        column: x => x.DiaryCommentGuid,
                        principalTable: "DiaryComments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiaryCommentLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiaryCommentLikes_DiaryCommentGuid",
                table: "DiaryCommentLikes",
                column: "DiaryCommentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_DiaryCommentLikes_UserId",
                table: "DiaryCommentLikes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiaryComments_Diaries_DiaryGuid",
                table: "DiaryComments",
                column: "DiaryGuid",
                principalTable: "Diaries",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_DiaryComments_DiaryComments_DiaryCommentGuid",
                table: "DiaryComments",
                column: "DiaryCommentGuid",
                principalTable: "DiaryComments",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_DiaryComments_Users_UserId",
                table: "DiaryComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Diaries_DiaryGuid",
                table: "Users",
                column: "DiaryGuid",
                principalTable: "Diaries",
                principalColumn: "Guid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiaryComments_Diaries_DiaryGuid",
                table: "DiaryComments");

            migrationBuilder.DropForeignKey(
                name: "FK_DiaryComments_DiaryComments_DiaryCommentGuid",
                table: "DiaryComments");

            migrationBuilder.DropForeignKey(
                name: "FK_DiaryComments_Users_UserId",
                table: "DiaryComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Diaries_DiaryGuid",
                table: "Users");

            migrationBuilder.DropTable(
                name: "DiaryCommentLikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiaryComments",
                table: "DiaryComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diaries",
                table: "Diaries");

            migrationBuilder.RenameTable(
                name: "DiaryComments",
                newName: "DiaryComment");

            migrationBuilder.RenameTable(
                name: "Diaries",
                newName: "Diary");

            migrationBuilder.RenameIndex(
                name: "IX_DiaryComments_UserId",
                table: "DiaryComment",
                newName: "IX_DiaryComment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DiaryComments_DiaryGuid",
                table: "DiaryComment",
                newName: "IX_DiaryComment_DiaryGuid");

            migrationBuilder.RenameIndex(
                name: "IX_DiaryComments_DiaryCommentGuid",
                table: "DiaryComment",
                newName: "IX_DiaryComment_DiaryCommentGuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiaryComment",
                table: "DiaryComment",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diary",
                table: "Diary",
                column: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_DiaryComment_Diary_DiaryGuid",
                table: "DiaryComment",
                column: "DiaryGuid",
                principalTable: "Diary",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_DiaryComment_DiaryComment_DiaryCommentGuid",
                table: "DiaryComment",
                column: "DiaryCommentGuid",
                principalTable: "DiaryComment",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_DiaryComment_Users_UserId",
                table: "DiaryComment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Diary_DiaryGuid",
                table: "Users",
                column: "DiaryGuid",
                principalTable: "Diary",
                principalColumn: "Guid");
        }
    }
}
