﻿namespace LibraryManagementApp.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowedAt { get; set; } = DateTime.Now;
        public DateTime? ReturnedAt { get; set; }
    }
}
