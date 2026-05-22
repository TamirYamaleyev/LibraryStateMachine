namespace LibraryStateMachine;

public class Available : State
{
    public override void Rent(Book book ,int days)
    {
        book.State = new Rented();
        Console.WriteLine($"{book.BookName} has been rented for {days} days ");
    }

    public override void Overdue(Book book)
    {
        Console.WriteLine("a book that is in stock isn't overdue");
    }

    public override void PayFine(Book book)
    {
        Console.WriteLine("you can't pay a fine for a book that is in stock");
    }

    public override void Return(Book book)
    {
        Console.WriteLine("cannot return book that is already in stock");
    }
}