using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentGradeManagementSystem.Domain.POCO;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> entity)
    {
        entity.ToTable("Courses");

        entity.HasKey(c => c.Id);

        entity.Property(c => c.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("int");

        entity.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnType("nvarchar(100)");

        entity.Property(c => c.Credit)
            .HasColumnType("int");

        entity.HasMany(c => c.Grades)
            .WithOne(g => g.Course)
            .HasForeignKey(g => g.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}