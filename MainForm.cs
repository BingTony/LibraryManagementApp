using LibraryManagementApp.Models;
using System.Diagnostics;

namespace LibraryManagementApp
{
    /// <summary>
    /// 系統主畫面
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly User _currentUser;
        private LibraryContext _db = new LibraryContext();


        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            lblUser.Text = $"登入使用者：{user.Username} ({user.Role})";

            UserPermission();
            LoadBooks();
        }

        /// <summary>
        /// 載入書籍資料
        /// </summary>
        private void LoadBooks()
        {
            var books = _db.Books.ToList();
            dgvBooks.DataSource = books;
        }

        /// <summary>
        /// 根據角色決定哪些功能可見
        /// </summary>
        private void UserPermission()
        {
            if (_currentUser.Role != "Admin")
            {
                btnUserManage.Enabled = false;
                btnUserManage.Visible = false;
                dgvBooks.Enabled = false;
                dgvBooks.Visible = false;
                btnAdd.Enabled = false;
                btnAdd.Visible = false;
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
                btnSave.Enabled = false;
                btnSave.Visible = false;
                BookLabel.Enabled = false;
                BookLabel.Visible = false;
            }
        }

        private void btnBookManage_Click(object sender, EventArgs e)
        {
            LoadBooks();

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

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 新增書籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
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

                _db.Books.Add(newBook);
                _db.SaveChanges();

                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增失敗：{ex.Message}");
                Debug.WriteLine(ex);
            }
        }

        /// <summary>
        /// 儲存書籍資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _db.SaveChanges();
                MessageBox.Show("資料已更新！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗：{ex.Message}");
                Debug.WriteLine(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.CurrentRow?.DataBoundItem is Book selected)
                {
                    _db.Books.Remove(selected);
                    _db.SaveChanges();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗：{ex.Message}");
                Debug.WriteLine(ex);
            }
        }
    }
}
