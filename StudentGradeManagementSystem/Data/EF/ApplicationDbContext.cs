using Microsoft.EntityFrameworkCore;
using StudentGradeManagementSystem.Domain.POCO;

namespace StudentGradeManagementSystem.Data.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Grade> Grades => Set<Grade>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 可選：自訂欄位限制與索引，例如：
            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Course>().Property(c => c.Name).IsRequired().HasMaxLength(100);
        }
    }
}