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

    public override void Rent(int days)
    {
        Console.WriteLine($"Book has been rented for {days} days ");
    }

    public override void Overdue()
    {
        throw new NotImplementedException();
    }

    public override void PayFine()
    {
        throw new NotImplementedException();
    }

    public override void Return()
    {
        throw new NotImplementedException();
    }
}