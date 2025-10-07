using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApp.Models
{
    /// <summary>
    /// SQL Server 資料庫內容
    /// </summary>
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 連線到本機 LocalDB
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookLibraryDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
