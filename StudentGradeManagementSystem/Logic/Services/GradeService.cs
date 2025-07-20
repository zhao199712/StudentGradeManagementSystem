using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using StudentGradeManagementSystem.Domain.Repository;
using StudentGradeManagementSystem.Domain.Strategy; // 要引入命名空間

namespace StudentGradeManagementSystem.Logic.Services
{
   
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _gradeRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IGradingStrategy _gradingStrategy; // << 新增欄位

        public GradeService(
            IGradeRepository gradeRepository,
            IStudentRepository studentRepository,
            ICourseRepository courseRepository,
            Func<string, IGradingStrategy> gradingStrategyFactory)
        {
            _gradeRepository = gradeRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;

            // 暫時硬編策略型別（你也可以改為來自 config 或 UI）
            _gradingStrategy = gradingStrategyFactory("traditional");
        }

        // 查詢功能
        public IEnumerable<Grade> GetGradesByStudent(int studentId) =>
            _gradeRepository.GetAll().Where(g => g.StudentId == studentId).ToList();

        public IEnumerable<Grade> GetGradesByCourse(int courseId) =>
            _gradeRepository.GetAll().Where(g => g.CourseId == courseId).ToList();

        // 統計功能
        public double CalculateAverage(int studentId)
        {
            var grades = GetGradesByStudent(studentId);
            return grades.Any() ? grades.Average(g => g.Score) : 0.0;
        }

        public int CalculateRank(int studentId)
        {
            var allStudents = _studentRepository.GetAll();
            var studentAverages = allStudents
                .Select(s => (s.Id, AverageScore: CalculateAverage(s.Id)))
                .ToList();

            var sorted = studentAverages.OrderByDescending(s => s.AverageScore).ToList();
            var target = sorted.FirstOrDefault(s => s.Id == studentId);

            if (target.Id == 0 && target.AverageScore == 0.0) return -1;
            return sorted.FindIndex(s => s.Id == studentId) + 1;
        }

        // 使用策略模式重構評分邏輯
        public string GetLetterGrade(double score)
        {
            var allScores = _gradeRepository.GetAll().Select(g => g.Score);
            return _gradingStrategy.GetLetterGrade(score, allScores);
        }

        public bool IsPassing(Grade grade)
        {
            return _gradingStrategy.IsPassing(grade.Score);
        }

        // 寫入/更新功能
        public void AddGrade(Grade grade) => _gradeRepository.Add(grade);
        public void UpdateGrade(Grade grade) => _gradeRepository.Update(grade);
        public void DeleteGrade(int id) => _gradeRepository.Delete(id);
    }
}