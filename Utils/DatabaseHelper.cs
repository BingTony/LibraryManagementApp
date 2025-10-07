using LibraryManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementApp.Utils
{
    internal class DatabaseHelper
    {
        /// <summary>
        /// 測試資料庫連線
        /// </summary>
        /// <returns></returns>
        public static bool TestConnection()
        {
            try
            {
                using var db = new LibraryContext();
                db.Database.OpenConnection();
                db.Database.CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}