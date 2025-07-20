using StudentGradeManagementSystem.Domain.POCO;

namespace StudentGradeManagementSystem.Domain.Repository;

public interface IGradeRepository
{
    IEnumerable<Grade> GetAll();
    IEnumerable<Grade> GetByStudentId(int studentId);
    void Add(Grade grade);
    void Update(Grade grade);
    void Delete(int id);
}