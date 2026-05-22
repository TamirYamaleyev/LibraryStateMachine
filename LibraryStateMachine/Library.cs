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

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added {book.BookName} to Library.");
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($"Removed {book.BookName} from Library.");
        }

        public void RentBook(Book book, int days, string renter)
        {
            book.State.Rent(days);
            book.Renter = renter;
            book.State = new Rented();
            books.Remove(book);
        }

        public void ReturnBook(Book book)
        {
            book.State.Return();
            book.State = new Available();
            books.Add(book);
        }

        public void SetOverdue(Book book)
        {
            book.State.Overdue();
            book.State = new Unavailable();
        }
    }
}
