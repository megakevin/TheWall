using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TheWall.Model
{    
    public partial class TheWallEntities : DbContext
    {
        public TheWallEntities()
            //: base("name=TheWallEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<FeedbackReason> FeedbackReasons { get; set; }
    }
}
