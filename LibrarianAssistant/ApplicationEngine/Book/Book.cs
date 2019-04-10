using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEngine.Book
{
    public class Book
    {
        private long iSBN;
        private string author;
        private string title;
        private string date;
        private string genre;
        private int available;
        // private List<cardholder> holders;


        public Book()
        {
            iSBN = 0;
            author = "";
            title = "";
            date = "";
            genre = "";
            available = 0;

        }

        public long ISBN
        {
            get
            {
                return iSBN;
            }
            set
            {
                iSBN = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public int Available
        {
            get
            {
                return available;
            }
            set
            {
                available = value;
            }


        }
    }
}
