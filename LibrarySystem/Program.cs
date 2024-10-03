namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Library System");
            Console.WriteLine("Are you Librarian or Regular user (L / R)");

            char UserType = Console.ReadLine().ToUpper()[0];
             
            // object of library
            Library library = new Library();

            if (UserType == 'L')
            {
                Console.WriteLine("Welcome Librarian, Enter your Name: ");
                string LibName = Console.ReadLine();

                Librarin l1 = new Librarin(LibName);

                Console.WriteLine($"welcome, {l1.Name}");

                while (true)
                {
                    Console.WriteLine("choose to Add book , remove , display (A / R / D)");

                    char choose = Console.ReadLine().ToUpper()[0];

                    switch (choose)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details: ");
                            Console.WriteLine("\t Enter book Name: ");
                            string bookName = Console.ReadLine();
                            Console.WriteLine("\t Enter book Author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("\t Enter date of publishing: ");
                            int PublishingYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book()
                            {
                                Author = bookAuthor,
                                Title = bookName,
                                Year = PublishingYear,
                            };

                            l1.AddBook(book, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter the title of book you want to remove: ");
                            bookName = Console.ReadLine();
                            // we need title of book only to remove it
                            book = new Book(bookName);
                            l1.RemoveBook(book, library);
                            break;

                        case 'D':
                            l1.ShowBooks(library);
                            break;
                        default:
                            Environment.Exit(1);
                            break;
                    }

                }
            }
               
            else if (UserType == 'R')
            {
                Console.WriteLine("Welcome user, Enter your Name: ");
                string userName = Console.ReadLine();

                LibraryUser libraryUser = new LibraryUser(userName);

                Console.WriteLine($"welcome, {libraryUser.Name}");

                while (true)
                {
                    Console.WriteLine("choose to Borrow , display  books (B / D)");

                    char choose = Console.ReadLine().ToUpper()[0];

                    switch (choose)
                    {
                        case 'B':
                            Console.WriteLine("Enter book details you want to borrow: ");
                            Console.WriteLine("\t Enter book Name: ");
                            string bookName = Console.ReadLine();
                            Console.WriteLine("\t Enter book Author: ");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("\t Enter date of publishing: ");
                            int PublishingYear = Convert.ToInt32(Console.ReadLine());

                            Book book = new Book()
                            {
                                Author = bookAuthor,
                                Title = bookName,
                                Year = PublishingYear
                            };
                            libraryUser.BorrowBook(book , library);
                            break;

                        case 'D':
                            libraryUser.ShowBorrowedBooks(library);
                            break;

                        default:
                            Environment.Exit(1);
                            break;
                    }
                }
            }

             else
            {
                Console.WriteLine("please Enter Correct Answer");
            }
            
        }
    }
}
