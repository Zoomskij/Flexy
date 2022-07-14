﻿// <auto-generated />
using System;
using Flexy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Flexy.Data.Migrations
{
    [DbContext(typeof(FlexyContext))]
    [Migration("20220714074544_avatar")]
    partial class avatar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Flexy.Entities.Achievment", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Achievments");
                });

            modelBuilder.Entity("Flexy.Entities.CourseEntity", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GoalGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("GoalGuid");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Flexy.Entities.Diary", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.ToTable("Diaries");
                });

            modelBuilder.Entity("Flexy.Entities.DiaryComment", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DiaryCommentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DiaryGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Guid");

                    b.HasIndex("DiaryCommentGuid");

                    b.HasIndex("DiaryGuid");

                    b.HasIndex("UserId");

                    b.ToTable("DiaryComments");
                });

            modelBuilder.Entity("Flexy.Entities.DiaryCommentLike", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DiaryCommentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Reaction")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Guid");

                    b.HasIndex("DiaryCommentGuid");

                    b.HasIndex("UserId");

                    b.ToTable("DiaryCommentLikes");
                });

            modelBuilder.Entity("Flexy.Entities.Goal", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("OwnerId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("Flexy.Entities.GroupEntity", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("CourseGuid");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Flexy.Entities.LessonEntity", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GoalGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("CourseGuid");

                    b.HasIndex("GoalGuid");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Flexy.Entities.Meeting", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMetro")
                        .HasColumnType("bit");

                    b.Property<string>("Metro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("OwnerId");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Flexy.Entities.Note", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("StudentGuid");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Flexy.Entities.NotifyEntity", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Notifies");
                });

            modelBuilder.Entity("Flexy.Entities.Person", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Flexy.Entities.PersonPhraseEntity", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Phrase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("PersonPhrases");
                });

            modelBuilder.Entity("Flexy.Entities.Scenario", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Command")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ParrentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Guid");

                    b.ToTable("Scenarios");
                });

            modelBuilder.Entity("Flexy.Entities.StudentAchievment", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AchievmentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("StudentEntityGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("AchievmentGuid");

                    b.HasIndex("StudentEntityGuid");

                    b.ToTable("StudentAchievments");
                });

            modelBuilder.Entity("Flexy.Entities.StudentCourseId", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.ToTable("StudentCourseIds");
                });

            modelBuilder.Entity("Flexy.Entities.StudentEntity", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ActiveScenarioGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GoalGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("GoalGuid");

                    b.HasIndex("GroupGuid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Flexy.Entities.StudentLessonId", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<Guid>("LessonGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentCourseIdGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("StudentCourseIdGuid");

                    b.ToTable("StudentLessonIds");
                });

            modelBuilder.Entity("Flexy.Entities.StudentNotifyIds", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("NotifyGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.ToTable("StudentNotifyIds");
                });

            modelBuilder.Entity("Flexy.Entities.StudentPersonIds", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.ToTable("StudentPersonIds");
                });

            modelBuilder.Entity("Flexy.Entities.StudentTaskId", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<Guid>("StudentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StudentLessonIdGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TaskGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("StudentLessonIdGuid");

                    b.ToTable("StudentTaskIds");
                });

            modelBuilder.Entity("Flexy.Entities.TaskEntity", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GoalGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LessonGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("GoalGuid");

                    b.HasIndex("LessonGuid");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Flexy.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DiaryGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MeetingGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiaryGuid");

                    b.HasIndex("MeetingGuid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Flexy.Entities.CourseEntity", b =>
                {
                    b.HasOne("Flexy.Entities.Goal", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalGuid");

                    b.Navigation("Goal");
                });

            modelBuilder.Entity("Flexy.Entities.DiaryComment", b =>
                {
                    b.HasOne("Flexy.Entities.DiaryComment", null)
                        .WithMany("Answers")
                        .HasForeignKey("DiaryCommentGuid");

                    b.HasOne("Flexy.Entities.Diary", null)
                        .WithMany("Comment")
                        .HasForeignKey("DiaryGuid");

                    b.HasOne("Flexy.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Flexy.Entities.DiaryCommentLike", b =>
                {
                    b.HasOne("Flexy.Entities.DiaryComment", "DiaryComment")
                        .WithMany()
                        .HasForeignKey("DiaryCommentGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Flexy.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("DiaryComment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Flexy.Entities.Goal", b =>
                {
                    b.HasOne("Flexy.Entities.User", "Owner")
                        .WithMany("Goals")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Flexy.Entities.GroupEntity", b =>
                {
                    b.HasOne("Flexy.Entities.CourseEntity", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CourseGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Flexy.Entities.LessonEntity", b =>
                {
                    b.HasOne("Flexy.Entities.CourseEntity", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Flexy.Entities.Goal", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalGuid");

                    b.Navigation("Course");

                    b.Navigation("Goal");
                });

            modelBuilder.Entity("Flexy.Entities.Meeting", b =>
                {
                    b.HasOne("Flexy.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Flexy.Entities.Note", b =>
                {
                    b.HasOne("Flexy.Entities.StudentEntity", "Student")
                        .WithMany("Notes")
                        .HasForeignKey("StudentGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Flexy.Entities.StudentAchievment", b =>
                {
                    b.HasOne("Flexy.Entities.Achievment", "Achievment")
                        .WithMany()
                        .HasForeignKey("AchievmentGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Flexy.Entities.StudentEntity", null)
                        .WithMany("StudentAchievments")
                        .HasForeignKey("StudentEntityGuid");

                    b.Navigation("Achievment");
                });

            modelBuilder.Entity("Flexy.Entities.StudentEntity", b =>
                {
                    b.HasOne("Flexy.Entities.Goal", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalGuid");

                    b.HasOne("Flexy.Entities.GroupEntity", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupGuid");

                    b.Navigation("Goal");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Flexy.Entities.StudentLessonId", b =>
                {
                    b.HasOne("Flexy.Entities.StudentCourseId", null)
                        .WithMany("StudentLessonIds")
                        .HasForeignKey("StudentCourseIdGuid");
                });

            modelBuilder.Entity("Flexy.Entities.StudentTaskId", b =>
                {
                    b.HasOne("Flexy.Entities.StudentLessonId", null)
                        .WithMany("StudentTaskIds")
                        .HasForeignKey("StudentLessonIdGuid");
                });

            modelBuilder.Entity("Flexy.Entities.TaskEntity", b =>
                {
                    b.HasOne("Flexy.Entities.Goal", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalGuid");

                    b.HasOne("Flexy.Entities.LessonEntity", "Lesson")
                        .WithMany("Tasks")
                        .HasForeignKey("LessonGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goal");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Flexy.Entities.User", b =>
                {
                    b.HasOne("Flexy.Entities.Diary", "Diary")
                        .WithMany()
                        .HasForeignKey("DiaryGuid");

                    b.HasOne("Flexy.Entities.Meeting", null)
                        .WithMany("Users")
                        .HasForeignKey("MeetingGuid");

                    b.Navigation("Diary");
                });

            modelBuilder.Entity("Flexy.Entities.CourseEntity", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("Flexy.Entities.Diary", b =>
                {
                    b.Navigation("Comment");
                });

            modelBuilder.Entity("Flexy.Entities.DiaryComment", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Flexy.Entities.GroupEntity", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Flexy.Entities.LessonEntity", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Flexy.Entities.Meeting", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Flexy.Entities.StudentCourseId", b =>
                {
                    b.Navigation("StudentLessonIds");
                });

            modelBuilder.Entity("Flexy.Entities.StudentEntity", b =>
                {
                    b.Navigation("Notes");

                    b.Navigation("StudentAchievments");
                });

            modelBuilder.Entity("Flexy.Entities.StudentLessonId", b =>
                {
                    b.Navigation("StudentTaskIds");
                });

            modelBuilder.Entity("Flexy.Entities.User", b =>
                {
                    b.Navigation("Goals");
                });
#pragma warning restore 612, 618
        }
    }
}
