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

namespace LibrarianAssistant
{
    public partial class EditBook : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;

        public EditBook()
        {
            InitializeComponent();
            this.ISBNtext.Text = "ISBN";
            this.TitleText.Text = "Title";
            this.AuthorText.Text = "Author";
            this.DateText.Text = "Date Released";
            this.GenreText.Text = "Genre";
            this.AvailableText.Text = "Number Available";
            this.CHText.Text = "CurrentHolders";
            this.button1.Text = "Submit Changes";
            this.Back.Text = "previouse Page";

            client = new FireSharp.FirebaseClient(config);

        }

        public void EditBook_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISBNtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISBN_TextChanged(object sender, EventArgs e)
        {

        }


        private void EditBook_Load_1(object sender, EventArgs e)
        {

        }

      

        private async void button1_ClickAsync(object sender, EventArgs e)
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
            
            /*
            Librarian lib= new Librarian
            {
                FirstName="bob",
                LastName="ross",
                ID="2324232",
                Password

            }
            */
            SetResponse response = await client.SetTaskAsync(ISBN.Text, data);
            Book results = response.ResultAs<Book>();
        }
    }
}
