namespace StudentGradeManagementSystem.Repository;

public interface IGradeRepository
{
    IEnumerable<Grade> GetByStudentId(int studentId);
    void Add(Grade grade);
    void Update(Grade grade);
    void Delete(int id);
}