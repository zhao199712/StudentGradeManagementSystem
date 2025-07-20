using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentGradeManagementSystem.Domain.POCO;

public class GradeConfiguration : IEntityTypeConfiguration<Grade>
{
    public void Configure(EntityTypeBuilder<Grade> entity)
    {
        entity.ToTable("Grades");

        entity.HasKey(g => g.Id);

        entity.Property(g => g.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("int");

        entity.Property(g => g.Score)
            .IsRequired()
            .HasColumnType("float");

        entity.Property(g => g.StudentId)
            .HasColumnType("int");

        entity.Property(g => g.CourseId)
            .HasColumnType("int");

        entity.HasOne(g => g.Student)
            .WithMany(s => s.Grades)
            .HasForeignKey(g => g.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        entity.HasOne(g => g.Course)
            .WithMany(c => c.Grades)
            .HasForeignKey(g => g.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}