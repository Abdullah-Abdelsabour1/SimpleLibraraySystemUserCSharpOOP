using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal abstract class User
    {
        public string Name { get; set; }

        // Display All books
        public void ShowBooks(Library library)
        {
            library.DisplayAllBook();
        }
        // Display borrowed books
        public void ShowBorrowedBooks(Library library)
        {
            library.DisplayBorrowedBook();
        }
    }
}
