using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services
{
    /// <summary>
    /// 書籍相關服務介面
    /// </summary>
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Book book);
    }
}