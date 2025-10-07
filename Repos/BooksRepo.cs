using LibraryManagementApp.Models;

namespace LibraryManagementApp.Repos
{
    internal class BooksRepo
    {
        internal List<Book> GetBooks()
        {
            using var db = new LibraryContext();
            var books = db.Books.ToList();
            return books;
        }
    }
}
