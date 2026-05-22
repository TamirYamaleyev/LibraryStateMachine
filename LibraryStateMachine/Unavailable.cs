namespace LibraryStateMachine;

public class Unavailable : State
{

    public override void Rent(Book book ,int days)
    {
        Console.WriteLine("can't rent a book that is not in stock");
    }

    public override void Overdue(Book book)
    {
        Console.WriteLine("Book is overdue");
    }

    public override void PayFine()
    {
        Console.WriteLine("you need to pay a fine");
    }

    public override void Return(Book book)
    {
        PayFine();
        Console.WriteLine("fine is paid, book is returned");
        book.State = new Available();

    }
}