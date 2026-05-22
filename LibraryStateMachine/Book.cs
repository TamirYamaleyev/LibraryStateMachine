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
        public string Renter { get; set; }

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

        public void Rent(int days)
        {
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

        public string BookName => bookName;
    }
}