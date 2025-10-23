using LibraryManagementApp.Controllers;
using LibraryManagementApp.Models;

namespace LibraryManagementApp
{
    public partial class BookBorrowForm : Form
    {
        private readonly BookBorrowController _controller;
        private readonly User _currentUser;
        
        public BookBorrowForm(BookBorrowController controller, User currentUser)
        {
            InitializeComponent();
            _controller = controller;
            _currentUser = currentUser;

            LoadBooks();
            LoadBorrowRecords();
        }
        
        private async void LoadBooks()
        {
            try
            {
                var books = await _controller.GetAvailableBooksAsync();
                dgvBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入書籍失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedBook = dgvBooks.CurrentRow?.DataBoundItem as Book;
                if (selectedBook == null) return;

                await _controller.BorrowAsync(_currentUser.Id, selectedBook.Id);

                await Task.Delay(1);
                LoadBooks();
                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"借閱過程發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadBorrowRecords()
        {
            var records = await _controller.GetBorrowRecordsAsync(_currentUser.Id);
            dgvBorrowRecords.DataSource = records;
        }

        private async void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRecord = dgvBorrowRecords.CurrentRow?.DataBoundItem as BorrowRecord;
                if (selectedRecord == null || selectedRecord.ReturnedAt != null)
                {
                    MessageBox.Show("請選擇一筆有效的借閱紀錄來歸還。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await _controller.ReturnAsync(selectedRecord.Id);

                MessageBox.Show("成功歸還書本。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await Task.Delay(1);
                LoadBooks();
                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"歸還過程發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
