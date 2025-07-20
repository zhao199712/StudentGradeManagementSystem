using StudentGradeManagementSystem.Domain.POCO;

namespace StudentGradeManagementSystem.Domain.Logic
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAll();
        Course? GetById(int id);
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}