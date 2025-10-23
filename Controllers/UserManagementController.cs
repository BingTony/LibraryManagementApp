using LibraryManagementApp.Services.Interfaces;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.Controllers
{
    public class UserManagementController
    {
        private readonly IUserManagementService _userManagementService;

        public UserManagementController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }

        public Task<List<User>> GetAllUsersAsync() => _userManagementService.GetAllUsersAsync();
        public Task AddUserAsync(User user) => _userManagementService.AddUserAsync(user);
        public Task DeleteUserAsync(User user) => _userManagementService.DeleteUserAsync(user);
        public Task UpdateUserAsync(User user) => _userManagementService.UpdateUserAsync(user);

    }
}
