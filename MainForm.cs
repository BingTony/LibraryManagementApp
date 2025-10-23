using System.ComponentModel;
using LibraryManagementApp.Controllers;
using LibraryManagementApp.Models;

namespace LibraryManagementApp
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;
        private readonly BookController _bookController;
        private BindingList<Book> _bookList = new();

        internal MainForm(User user, BookController bookController)
        {
            InitializeComponent();
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
            _bookController = bookController ?? throw new ArgumentNullException(nameof(bookController));

            lblUser.Text = $"登入使用者：{user.Username} ({user.Role})";

            UserPermission();

            _ = LoadBooksAsync();
        }

        private async Task LoadBooksAsync()
        {
            try
            {
                var books = await _bookController.GetAllAsync();
                _bookList = new BindingList<Book>(books);
                dgvBooks.DataSource = _bookList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入書籍失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserPermission()
        {
            var isAdmin = _currentUser.Role == "Admin";
            btnUserManage.Enabled = btnBookManage.Enabled = btnRefresh.Enabled = dgvBooks.Enabled =
                btnAdd.Enabled = btnDelete.Enabled = btnSave.Enabled = BookLabel.Enabled = isAdmin;

            btnUserManage.Visible = btnBookManage.Visible = btnRefresh.Visible =
                dgvBooks.Visible = btnAdd.Visible = btnDelete.Visible = btnSave.Visible = BookLabel.Visible = isAdmin;
        }

        private async void btnBookManage_Click(object sender, EventArgs e)
        {
            await LoadBooksAsync();

            if (dgvBooks.Enabled == true)
            {
                MessageBox.Show("關閉書籍管理畫面...");
                dgvBooks.Enabled = false;
                dgvBooks.Visible = false;
            }
            else
            {
                MessageBox.Show("開啟書籍管理畫面...");
                dgvBooks.Enabled = true;
                dgvBooks.Visible = true;
            }

        }

        private void btnBorrowManage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟借閱管理畫面...");
            var borrowForm = new BookBorrowForm(_currentUser);
            borrowForm.ShowDialog();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟使用者管理畫面...");

            var userForm = new UserManagementForm();
            userForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newBook = new Book
                {
                    Title = "新書籍",
                    Author = "",
                    Publisher = "",
                    Category = "",
                    Quantity = 1
                };

                await _bookController.AddAsync(newBook);
                await LoadBooksAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增失敗：{ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.CurrentRow?.DataBoundItem is Book selected)
                {
                    await _bookController.DeleteAsync(selected);
                    await LoadBooksAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.CurrentRow?.DataBoundItem is Book edited)
                {
                    await _bookController.UpdateAsync(edited);
                    MessageBox.Show("資料已更新！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadBooksAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗：{ex.Message}");
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadBooksAsync();
            MessageBox.Show("書籍資料已重新整理！");
        }
    }
}