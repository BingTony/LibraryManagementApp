using LibraryManagementApp.Models;

namespace LibraryManagementApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                // 確保資料庫存在 & 預設管理員
                using (var db = new LibraryContext())
                {
                    db.Database.EnsureCreated();

                    if (!db.Users.Any())
                    {
                        db.Users.Add(new User { Username = "admin", Password = "admin", Role = "Admin" });
                        db.SaveChanges();
                    }
                }

                Application.Run(new LoginForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"應用程式啟動失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}