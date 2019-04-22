

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
        private List<string> books = new List<string>();

        public bool OverDueBooks
        {
            get { return this.overDueBooks; }
            set { this.overDueBooks = value; }
        }

        public ushort NumberBooksCheckedOut
        {
            get { return this.numBooksCheckedOut; }
            set
            {
                this.numBooksCheckedOut = value;
                // this.PropertyChanged;
            }
        }

        public Cardholder()
        {

        }
        
        public bool AddBook(Book.Book b)
        {
            if (books.Contains(b.Title))
            {
                return false;
            }
            else
            {
                books.Add(b.Title);
                return true;
            }
            

            return true;
        }

        public List<String> Books
        {
            get { return this.books; }
            set { this.books = value; }
            
        }

        public bool ReturnBook(Book.Book b)
        {
            if (books.Contains(b.Title))
            {
                books.Remove(b.Title);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
