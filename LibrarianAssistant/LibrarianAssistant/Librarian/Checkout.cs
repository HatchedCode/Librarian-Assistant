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
    public partial class Checkout : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;


        public Checkout()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private async void Submit_ClickAsync(object sender, EventArgs e)
        {
            string search = this.Title.Text.ToString();
            FirebaseResponse response = await client.GetTaskAsync("Book/" + search);

            ApplicationEngine.Book.Book result = response.ResultAs<ApplicationEngine.Book.Book>();


            string searchCH = this.UserId.Text.ToString();
            FirebaseResponse responseCH = await client.GetTaskAsync("CardHolder/" + searchCH);

            ApplicationEngine.UserTypes.Cardholder resultCH = responseCH.ResultAs<ApplicationEngine.UserTypes.Cardholder>();

            if (result.Available > 0)
            {
                if (result.AddHolder(Convert.ToInt32(this.UserId.Text.ToString())) && resultCH.AddBook(result))
                {
                    result.Available -= 1;
                    SetResponse res = await client.SetTaskAsync("Book/" + result.Title, result);
                    Book results = res.ResultAs<Book>();


                    SetResponse resCH = await client.SetTaskAsync("CardHolder/" + resultCH.ID, resultCH);
                    ApplicationEngine.UserTypes.Cardholder resultsCH = resCH.ResultAs<ApplicationEngine.UserTypes.Cardholder>();
                }
                else
                {
                    MessageBox.Show("User already has book");

                }
               
            }
            else
            {
                MessageBox.Show("None Available");
            }

        }

        private async void returner_ClickAsync(object sender, EventArgs e)
        {
            string search = this.Title.Text.ToString();
            FirebaseResponse response = await client.GetTaskAsync("Book/" + search);

            ApplicationEngine.Book.Book result = response.ResultAs<ApplicationEngine.Book.Book>();

            string searchCH = this.UserId.Text.ToString();
            FirebaseResponse responseCH = await client.GetTaskAsync("CardHolder/" + searchCH);

            ApplicationEngine.UserTypes.Cardholder resultCH = responseCH.ResultAs<ApplicationEngine.UserTypes.Cardholder>();




            if (result.RemoveHolder(Convert.ToInt32(this.UserId.Text.ToString()))&&resultCH.ReturnBook(result))
            {
               
                result.Available += 1;
                SetResponse res = await client.SetTaskAsync("Book/" + result.Title, result);
                Book results = res.ResultAs<Book>();
                SetResponse resCH = await client.SetTaskAsync("CardHolder/" + resultCH.ID, resultCH);

                ApplicationEngine.UserTypes.Cardholder resulCH = resCH.ResultAs<ApplicationEngine.UserTypes.Cardholder>();

            }
            else
            {
                MessageBox.Show("User should not have this book");
            }
        }
    }
}
