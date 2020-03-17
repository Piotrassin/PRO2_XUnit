using System;

namespace Library.Models.DTO
{
    public class BookBorrowDto
    {
        public int IdBookBorrow { get; set; }
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Comment { get; set; }
    }
}
