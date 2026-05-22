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

        public void RentBook(Book book, int days)
        {
            book.State.Rent(days);
            Console.WriteLine($"Renting {book.BookName} for {days} days");
        }

        public void ReturnBook(Book book)
        {
            book.State.Return();
            Console.WriteLine($"Returning {book.BookName}");
        }

        public void SetOverdue(Book book)
        {
            book.State.SetOverdue();
            Console.WriteLine($"{book.BookName} is now overdue");
        }
    }
}
