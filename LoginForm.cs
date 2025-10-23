using LibraryManagementApp.Controllers;

namespace LibraryManagementApp
{
    public partial class LoginForm : Form
    {
        private readonly LoginController _loginController;
        private readonly BookController _bookController;
        private readonly BookBorrowController _bookBorrowController;
        private readonly UserManagementController _userManagementController;

        public LoginForm(
            LoginController loginController,
            BookController bookController,
            BookBorrowController bookBorrowController,
            UserManagementController userManagementController)
        {
            InitializeComponent();
            _loginController = loginController ?? throw new ArgumentNullException(nameof(loginController));
            _bookController = bookController ?? throw new ArgumentNullException(nameof(bookController));
            _bookBorrowController = bookBorrowController;
            _userManagementController = userManagementController;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();

                var user = await _loginController.AuthenticateAsync(username, password);

                if (user == null)
                {
                    MessageBox.Show("�b���αK�X���~�I", "�n�J����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Login successful -> open main form
                var main = new MainForm(user, _bookController, _bookBorrowController, _userManagementController);

                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"�L�k�s�����Ʈw�G{ex.Message}", "�s�u���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
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