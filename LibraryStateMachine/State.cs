namespace LibraryStateMachine;

public abstract class State
{
    public abstract void ShowState();

    public abstract void Rent(Book book,int days);

    public abstract void Overdue(Book book);
    
    public abstract void PayFine();
    
    public abstract void Return(Book book);

}