using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User?> AuthenticateAsync(string username, string password);
    }
}