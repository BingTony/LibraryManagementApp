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
            services.AddSingleton<IUserManagementService, UserManagementService>();

            // Controllers
            services.AddSingleton<BookController>();
            services.AddSingleton<LoginController>();
            services.AddSingleton<BookBorrowController>();
            services.AddSingleton<UserManagementController>();

            // Forms
            services.AddTransient(provider => ActivatorUtilities.CreateInstance<LoginForm>(provider));
            services.AddTransient(provider => ActivatorUtilities.CreateInstance<MainForm>(provider));
            services.AddTransient(provider => ActivatorUtilities.CreateInstance<BookBorrowForm>(provider));
            services.AddTransient(provider => ActivatorUtilities.CreateInstance<UserManagementForm>(provider));

            var provider = services.BuildServiceProvider();

            // Run the application
            Application.Run(provider.GetRequiredService<LoginForm>());
        }
    }
}