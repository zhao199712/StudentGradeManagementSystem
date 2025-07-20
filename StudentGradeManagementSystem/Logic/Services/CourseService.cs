using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using StudentGradeManagementSystem.Domain.Repository;

namespace StudentGradeManagementSystem.Logic.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAll() => _courseRepository.GetAll();

        public Course? GetById(int id) => _courseRepository.GetById(id);

        public void Add(Course course) => _courseRepository.Add(course);

        public void Update(Course course) => _courseRepository.Update(course);

        public void Delete(int id) => _courseRepository.Delete(id);
    }
}