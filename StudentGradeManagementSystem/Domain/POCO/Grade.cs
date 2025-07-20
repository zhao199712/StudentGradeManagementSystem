
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagementSystem.Domain.POCO
{
    public class Grade
    {
        public int Id { get; set; }

        [Range(0, 100)]
        public double Score { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        public Grade()
        {
            Student = null!; // Initialize with null! to satisfy nullable reference type check
            Course = null!;  // Initialize with null! to satisfy nullable reference type check
        }
    }
}
