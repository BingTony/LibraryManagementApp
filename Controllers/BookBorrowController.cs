using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Interfaces;

namespace LibraryManagementApp.Controllers
{
    public class BookBorrowController
    {
        private readonly IBookBorrowService _service;

        public BookBorrowController(IBookBorrowService bookService)
        {
            _service = bookService;
        }

        public Task<List<Book>> GetAvailableBooksAsync() => _service.GetAllAsync();

        public async Task BorrowAsync(int userId, int bookId)
        {
            await _service.CheckBookStock(bookId);
            await _service.AddBorrowRecordAsync(userId, bookId);
            await _service.DecreaseQuantityAsync(bookId);
        }

        public Task<List<BorrowRecord>> GetBorrowRecordsAsync(int userId) =>
            _service.GetByUserAsync(userId);

        public async Task ReturnAsync(int recordId)
        {
            await _service.ReturnAsnyc(recordId, DateTime.Now);
        }
    }
}
