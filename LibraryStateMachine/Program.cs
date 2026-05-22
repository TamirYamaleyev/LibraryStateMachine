using LibraryStateMachine;

Book book1 = new Book("Attack on Titan");
Book book2 = new Book("A Song of Fire and Ice");
Book book3 = new Book("Avatar The Last Airbender");
Book book4 = new Book("World Trigger");

Book[] bookDatabase = { book1, book2, book3, book4 };

Library library = new Library(bookDatabase);

library.ShowAvailableBooks();

library.RentBook(book1, 5);
library.RentBook(book4, 14);

library.ShowAvailableBooks();
