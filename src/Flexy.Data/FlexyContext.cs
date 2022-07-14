using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Flexy.Entities;

namespace Flexy.Data
{
    public class FlexyContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<StudentPersonIds> StudentPersonIds { get; set; }
        public DbSet<PersonPhraseEntity> PersonPhrases { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<LessonEntity> Lessons { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<NotifyEntity> Notifies { get; set; }
        public DbSet<StudentNotifyIds> StudentNotifyIds { get; set; }
        public DbSet<StudentCourseId> StudentCourseIds { get; set; }
        public DbSet<StudentLessonId> StudentLessonIds { get; set; }
        public DbSet<StudentTaskId> StudentTaskIds { get; set; }
        public DbSet<Achievment> Achievments { get; set; }
        public DbSet<StudentAchievment> StudentAchievments { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<DiaryComment> DiaryComments { get; set; }
        public DbSet<DiaryCommentLike> DiaryCommentLikes { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<UserCharacter> UserCharacters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: move to appsettings.json
            optionsBuilder.UseSqlServer(@"Data Source=SQL8002.site4now.net;Initial Catalog=db_a8a07d_flexy;User Id=db_a8a07d_flexy_admin;Password=Testpass12");
        }

        public FlexyContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}