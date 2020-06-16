using Microsoft.EntityFrameworkCore;
using np.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace np
{
    public class NPContext : DbContext
    {
        public NPContext(DbContextOptions<NPContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(p => p.UserId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Course>()
                .Property(p => p.CourseId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserCourse>().HasKey(x => new { x.UserId, x.CourseId });

            modelBuilder.Entity<UserCourse>()
                .HasOne<User>(uc => uc.User)
                .WithMany(u => u.UserCourses)
                .HasForeignKey(uc => uc.UserId);


            modelBuilder.Entity<UserCourse>()
                .HasOne<Course>(uc => uc.Course)
                .WithMany(c => c.UserCourses)
                .HasForeignKey(uc => uc.CourseId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }
    }
}
