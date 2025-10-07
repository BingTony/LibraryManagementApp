using LibraryManagementApp.Models;

namespace LibraryManagementApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // �T�O��Ʈw�s�b & �w�]�޲z��
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
    }
}