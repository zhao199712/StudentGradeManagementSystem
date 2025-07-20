namespace StudentGradeManagementSystem.Presentation.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

        public string Display => $"{Name} ({Credit} 學分)";
    }
}