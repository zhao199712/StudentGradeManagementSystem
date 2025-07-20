using Microsoft.EntityFrameworkCore;
using StudentGradeManagementSystem.Domain.POCO;
using StudentGradeManagementSystem.Domain.Repository;
using StudentGradeManagementSystem.Data.EF;

namespace StudentGradeManagementSystem.Data.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly ApplicationDbContext _context;

        public GradeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Grade> GetAll()
        {
            return _context.Grades.ToList();
        }

        public IEnumerable<Grade> GetByStudentId(int studentId)
        {
            return _context.Grades
                .Where(g => g.StudentId == studentId)
                .Include(g => g.Course) // 若有導航屬性可載入課程資訊
                .ToList();
        }

        public Grade? GetById(int id)
        {
            return _context.Grades.Find(id);
        }

        public void Add(Grade grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();
        }

        public void Update(Grade grade)
        {
            _context.Grades.Update(grade);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var grade = _context.Grades.Find(id);
            if (grade != null)
            {
                _context.Grades.Remove(grade);
                _context.SaveChanges();
            }
        }
    }
}