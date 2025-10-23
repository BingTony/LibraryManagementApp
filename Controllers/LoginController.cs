using LibraryManagementApp.Services.Interfaces;
using LibraryManagementApp.Utils;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.Controllers;

public class LoginController
{
    private readonly IAuthService _authService;

    public LoginController(IAuthService authService)
    {
        _authService = authService ?? throw new ArgumentNullException(nameof(authService));
    }

    /// <summary>
    /// 嘗試驗證使用者
    /// </summary>
    /// <returns>使用者 or null</returns>
    public async Task<User?> AuthenticateAsync(string username, string password)
    {
        if (!DatabaseHelper.TestConnection())
            throw new InvalidOperationException("Cannot connect to database.");

        return await _authService.AuthenticateAsync(username, password);
    }
}

