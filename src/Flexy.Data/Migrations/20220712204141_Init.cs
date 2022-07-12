using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexy.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievments", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Notifies",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifies", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "PersonPhrases",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Phrase = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPhrases", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Scenarios",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParrentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Command = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseIds",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseIds", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "StudentNotifyIds",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotifyGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentNotifyIds", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "StudentPersonIds",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPersonIds", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoalGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Courses_Goals_GoalGuid",
                        column: x => x.GoalGuid,
                        principalTable: "Goals",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "StudentLessonIds",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    StudentCourseIdGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLessonIds", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_StudentLessonIds_StudentCourseIds_StudentCourseIdGuid",
                        column: x => x.StudentCourseIdGuid,
                        principalTable: "StudentCourseIds",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Groups_Courses_CourseGuid",
                        column: x => x.CourseGuid,
                        principalTable: "Courses",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Lessons_Courses_CourseGuid",
                        column: x => x.CourseGuid,
                        principalTable: "Courses",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Goals_GoalGuid",
                        column: x => x.GoalGuid,
                        principalTable: "Goals",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "StudentTaskIds",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    StudentLessonIdGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTaskIds", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_StudentTaskIds_StudentLessonIds_StudentLessonIdGuid",
                        column: x => x.StudentLessonIdGuid,
                        principalTable: "StudentLessonIds",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChatId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GoalGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActiveScenarioGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Students_Goals_GoalGuid",
                        column: x => x.GoalGuid,
                        principalTable: "Goals",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupGuid",
                        column: x => x.GroupGuid,
                        principalTable: "Groups",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoalGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Tasks_Goals_GoalGuid",
                        column: x => x.GoalGuid,
                        principalTable: "Goals",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_Tasks_Lessons_LessonGuid",
                        column: x => x.LessonGuid,
                        principalTable: "Lessons",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Notes_Students_StudentGuid",
                        column: x => x.StudentGuid,
                        principalTable: "Students",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAchievments",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AchievmentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentEntityGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAchievments", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_StudentAchievments_Achievments_AchievmentGuid",
                        column: x => x.AchievmentGuid,
                        principalTable: "Achievments",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAchievments_Students_StudentEntityGuid",
                        column: x => x.StudentEntityGuid,
                        principalTable: "Students",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_GoalGuid",
                table: "Courses",
                column: "GoalGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CourseGuid",
                table: "Groups",
                column: "CourseGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseGuid",
                table: "Lessons",
                column: "CourseGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GoalGuid",
                table: "Lessons",
                column: "GoalGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_StudentGuid",
                table: "Notes",
                column: "StudentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAchievments_AchievmentGuid",
                table: "StudentAchievments",
                column: "AchievmentGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAchievments_StudentEntityGuid",
                table: "StudentAchievments",
                column: "StudentEntityGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLessonIds_StudentCourseIdGuid",
                table: "StudentLessonIds",
                column: "StudentCourseIdGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GoalGuid",
                table: "Students",
                column: "GoalGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupGuid",
                table: "Students",
                column: "GroupGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTaskIds_StudentLessonIdGuid",
                table: "StudentTaskIds",
                column: "StudentLessonIdGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_GoalGuid",
                table: "Tasks",
                column: "GoalGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_LessonGuid",
                table: "Tasks",
                column: "LessonGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Notifies");

            migrationBuilder.DropTable(
                name: "PersonPhrases");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Scenarios");

            migrationBuilder.DropTable(
                name: "StudentAchievments");

            migrationBuilder.DropTable(
                name: "StudentNotifyIds");

            migrationBuilder.DropTable(
                name: "StudentPersonIds");

            migrationBuilder.DropTable(
                name: "StudentTaskIds");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Achievments");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentLessonIds");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "StudentCourseIds");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Goals");
        }
    }
}
