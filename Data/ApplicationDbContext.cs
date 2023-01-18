using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using Verdon.Core.Base;
using Verdon.Core.Dynamic;
using Verdon.Core.Socical;

namespace Verdon.Data
{
    [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreatedAsync();
            if (Database.GetAppliedMigrationsAsync().Result.Count() == 0)
                Database.MigrateAsync();
        }
        // base models
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<IdentityRole> Role { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<SecurityQuestion> SecurityQuestion { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        // dynamic models
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Lecture> Lecture { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Portfolio> Portfolio { get; set; }
        public virtual DbSet<PrivateAttempt> PrivateAttempt { get; set; }
        public virtual DbSet<PrivateOption> PrivateOption { get; set; }
        public virtual DbSet<PrivateQuiz> PrivateQuiz { get; set; }
        public virtual DbSet<PrivateQuestion> PrivateQuestion { get; set; }
        public virtual DbSet<PrivateQuizResult> PrivateQuizResult { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<Tutorial> Tutorial { get; set; }
        public virtual DbSet<Department> Department { get; set; }

        // socical models
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Conversation> Conversation { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Reaction> Reaction { get; set; }

    }


    [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
    public class QuizDbContext : DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options)
           : base(options)
        {
            Database.EnsureCreatedAsync();
        }

        public virtual DbSet<PrivateAttempt> PrivateAttempt { get; set; }
        public virtual DbSet<PrivateOption> PrivateOption { get; set; }
        public virtual DbSet<PrivateQuiz> PrivateQuiz { get; set; }
        public virtual DbSet<PrivateQuestion> PrivateQuestion { get; set; }
        public virtual DbSet<PrivateQuizResult> PrivateQuizResult { get; set; }
        public virtual DbSet<Track> Track { get; set; }
    }
}
