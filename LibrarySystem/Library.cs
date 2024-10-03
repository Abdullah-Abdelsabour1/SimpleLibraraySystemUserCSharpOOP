using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal  class Library
    {
     
        private List<Book> Books = new List<Book>();

        private List<Book> BorrowedBook = new List<Book>();

        public void Add(Book NewBook)
        {
            Books.Add(NewBook);
            Console.WriteLine("book inserted successfully");
        }

        public void Remove(Book NewBook)
        {
            bool found = false ; int target = -1;
            for (int i = 0; i < Books.Count ; i++)
            {
                if (Books[i].Title == NewBook.Title)
                {
                    found = true;
                    target = i;
                    break;
                }
            }

            if (found)
            {
                Books.RemoveAt(target);
                Console.WriteLine("book removed successfully");
            }
            else
                Console.WriteLine("books not existed to remove");
          
        }

        public  void DisplayAllBook()
        {
            Console.WriteLine("All books that a vailable in our library: ");

            for (int i = 0; i < Books.Count; i++ )
            {
               Console.WriteLine($"book title :{Books[i].Title} , Author: {Books[i].Author} , date of publishing : {Books[i].Year}");
            }

        }

        public void Borrow(Book book)
        {
            BorrowedBook.Add(book);
            Console.WriteLine($"you borrowed this book : {book.Title}");
        }

        public void DisplayBorrowedBook()
        {
            Console.WriteLine("All books  you borrowed from library: ");

            for (int i = 0; i < BorrowedBook.Count; i++)
            {
                Console.WriteLine($"book title :{BorrowedBook[i].Title} , Author: {BorrowedBook[i].Author} , date of publishing : {BorrowedBook[i].Year}");
            }

        }

    }
}
