namespace LibraryStateMachine;

public class Rented : State
{
    public override void ShowState()
    {
        throw new NotImplementedException();
    }

    public override void Rent(int days)
    {
        throw new NotImplementedException();
    }

    public override void Overdue()
    {
        Console.WriteLine("book is overdue");
    }

    public override void PayFine()
    {
        throw new NotImplementedException();
    }

    public override void Return()
    {
        Console.WriteLine("book is returned");
    }
}