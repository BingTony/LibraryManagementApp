using LibraryManagementApp.Models;

namespace LibraryManagementApp
{
    /// <summary>
    /// 系統主畫面
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly User _currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            lblUser.Text = $"登入使用者：{user.Username} ({user.Role})";

            // 根據角色決定哪些功能可見
            if (user.Role != "Admin")
            {
                btnUserManage.Enabled = false;
                btnUserManage.Visible = false;
            }
        }

        private void btnBookManage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟書籍管理畫面...");
        }

        private void btnBorrowManage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟借閱管理畫面...");
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟使用者管理畫面...");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
