using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWall.Model.Entities
{
    public class TheWallContext : DbContext
    {
        public TheWallContext()
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
