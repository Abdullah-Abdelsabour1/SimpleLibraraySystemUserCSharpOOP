using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarin : User
    {
        public int EmployeeNumber {get; set;}

        public Librarin(string name)
        {
            this.Name = name;
        }
        public void AddBook(Book newBook  , Library library)
        {
            library.Add(newBook);
        }
        public void RemoveBook(Book newBook, Library library)
        {
            library.Remove(newBook);
        }
    }
}
