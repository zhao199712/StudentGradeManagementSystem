using Autofac;
using GUI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Add this
using StudentGradeManagementSystem.Data.EF; // 添加此行
using StudentGradeManagementSystem.Data.Repositories;
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.Repository; // IRepository 的命名空間
using StudentGradeManagementSystem.Domain.Strategy; // 要引入命名空間
using StudentGradeManagementSystem.Domain.POCO; // 添加此行
using StudentGradeManagementSystem.Logic.Services;


// 註冊策略工廠函式

namespace StudentGradeManagementSystem.WinForm
{

	public static class Di
	{

		public static IContainer BuildContainer()
		{

			var builder = new ContainerBuilder();

			builder.Register<Func<string, IGradingStrategy>>(ctx =>
			{
				return strategyType => strategyType.ToLower() switch
				{
					"traditional" => new TraditionalGradingStrategy(),
					"curved" => new CurvedGradingStrategy(),
					_ => throw new ArgumentException($"未知的策略型別: {strategyType}")
				};
			});

			// 從 appsettings.json 讀取連線字串
			var configuration = new ConfigurationBuilder()
				.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();

			var connStr = configuration.GetConnectionString("DefaultConnection");

			// 註冊 EF DbContext
			builder.Register(c =>
			{
				var options = new DbContextOptionsBuilder<ApplicationDbContext>() // <--- 使用 ApplicationDbContext
					.UseSqlServer(connStr)
					.Options;
				return new ApplicationDbContext(options); // <--- 使用 ApplicationDbContext
			}).AsSelf().InstancePerLifetimeScope();

			// Repository 與 Service 註冊
			builder.RegisterType<StudentRepository>().As<IStudentRepository>(); // <--- 使用 StudentRepository
			builder.RegisterType<CourseRepository>().As<ICourseRepository>();   // <--- 使用 CourseRepository
			builder.RegisterType<GradeRepository>().As<IGradeRepository>();     // <--- 使用 GradeRepository
			builder.RegisterType<GradeService>().As<IGradeService>();
			builder.RegisterType<StudentService>().As<IStudentService>();
			builder.RegisterType<CourseService>().As<ICourseService>();
			builder.RegisterType<MainForm>().AsSelf();
			builder.RegisterType<CourseManagementForm>().AsSelf();
            builder.RegisterType<CourseSelectionForm>().AsSelf();
            builder.RegisterType<CoursePassingStudentsForm>().AsSelf();




			var container = builder.Build();
            StudentGradeManagementSystem.SampleDataInitializer.Initialize(container);

            // Generate and add 20 students with random names and scores (40-100)
            using (var scope = container.BeginLifetimeScope())
            {
                var studentService = scope.Resolve<IStudentService>();
                var courseService = scope.Resolve<ICourseService>();
                var gradeService = scope.Resolve<IGradeService>();
                var random = new Random();

                // Clear existing data
                gradeService.ClearAll();
                studentService.ClearAll();
                // Note: Course data is not cleared here, assuming courses are relatively static.
                // If courses also need to be regenerated, add courseService.ClearAll() and implement it.

                var commonEnglishNames = new List<string>
                {
                    "James", "Mary", "Robert", "Patricia", "John", "Jennifer", "Michael", "Linda", "David", "Elizabeth",
                    "William", "Barbara", "Richard", "Joseph", "Jessica", "Thomas", "Sarah", "Charles", "Karen", "Susan"
                };

                var courseNames = new List<string> { "國文", "數學", "英文", "理化" };
                var courses = new List<StudentGradeManagementSystem.Domain.POCO.Course>();

                // Ensure required courses exist
                foreach (var courseName in courseNames)
                {
                    var course = courseService.GetAll().FirstOrDefault(c => c.Name == courseName);
                    if (course == null)
                    {
                        course = new StudentGradeManagementSystem.Domain.POCO.Course { Name = courseName, Credit = 3 }; // Assign a default credit
                        courseService.Add(course);
                        Console.WriteLine($"Added course: {course.Name}");
                    }
                    courses.Add(course);
                }

                for (int i = 0; i < 20; i++)
                {
                    var studentName = commonEnglishNames[random.Next(commonEnglishNames.Count)];
                    var year = random.Next(1, 4); // 1 to 3
                    var classNum = random.Next(1, 10); // 1 to 9
                    var className = $"{year}年{classNum}班";

                    var student = new Student
                    {
                        Name = $"{studentName} {random.Next(1, 100)}", // Add a number to make names unique
                        ClassName = className
                    };
                    studentService.Add(student);
                    Console.WriteLine($"Added student: {student.Name} in {student.ClassName}");

                    foreach (var course in courses)
                    {
                        var grade = new Grade
                        {
                            StudentId = student.Id,
                            CourseId = course.Id,
                            Score = random.Next(40, 101) // Score between 40 and 100 (inclusive)
                        };
                        gradeService.Add(grade);
                        Console.WriteLine($"Added grade {grade.Score} for {student.Name} in {course.Name}");
                    }
                }
            }

            return container;
		}
	}
}