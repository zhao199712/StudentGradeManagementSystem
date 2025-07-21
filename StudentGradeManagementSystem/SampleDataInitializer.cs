using Autofac;
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManagementSystem
{
    public class SampleDataInitializer
    {
        public static void Initialize(ILifetimeScope container)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var studentService = scope.Resolve<IStudentService>();
                var courseService = scope.Resolve<ICourseService>();
                var gradeService = scope.Resolve<IGradeService>();

                // Common English names
                string[] firstNames = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Heidi", "Ivan", "Judy" };
                string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };
                Random random = new Random();

                // Add 10 students with common English names and class names like "X年A班"
                /*
                for (int i = 0; i < 10; i++)
                {
                    string name = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}";
                    int year = random.Next(1, 4); // 1 to 3
                    int classNum = random.Next(1, 6); // 1 to 5
                    string className = $"{year}年{((char)('A' + classNum - 1))}班"; // A, B, C, D, E

                    var student = new Student { Name = name, ClassName = className };
                    // Check if student already exists to avoid duplicates
                    if (!studentService.GetAll().Any(s => s.Name == student.Name && s.ClassName == student.ClassName))
                    {
                        studentService.Add(student);
                        Console.WriteLine($"Added student: {student.Name} ({student.ClassName})");
                    }
                }
                */

                // Get all existing courses
                var courses = courseService.GetAll().ToList();
                /*
                if (!courses.Any())
                {
                    // Add some default courses if none exist
                    courses.Add(new Course { Name = "數學" });
                    courses.Add(new Course { Name = "語文" });
                    courses.Add(new Course { Name = "英文" });
                    foreach (var course in courses)
                    {
                        if (!courseService.GetAll().Any(c => c.Name == course.Name))
                        {
                            courseService.Add(course);
                            Console.WriteLine($"Added course: {course.Name}");
                        }
                    }
                    courses = courseService.GetAll().ToList(); // Refresh courses after adding
                }
                */

                // Add grades for each student in existing courses
                var allStudents = studentService.GetAll().ToList();
                
                /*
                foreach (var student in allStudents)
                {
                    foreach (var course in courses)
                    {
                        // Check if grade already exists for this student and course
                        if (!gradeService.GetGradesByStudentId(student.Id).Any(g => g.CourseId == course.Id))
                        {
                            var grade = new Grade
                            {
                                StudentId = student.Id,
                                CourseId = course.Id,
                                Score = random.Next(60, 101) // Score between 60 and 100
                            };
                            gradeService.Add(grade);
                            Console.WriteLine($"Added grade for {student.Name} in {course.Name}: {grade.Score}");
                        }
                    }
                }
                */
            }
        }
    }
}