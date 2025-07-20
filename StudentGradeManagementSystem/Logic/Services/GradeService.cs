using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using StudentGradeManagementSystem.Domain.Repository; // Add this for IGradeRepository, IStudentRepository, ICourseRepository

namespace StudentGradeManagementSystem.Logic.Services
{
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _gradeRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;

        public GradeService(IGradeRepository gradeRepository, IStudentRepository studentRepository, ICourseRepository courseRepository)
        {
            _gradeRepository = gradeRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        // 查詢功能
        public IEnumerable<Grade> GetGradesByStudent(int studentId)
        {
            return _gradeRepository.GetAll().Where(g => g.StudentId == studentId).ToList();
        }

        public IEnumerable<Grade> GetGradesByCourse(int courseId)
        {
            return _gradeRepository.GetAll().Where(g => g.CourseId == courseId).ToList();
        }

        // 統計功能
        public double CalculateAverage(int studentId)
        {
            var grades = GetGradesByStudent(studentId);
            if (!grades.Any())
            {
                return 0.0; // 如果沒有成績，平均為 0
            }
            return grades.Average(g => g.Score);
        }

        public int CalculateRank(int studentId)
        {
            // 獲取所有學生的平均成績
            var allStudents = _studentRepository.GetAll();
            var studentAverages = new List<(int StudentId, double AverageScore)>();

            foreach (var student in allStudents)
            {
                studentAverages.Add((student.Id, CalculateAverage(student.Id)));
            }

            // 根據平均成績降序排序
            var sortedAverages = studentAverages.OrderByDescending(sa => sa.AverageScore).ToList();

            // 找到目標學生的排名
            var targetStudentAverage = sortedAverages.FirstOrDefault(sa => sa.StudentId == studentId);

            if (targetStudentAverage.StudentId == 0 && targetStudentAverage.AverageScore == 0.0) // Student not found or no grades
            {
                return -1; // 表示學生不存在或沒有成績，無法排名
            }

            // 排名從 1 開始
            return sortedAverages.FindIndex(sa => sa.StudentId == studentId) + 1;
        }

        // 商業邏輯
        public bool IsPassing(Grade grade)
        {
            // 假設及格分數為 60
            return grade.Score >= 60;
        }

        public string GetLetterGrade(double score)
        {
            if (score >= 90) return "A";
            if (score >= 80) return "B";
            if (score >= 70) return "C";
            if (score >= 60) return "D";
            return "F";
        }

        // 寫入/更新功能
        public void AddGrade(Grade grade)
        {
            _gradeRepository.Add(grade);
        }

        public void UpdateGrade(Grade grade)
        {
            _gradeRepository.Update(grade);
        }

        public void DeleteGrade(int id)
        {
            _gradeRepository.Delete(id);
        }
    }
}