namespace StudentGradeManagementSystem.Presentation.ViewModels
{
    public class GradeViewModel
    {
        public int Id { get; set; }
        public double Score { get; set; }

        // 若 UI 有下拉選擇，可儲存這些 ID
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public string? StudentName { get; set; }
        public string? CourseName { get; set; }
    }
}