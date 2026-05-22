namespace LibraryStateMachine;

public class Unavailable : State
{
    public override void Rent(Book book ,int days)
    {
        Console.WriteLine("can't rent a book that is not in stock");
    }

    public override void Overdue(Book book)
    {
        Console.WriteLine("book cant become overdue when its already unavailable");
    }

    public override void PayFine(Book book)
    {
        Console.WriteLine($"you need to pay a fine for {book.BookName}");
    }

    public override void Return(Book book)
    {
        PayFine(book);
        Console.WriteLine($"fine is paid, {book.BookName} is returned");
        book.State = new Available();
    }
}