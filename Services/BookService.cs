using Microsoft.EntityFrameworkCore;
using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services
{
    internal class BookService : IBookService
    {
        public async Task<List<Book>> GetAllAsync()
        {
            using var db = new LibraryContext();
            return await db.Books.AsNoTracking().ToListAsync();
        }

        public async Task<Book> AddAsync(Book book)
        {
            using var db = new LibraryContext();
            db.Books.Add(book);
            await db.SaveChangesAsync();
            return book;
        }

        public async Task UpdateAsync(Book book)
        {
            using var db = new LibraryContext();
            db.Attach(book).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Book book)
        {
            using var db = new LibraryContext();

            db.Attach(book);
            db.Books.Remove(book);
            await db.SaveChangesAsync();
        }
    }
}