using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StudentGradeManagementSystem.Data.EF
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // 注意：這裡使用了硬編碼的連接字串，與 DI/DI.cs 中的一致。
            // 在實際應用中，建議從配置檔（如 appsettings.json）讀取。
            const string connStr = "Server=192.168.50.11;Database=StudentGradeDb;User Id=sa;Password=@Aa19971105;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connStr);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}