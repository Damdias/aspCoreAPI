using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Contoso.Domain.Entities;

namespace ContosoUniversity.Data
{
    public class SchoolContext:IdentityDbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Course>().Property(a => a.CourseID).ValueGeneratedNever();
           // modelBuilder.Entity<Iuserlo>
        }
    }
}
