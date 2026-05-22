using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStateMachine
{
    public class Book
    {
        private State state;
        private string bookName;
        private int rentedDays;
        private int allowedDays;

        public Book(string bookName)
        {
            this.bookName = bookName;
            state = new Available();
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void ShowState()
        {
            Console.WriteLine($"{bookName}'s current state: {state.GetType().Name}");
        }

        public void Rent(int days)
        {
            rentedDays = 0;
            allowedDays = days;
            state.Rent(this, days);
        }

        public void Return()
        {
            state.Return(this);
        }

        public void SetOverdue()
        {
            state.Overdue(this);
        }

        public void PassDay()
        {
            if (state is Rented)
            {
                rentedDays++;

                if (rentedDays > allowedDays)
                    state.Overdue(this);
            }
        }

        public string BookName => bookName;
    }
}