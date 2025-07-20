using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using StudentGradeManagementSystem.Domain.Repository;

namespace StudentGradeManagementSystem.Logic.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAll() => _studentRepository.GetAll();

        public Student? GetById(int id) => _studentRepository.GetById(id);

        public void Add(Student student) => _studentRepository.Add(student);

        public void Update(Student student) => _studentRepository.Update(student);

        public void Delete(int id) => _studentRepository.Delete(id);
    }
}