namespace LibraryStateMachine;

public abstract class State
{
    public abstract void ShowState();

    public abstract void Rent(int days);

    public abstract void Overdue();
    
    public abstract void PayFine();
    
    public abstract void Return();

}