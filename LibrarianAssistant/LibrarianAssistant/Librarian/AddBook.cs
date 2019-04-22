using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ApplicationEngine.Book;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace LibrarianAssistant.Librarian
{
    public partial class AddBook : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;
        public AddBook()
        {

            InitializeComponent();
            this.ISBNtext.Text = "ISBN";
            this.TitleText.Text = "Title";
            this.AuthorText.Text = "Author";
            this.DateText.Text = "Date Released";
            this.GenreText.Text = "Genre";
            this.AvailableText.Text = "Number Available";
            this.CHText.Text = "CurrentHolders";
            this.Submit.Text = "Submit Changes";
            this.Back.Text = "previouse Page";

            client = new FireSharp.FirebaseClient(config);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new Book
            {
                Title = Title.Text,
                Author = Author.Text,
                ISBN = Convert.ToInt64(ISBN.Text),
                Date = Date.Text,
                Genre = Genre.Text,
                Available = Convert.ToInt32(Available.Text)

            };
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void ISBNtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
