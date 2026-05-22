using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStateMachine
{
    internal class Library
    {
        private List<Book> books;

        public Library(params Book[] initialBooks)
        {
            books = [.. initialBooks];
        }

        public void RentBook(Book book, int days)
        {
            book.Rent(days);
            books.Remove(book);
            books.Remove(book);
            Console.WriteLine($"Removed {book.BookName} from library.");
        }

        public void ReturnBook(Book book)
        {
            book.Return();
            books.Add(book);
            Console.WriteLine($"Added {book.BookName} to a library shelf.");
        }

        public void SetOverdue(Book book)
        {
            book.SetOverdue();
        }

        public void ShowAvailableBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.BookName);
            }
        }
    }
}
