using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Interfaces
{
    public interface IBookBorrowService
    {
        Task CheckBookStock(int bookId);
        Task AddBorrowRecordAsync(int userId, int bookId);
        Task<List<BorrowRecord>> GetByUserAsync(int userId);
        Task<List<Book>> GetAllAsync();
        Task DecreaseQuantityAsync(int bookId);
        Task ReturnAsnyc(int recordId, DateTime returnAt);
    }
}
