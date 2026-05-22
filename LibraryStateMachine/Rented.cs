namespace LibraryStateMachine;

public class Rented : State
{

    public override void Rent(Book book,int days)
    {
        Console.WriteLine("can't rent a book that is rented already");
    }

    public override void Overdue(Book book)
    {
        Console.WriteLine("book is overdue");
    }

    public override void PayFine()
    {
        Console.WriteLine("unless overdue, no fine is eligble for a rented book");
        
    }

    public override void Return(Book book)
    {
        book.State = new Available();

        Console.WriteLine("book is returned");
    }
}