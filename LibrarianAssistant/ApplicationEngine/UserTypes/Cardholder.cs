

namespace ApplicationEngine.UserTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Cardholder : User
    {
        private bool overDueBooks;
        private ushort numBooksCheckedOut;

        public bool OverDueBooks
        {
            get { return this.overDueBooks; }
            set { this.overDueBooks = value; }
        }

        public ushort NumberBooksCheckedOut
        {
            get { return this.numBooksCheckedOut; }
            set { this.numBooksCheckedOut = value; }
        }

        public Cardholder()
        {

        }
    }
}
