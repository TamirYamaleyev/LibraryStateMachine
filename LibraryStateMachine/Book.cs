using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStateMachine
{
    internal class Book
    {
        private State state;
        private string renter;
        private string bookName;

        public Book(string renter)
        {
            this.renter = renter;
            state = new AvailableState();
        }

        public string Renter => renter;
        public string BookName => bookName;

        public State State
        {
            get { return state; }
            set { state = value; }
        }
    }
}