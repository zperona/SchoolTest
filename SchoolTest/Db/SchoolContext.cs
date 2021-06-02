using Microsoft.EntityFrameworkCore;
using SchoolTest.Models;

namespace SchoolTest.Db
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions options) :
           base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
