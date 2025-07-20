using Autofac;
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.WinForm;

namespace StudentGradeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Di.BuildContainer(); // Call the method from your DI class

            // Use the Autofac container to resolve services
            using (var scope = container.BeginLifetimeScope())
            {
                // Example: You can get your services like this
                // var gradeService = scope.Resolve<IGradeService>();
                Console.WriteLine("Hello, World with Autofac!");
            }
        }
    }
}