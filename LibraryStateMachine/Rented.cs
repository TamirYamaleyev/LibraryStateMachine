namespace LibraryStateMachine;

public class Rented : State
{
    public override void ShowState()
    {
        throw new NotImplementedException();
    }

    public override void Rent(Book book,int days)
    {
        throw new NotImplementedException();
    }

    public override void Overdue(Book book)
    {
        Console.WriteLine("book is overdue");
    }

    public override void PayFine()
    {
        throw new NotImplementedException();
    }

    public override void Return(Book book)
    {
        book.State = new Available();

        Console.WriteLine("book is returned");
    }
}