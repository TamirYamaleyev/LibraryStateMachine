namespace LibraryStateMachine;

public class Unavailable : State
{
    public override void ShowState()
    {
        throw new NotImplementedException();
    }

    public override void Rent(Book book ,int days)
    {
        throw new NotImplementedException();
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