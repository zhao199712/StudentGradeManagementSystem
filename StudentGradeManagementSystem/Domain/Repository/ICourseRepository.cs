using StudentGradeManagementSystem.Domain.POCO;

namespace StudentGradeManagementSystem.Domain.Repository;

public interface ICourseRepository
{
    IEnumerable<Course> GetAll();
    Course? GetById(int id);
    void Add(Course course);
    void Update(Course course);
    void Delete(int id);
}