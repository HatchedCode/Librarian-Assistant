using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace LibrarianAssistant
{
    public partial class SearchUser : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;


        public SearchUser()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            string searchCH = this.SearchID.Text.ToString();
            FirebaseResponse responseCH = await client.GetTaskAsync("CardHolder/" + searchCH);

            ApplicationEngine.UserTypes.Cardholder resultCH = responseCH.ResultAs<ApplicationEngine.UserTypes.Cardholder>();

            this.FirstName.Text = resultCH.FirstName;
            this.LastName.Text = resultCH.LastName;
            this.Password.Text = resultCH.Password;

            string y = "";
            foreach( string x in resultCH.Books)
            {
                y = y + x.ToString() + "\r\n";
            }
            this.Books.Text = y;
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }
    }
}
