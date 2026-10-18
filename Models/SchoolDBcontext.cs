using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace School.Models
{
    public class SchoolDBcontext:DbContext
    {
        public SchoolDBcontext()
        {
        }

        public SchoolDBcontext(DbContextOptions<SchoolDBcontext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teacher>()
                .HasOne(d => d.Department)
                .WithMany(t => t.Teachers)
                .HasForeignKey(t => t.DepartmentId);

            modelBuilder.Entity<Subject>()
                .HasOne(i => i.Teacher)
                .WithMany(h => h.Subjects)
                .HasForeignKey(i => i.TeacherId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Classroom)
                .WithMany(u => u.Students)
                .HasForeignKey(s => s.ClassroomId);


            modelBuilder.Entity<Enrollment>()
                .HasOne(r => r.Student)
                .WithMany(y => y.Enrollments)
                .HasForeignKey(r => r.EnrollmentId);


            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Subject)
                .WithMany(y => y.Enrollments)
                .HasForeignKey(e => e.EnrollmentId);


            //data seeding 









        }

        internal async Task FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
