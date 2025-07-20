using StudentGradeManagementSystem.Domain.POCO;
using StudentGradeManagementSystem.Presentation.ViewModels;

namespace StudentGradeManagementSystem.Presentation.Mappers
{
    public static class Mapper
    {
        // === Student ===

        public static StudentViewModel ToViewModel(this Student entity) => new()
        {
            Id = entity.Id,
            Name = entity.Name,
            ClassName = entity.ClassName
        };

        public static Student ToEntity(this StudentViewModel vm) => new()
        {
            Id = vm.Id,
            Name = vm.Name,
            ClassName = vm.ClassName
        };

        public static void UpdateFromViewModel(this Student entity, StudentViewModel vm)
        {
            entity.Name = vm.Name;
            entity.ClassName = vm.ClassName;
        }

        // === Course ===

        public static CourseViewModel ToViewModel(this Course entity) => new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Credit = entity.Credit
        };

        public static Course ToEntity(this CourseViewModel vm) => new()
        {
            Id = vm.Id,
            Name = vm.Name,
            Credit = vm.Credit
        };

        public static void UpdateFromViewModel(this Course entity, CourseViewModel vm)
        {
            entity.Name = vm.Name;
            entity.Credit = vm.Credit;
        }

        // === Grade ===

        public static GradeViewModel ToViewModel(this Grade entity) => new()
        {
            Id = entity.Id,
            Score = entity.Score,
            StudentId = entity.StudentId,
            CourseId = entity.CourseId,
            StudentName = entity.Student?.Name,
            CourseName = entity.Course?.Name
        };

        public static Grade ToEntity(this GradeViewModel vm) => new()
        {
            Id = vm.Id,
            Score = vm.Score,
            StudentId = vm.StudentId,
            CourseId = vm.CourseId
        };

        public static void UpdateFromViewModel(this Grade entity, GradeViewModel vm)
        {
            entity.Score = vm.Score;
            entity.StudentId = vm.StudentId;
            entity.CourseId = vm.CourseId;
        }
    }
}