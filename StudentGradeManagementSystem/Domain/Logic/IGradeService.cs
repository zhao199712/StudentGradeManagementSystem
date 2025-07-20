namespace StudentGradeManagementSystem.Logic;

public interface IGradeService
{
    double CalculateAverage(int studentId);
    int CalculateRank(int studentId);  // 延後實作
    IEnumerable<Grade> GetGrades(int studentId);
}