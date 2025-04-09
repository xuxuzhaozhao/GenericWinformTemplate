using GenericWinformTemplate.Extensions;
using GenericWinformTemplate.Forms;
using GenericWinformTemplate.Services;
using GenericWinformTemplate.Services.Impl;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GenericWinformTemplate
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                 .ConfigureAppConfiguration((context, config) =>
                 {
                     config.AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
                 })
                 .ConfigureServices((context, services) =>
                 {
                     context.Configuration.SetAppSettings();

                     // Register services
                     services.AddScoped<ITestService, TestService>();

                     // Register forms
                     services.AddTransient<MainForm>();
                     services.AddTransient<SettingsForm>();
                 }).Build();

            using var scope = host.Services.CreateScope();
            var mainform = scope.ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainform);
        }
    }
}