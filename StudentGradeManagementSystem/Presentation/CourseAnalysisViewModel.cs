namespace StudentGradeManagementSystem.Presentation.ViewModels
{
    public class CourseAnalysisViewModel
    {
        public string? StudentName { get; set; }
        public string? CourseName { get; set; } // New property
        public double Score { get; set; }
        public string? Status { get; set; } // 及格/未及格
    }
}
