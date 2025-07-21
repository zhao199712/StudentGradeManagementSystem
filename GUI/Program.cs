// Program.cs — 乾淨寫法
using Autofac;

using StudentGradeManagementSystem.WinForm;

namespace GUI
{
	internal static class Program
	{
		public static IContainer? Container { get; set; }

		[STAThread]
		static void Main()
		{

			

			// 🔧 正確呼叫你自己的完整容器註冊
			Container = Di.BuildContainer();

			// ✅ MainForm 已在 DI.cs 中註冊
			Application.Run(Container.Resolve<MainForm>());
		}
	}
}
