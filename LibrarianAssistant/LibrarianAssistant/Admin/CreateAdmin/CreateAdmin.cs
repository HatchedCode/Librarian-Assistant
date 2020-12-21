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

namespace LibrarianAssistant.Admin.CreateAdmin
{
    public partial class CreateAdmin : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;

        public CreateAdmin()
        {
            InitializeComponent();

            this.registerButton.BackColor = Color.FromArgb(172, 30, 50);
            this.adminregistrationLabel.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        private void CreateAdmin_Load(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config);
            this.BackColor = Color.White;
        }

        private void textbox_EndEdit(object sender, EventArgs e)
        {

        }

            private async void registerButton_ClickAsync(object sender, EventArgs e)
        {
            // Check each field
            // Check passwords
            // Check database for Network ID
            // Check name is not already associated with a NetworkID


            // All of the stuff below should be done in the handlers else where.

            // Check Nothing is null

            // Check that the passwords match

            // Check Network ID is valid 8/9 digit ID number

            ApplicationEngine.UserTypes.Librarian daa = new ApplicationEngine.UserTypes.Librarian
            {

                FirstName = this.textBox1.Text,
                LastName = this.textBox2.Text,
                ID = Convert.ToUInt32(this.textBox3.Text),
                Password = this.textBox4.Text


            };
            daa.Level = Convert.ToInt32( this.comboBox1.Text.ToString());


            SetResponse response = await client.SetTaskAsync(daa.ID.ToString(), daa);
            ApplicationEngine.UserTypes.Librarian results = response.ResultAs<ApplicationEngine.UserTypes.Librarian>();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
