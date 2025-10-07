using System.IO;
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
            // 從外部檔案取得 server 和 database 設定
            var configPath = "dbconfig.json";
            string server = "(localdb)\\MSSQLLocalDB"; // 預設本機 LocalDB
            string database = "BookLibraryDB";

            if (File.Exists(configPath))
            {
                var json = File.ReadAllText(configPath);
                var config = System.Text.Json.JsonSerializer.Deserialize<DbConfig>(json);
                if (config != null)
                {
                    if (!string.IsNullOrWhiteSpace(config.Server))
                        server = config.Server;
                    if (!string.IsNullOrWhiteSpace(config.Database))
                        database = config.Database;
                }
            }

            var connectionString = $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
