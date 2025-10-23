using Microsoft.EntityFrameworkCore;
using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Interfaces;

namespace LibraryManagementApp.Services
{
    internal class AuthService : IAuthService
    {
        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            using var db = new LibraryContext();
            return await db.Users
                           .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }
    }
}