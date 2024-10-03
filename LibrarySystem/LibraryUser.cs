using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryUser : User
    {
        public LibraryCard card { get; set; }
        public LibraryUser(string name)
        {
           this.Name = name;
        }
        public void BorrowBook(Book book , Library library)
        {
            library.Borrow(book);
        }
    }
}
