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
    public partial class AddCardHolder : Form
    {


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;

        public AddCardHolder()
        {
            InitializeComponent();

            client = new FireSharp.FirebaseClient(config);
        }

        private async void submit_ClickAsync(object sender, EventArgs e)
        {
            ApplicationEngine.UserTypes.Cardholder ch= new ApplicationEngine.UserTypes.Cardholder();
            ch.FirstName = this.FirstName.Text;
            ch.LastName = this.LastName.Text;
            ch.ID = Convert.ToUInt32(this.ID.Text.ToString());
            ch.Password = this.Password.Text;

            SetResponse response = await client.SetTaskAsync("CardHolder/" + ch.ID, ch);
            ApplicationEngine.UserTypes.Cardholder results = response.ResultAs<ApplicationEngine.UserTypes.Cardholder>();
        }
    }
}
