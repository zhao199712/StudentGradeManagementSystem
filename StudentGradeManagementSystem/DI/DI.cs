using Autofac;
using Microsoft.EntityFrameworkCore;
using StudentGradeManagementSystem.Data.EF; // 添加此行
using StudentGradeManagementSystem.Data.Repositories;
using StudentGradeManagementSystem.Domain.Logic;
using StudentGradeManagementSystem.Domain.Repository; // IRepository 的命名空間
using StudentGradeManagementSystem.Logic.Services;
using StudentGradeManagementSystem.Domain.Strategy; // 要引入命名空間

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

            // 連線字串 (依照您的要求，暫時硬編碼)
            const string connStr = "Server=192.168.50.11;Database=StudentGradeDb;User Id=sa;Password=@Aa19971105;TrustServerCertificate=True;";

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

            
            return builder.Build();
        }
    }
}