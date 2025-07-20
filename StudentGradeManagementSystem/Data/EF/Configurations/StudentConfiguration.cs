using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentGradeManagementSystem.Domain.POCO;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> entity)
    {
        entity.ToTable("Students");

        entity.HasKey(s => s.Id);

        entity.Property(s => s.Id)
            .ValueGeneratedOnAdd()
            .HasColumnType("int");

        entity.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("nvarchar(50)");

        entity.Property(s => s.ClassName)
            .IsRequired()
            .HasMaxLength(50)
            .HasColumnType("nvarchar(50)");

        entity.HasMany(s => s.Grades)
            .WithOne(g => g.Student)
            .HasForeignKey(g => g.StudentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}