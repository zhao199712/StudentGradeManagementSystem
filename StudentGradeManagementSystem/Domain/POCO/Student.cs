
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagementSystem.Domain.POCO
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }

        public Student()
        {
            Name = string.Empty;
            ClassName = string.Empty;
            Grades = new HashSet<Grade>();
        }
    }
}
