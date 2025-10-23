using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApp.Services
{
    internal class BookBorrowService : IBookBorrowService
    {
        public async Task CheckBookStock(int bookId)
        {
            using var db = new LibraryContext();
            var book = await db.Books.AsNoTracking().FirstOrDefaultAsync(b => b.Id == bookId);
            if (book == null || book.Quantity <= 0)
            {
                throw new InvalidOperationException("書籍庫存不足或不存在。");
            }
        }

        public async Task AddBorrowRecordAsync(int userId, int bookId)
        {
            using var db = new LibraryContext();

            var record = new BorrowRecord
            {
                UserId = userId,
                BookId = bookId,
                BorrowedAt = DateTime.Now
            };

            db.BorrowRecords.Add(record);
            await db.SaveChangesAsync();
        }

        public async Task<List<BorrowRecord>> GetByUserAsync(int userId)
        {
            using var db = new LibraryContext();

            return await db.BorrowRecords
                .Where(r => r.UserId == userId)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<Book>> GetAllAsync()
        {
            using var db = new LibraryContext();
            return await db.Books.AsNoTracking().ToListAsync();
        }

        public async Task DecreaseQuantityAsync(int bookId)
        {
            using var db = new LibraryContext();

            var book = await db.Books.FindAsync(bookId);
            if (book != null && book.Quantity > 0)
            {
                book.Quantity--;
                db.Attach(book).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }

        public async Task ReturnAsnyc(int recordId, DateTime returnAt)
        {
            using var db = new LibraryContext();

            var record = await db.BorrowRecords.FindAsync(recordId);
            if (record != null && record.ReturnedAt == null)
            {
                record.ReturnedAt = returnAt;

                db.Attach(record).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }

            var book = await db.Books.FindAsync(record.BookId);
            if (book != null)
            {
                book.Quantity++;

                db.Attach(book).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }
}
