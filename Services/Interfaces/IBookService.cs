using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services
{
    /// <summary>
    /// ���y�����A�Ȥ���
    /// </summary>
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Book book);
    }
}