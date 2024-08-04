using Microsoft.Extensions.DependencyInjection;
using WinFormsRedmine.Classes;

namespace WinFormsRedmine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            var services = new ServiceCollection();
            ConfigureServices(services);

            ApplicationConfiguration.Initialize();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainForm>();            
            services.AddTransient<IApiAccessor, ApiAccessor>();
        }
    }
}