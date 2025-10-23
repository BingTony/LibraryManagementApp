using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Interfaces
{
    public interface IUserManagementService
    {
        Task<List<User>> GetAllUsersAsync();
        Task AddUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task UpdateUserAsync(User user);
    }
}