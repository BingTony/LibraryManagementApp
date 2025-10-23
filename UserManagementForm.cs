using LibraryManagementApp.Controllers;
using LibraryManagementApp.Models;
using System.Threading.Tasks;

namespace LibraryManagementApp
{
    public partial class UserManagementForm : Form
    {
        private readonly UserManagementController _controller;

        public UserManagementForm(UserManagementController userManagementController)
        {
            InitializeComponent();
            _controller = userManagementController;

            _ = LoadUsers();
        }

        private async Task LoadUsers()
        {
            try
            {
                var users = await _controller.GetAllUsersAsync();
                dgvUserManagement.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入使用者失敗：{ex.Message}");
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUserManagement.CurrentRow?.DataBoundItem is User selected)
                {
                    if (selected != null)
                    {
                        var confirmResult = MessageBox.Show($"確定要刪除使用者 {selected.Username} 嗎？", "確認刪除", MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            await _controller.DeleteUserAsync(selected);
                            await LoadUsers();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User
                {
                    Username = "NewUser",
                    Password = "password",
                    Role = "User"
                };

                await _controller.AddUserAsync(newUser);
                await LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增失敗：{ex.Message}");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUserManagement.DataSource is List<User> users)
                {
                    foreach (var user in users)
                    {
                        await _controller.UpdateUserAsync(user);
                    }
                }

                await LoadUsers();
                MessageBox.Show("儲存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗：{ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
