using LibraryStateMachine;

int currentDay = 0;

Book book1 = new Book("Attack on Titan");
Book book2 = new Book("A Song of Fire and Ice");
Book book3 = new Book("Avatar The Last Airbender");
Book book4 = new Book("World Trigger");

Book[] bookDatabase = [book1, book2, book3, book4];

Library library = new Library(bookDatabase);

Console.WriteLine("=== INITIAL STATE ===");
library.ShowAvailableBooks();

// <---------------------- DAY 0: RENTAL PHASE ---------------------->
Console.WriteLine("=== RENTAL PHASE ===");

library.RentBook(book1, 3);
library.RentBook(book4, 2);
library.RentBook(book3, 10);

Console.WriteLine();
Console.WriteLine("=== STATE AFTER RENTING ===");

book1.ShowState();
book4.ShowState();
book3.ShowState();

library.ShowAvailableBooks();

// <---------------------- TIME SIMULATION ---------------------->
Console.WriteLine("=== TIME SIMULATION START ===");

PassDay();
PassDay();
PassDay();
PassDay();
PassDay();

// <---------------------- RETURN PHASE ---------------------->

Console.WriteLine("=== RETURN PHASE ===");

library.ReturnBook(book4);
library.ReturnBook(book1);

Console.WriteLine();
Console.WriteLine("=== FINAL STATES ===");

book1.ShowState();
book4.ShowState();
book3.ShowState();

library.ShowAvailableBooks();


// Mini function to pass day for all books

void PassDay()
{
    currentDay++;

    Console.WriteLine($"--- Day {currentDay} ---");

    foreach (Book book in bookDatabase)
    {
        book.PassDay();
    }

    Console.WriteLine();
}