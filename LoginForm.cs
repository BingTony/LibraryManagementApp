using LibraryManagementApp.Models;
using LibraryManagementApp.Utils;

namespace LibraryManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 使用者按下登入按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // 先檢查資料庫連線
                if (!DatabaseHelper.TestConnection())
                {
                    MessageBox.Show("無法連接到資料庫，請稍後再試！", "連線錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();

                using var db = new LibraryContext();
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    MessageBox.Show("帳號或密碼錯誤！", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 登入成功 → 開主畫面
                var main = new MainForm(user);
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"登入過程發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
