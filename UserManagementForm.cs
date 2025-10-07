using LibraryManagementApp.Models;


namespace LibraryManagementApp
{
    public partial class UserManagementForm : Form
    {
        private LibraryContext _db = new LibraryContext();

        public UserManagementForm()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _db.Users.ToList();
            userBindingSource.DataSource = users;
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                            _db.Users.Remove(selected);
                            _db.SaveChanges();
                            LoadUsers();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User
                {
                    Username = "NewUser",
                    Password = "password",
                    Role = "User"
                };

                _db.Users.Add(newUser);
                _db.SaveChanges();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增失敗：{ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _db.SaveChanges();
                LoadUsers();
                MessageBox.Show("儲存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗：{ex.Message}");
            }
        }
    }
}
