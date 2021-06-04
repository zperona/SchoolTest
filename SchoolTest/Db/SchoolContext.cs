using Microsoft.EntityFrameworkCore;
using SchoolTest.Models;
using System;

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

            modelBuilder.Entity<Student>().HasData(
               new Student() { Id = 1, FirstName = "Spongebob", LastName = "Squarepants", DoB = new DateTime(2000, 1, 23), Active = true },
               new Student() { Id = 2, FirstName = "Patrick", LastName = "Starfish", DoB = new DateTime(2001, 4, 12), Active = true }
               );
        }
    }
}
