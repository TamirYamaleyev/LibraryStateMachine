namespace LibraryStateMachine;

public class Available : State
{
    public void showState()
    {
        Console.WriteLine("book is available");
    }
    
    public override void Rent(Book book ,int days)
    {
        book.State = new Rented();
        Console.WriteLine($"Book has been rented for {days} days ");
    }

    public override void Overdue(Book book)
    {
        Console.WriteLine("a book that is in stuck isn't overdue");
    }

    public override void PayFine()
    {
        Console.WriteLine("you can't pay a fine for a book that is in stock");
    }

    public override void Return(Book book)
    {
        Console.WriteLine("cannot return book that is already in stock");
    }
}