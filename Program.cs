using LibraryManagementApp.Controllers;
using LibraryManagementApp.Services;
using LibraryManagementApp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // Services
            services.AddSingleton<IBookService, BookService>();
            services.AddSingleton<IAuthService, AuthService>();
            services.AddSingleton<IBookBorrowService, BookBorrowService>();

            // Controllers
            services.AddSingleton<BookController>();
            services.AddSingleton<LoginController>();
            services.AddSingleton<BookBorrowController>();

            // Forms
            services.AddTransient(provider => ActivatorUtilities.CreateInstance<LoginForm>(provider));
            services.AddTransient(provider => ActivatorUtilities.CreateInstance<MainForm>(provider));
            services.AddTransient(provider => ActivatorUtilities.CreateInstance<BookBorrowForm>(provider));

            var provider = services.BuildServiceProvider();

            // Run the application
            Application.Run(provider.GetRequiredService<LoginForm>());
        }
    }
}