namespace LibraryStateMachine;

public class Available : State
{
    public void showState()
    {
        Console.WriteLine("book is available");
    }

    public override void ShowState()
    {
        throw new NotImplementedException();
    }

    public override void Rent(Book book ,int days)
    {
        book.State = new Rented();
        Console.WriteLine($"Book has been rented for {days} days ");
    }

    public override void Overdue(Book book)
    {
        throw new NotImplementedException();
    }

    public override void PayFine()
    {
        throw new NotImplementedException();
    }

    public override void Return(Book book)
    {
        throw new NotImplementedException();
    }
}