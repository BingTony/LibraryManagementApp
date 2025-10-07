using LibraryManagementApp.Models;

namespace LibraryManagementApp
{
    public partial class BookBorrowForm : Form
    {
        private readonly User _currentUser;
        private LibraryContext _db = new LibraryContext();

        public BookBorrowForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            LoadBooks();
            LoadBorrowRecords();
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
        /// 載入借閱紀錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadBorrowRecords()
        {
            var records = _db.BorrowRecords
                .Where(r => r.UserId == _currentUser.Id)
                .ToList();
            dgvBorrowRecords.DataSource = records;
        }

        /// <summary>
        /// 借閱選擇書本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedBook = dgvBooks.CurrentRow?.DataBoundItem as Book;
                if (selectedBook == null)
                {
                    MessageBox.Show("請選擇要借閱的書本。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 檢查書本數量
                if (selectedBook.Quantity <= 0)
                {
                    MessageBox.Show("該書本目前無庫存，無法借閱。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 建立借閱紀錄
                var borrowRecord = new BorrowRecord
                {
                    UserId = _currentUser.Id,
                    BookId = selectedBook.Id,
                    BorrowedAt = DateTime.Now,
                    ReturnedAt = null
                };

                _db.BorrowRecords.Add(borrowRecord);
                selectedBook.Quantity -= 1; // 減少書本數量
                _db.SaveChanges();
                MessageBox.Show($"成功借閱書本：《{selectedBook.Title}》。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBooks();
                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"借閱過程發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRecord = dgvBorrowRecords.CurrentRow?.DataBoundItem as BorrowRecord;
                if (selectedRecord == null || selectedRecord.ReturnedAt != null)
                {
                    MessageBox.Show("請選擇一筆有效的借閱紀錄來歸還。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 更新歸還時間
                selectedRecord.ReturnedAt = DateTime.Now;
                var book = _db.Books.Find(selectedRecord.BookId);
                if (book != null)
                {
                    book.Quantity += 1; // 增加書本數量
                }
                _db.SaveChanges();
                MessageBox.Show($"成功歸還書本：《{book?.Title}》。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBooks();
                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"歸還過程發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
