using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApp.Services
{
    internal class UserManagementService : IUserManagementService
    {
        public async Task<List<User>> GetAllUsersAsync()
        {
            using var db = new LibraryContext();
            return await db.Users.AsNoTracking().ToListAsync();
        }

        public async Task AddUserAsync(User user)
        {
            using var db = new LibraryContext();
            db.Users.Add(user);
            await db.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            using var db = new LibraryContext();
            db.Attach(user);
            db.Users.Remove(user);
            await db.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            using var db = new LibraryContext();
            db.Attach(user).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
