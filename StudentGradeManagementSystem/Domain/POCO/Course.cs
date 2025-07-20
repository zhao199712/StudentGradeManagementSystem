
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentGradeManagementSystem.Domain.POCO
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(1, 10)]
        public int Credit { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }

        public Course()
        {
            Name = string.Empty; // 初始化為空字串
            Grades = new HashSet<Grade>(); // 初始化為空的 HashSet
        }
    }
}
