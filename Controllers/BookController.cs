using LibraryManagementApp.Models;
using LibraryManagementApp.Services;

namespace LibraryManagementApp.Controllers
{
    public class BookController
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        public Task<List<Book>> GetAllAsync() => _service.GetAllAsync();
        public Task<Book> AddAsync(Book book) => _service.AddAsync(book);
        public Task UpdateAsync(Book book) => _service.UpdateAsync(book);
        public Task DeleteAsync(Book book) => _service.DeleteAsync(book);
    }
}