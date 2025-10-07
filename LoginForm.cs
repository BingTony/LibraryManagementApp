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
        /// �ϥΪ̫��U�n�J���s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // ���ˬd��Ʈw�s�u
                if (!DatabaseHelper.TestConnection())
                {
                    MessageBox.Show("�L�k�s�����Ʈw�A�еy��A�աI", "�s�u���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();

                using var db = new LibraryContext();
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    MessageBox.Show("�b���αK�X���~�I", "�n�J����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // �n�J���\ �� �}�D�e��
                var main = new MainForm(user);
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�n�J�L�{�o�Ϳ��~�G{ex.Message}", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
