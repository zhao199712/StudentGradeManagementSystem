using StudentGradeManagementSystem.Domain.POCO;

namespace StudentGradeManagementSystem.Domain.Logic
{
    public interface IGradeService
    {
        // 查詢功能
        IEnumerable<Grade> GetGradesByStudent(int studentId);
        IEnumerable<Grade> GetGradesByCourse(int courseId);

        // 統計功能
        double CalculateAverage(int studentId);
        int CalculateRank(int studentId); // 全班排名

        // 商業邏輯
        bool IsPassing(Grade grade);     // 判斷是否及格
        string GetLetterGrade(double score); // 成績轉換

        // 寫入/更新功能（非必要，看是否要讓 Service 控制）
        void AddGrade(Grade grade);
        void UpdateGrade(Grade grade);
        void DeleteGrade(int id);
    }
}