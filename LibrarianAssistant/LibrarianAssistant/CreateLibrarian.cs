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

    public partial class CreateLibrarian : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;



        public CreateLibrarian()
        {
            InitializeComponent();
            this.FirstNameText.Text = "First Name";
            this.LastNameText.Text = "Last Name";
            this.IDText.Text = "ID";
            this.PasswordText.Text = "Enter Password";
            this.RePasswordText.Text = "ReEnter Password";
            this.Back.Text = "Go Back";
            this.Submit.Text = "Submit";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateLibrarian_Load(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config);

          
        }

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
        }

            private async void Submit_Click(object sender, EventArgs e)
        {
            var data = new Librarian
            {
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                ID = ID.Text,
                Password = Password.Text
            };

            SetResponse response = await client.SetTaskAsync(ID.Text, data);
            Librarian results = response.ResultAs<Librarian>();
 
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
