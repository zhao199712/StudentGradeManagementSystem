namespace StudentGradeManagementSystem.Presentation.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }

        public string Display => $"{ClassName} - {Name}";
    }
}