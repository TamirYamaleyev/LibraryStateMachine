namespace LibraryStateMachine;

public class Unavailable : State
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
        Console.WriteLine("Book is overdue");
    }

    public override void PayFine()
    {
        Console.WriteLine("you need to pay a fine");
    }

    public override void Return()
    {
        PayFine();
        Console.WriteLine("fine is paid, book is returned");
    }
}