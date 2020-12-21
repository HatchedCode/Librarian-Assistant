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
    using ApplicationEngine;
    using ApplicationEngine.UserTypes;


    public partial class CreateLibrarian : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;

        DataBase data = new DataBase();



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
            ApplicationEngine.UserTypes.Librarian daa = new ApplicationEngine.UserTypes.Librarian
            {
                
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                ID = Convert.ToUInt32( ID.Text),
                Password = Password.Text
                
                
            };
            daa.Level = 0;

            //SetResponse response = await client.SetTaskAsync(daa.ID.ToString(), daa);
            //ApplicationEngine.UserTypes.Librarian results = response.ResultAs<ApplicationEngine.UserTypes.Librarian>();

           data.AddAsync(daa.ID.ToString(), daa);

           
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

        private async void button1_ClickAsync(object sender, EventArgs e)
        {

              string search = this.ID.Text.ToString();
             FirebaseResponse response = await client.GetTaskAsync(search);
            ApplicationEngine.UserTypes.Librarian lib = response.ResultAs<ApplicationEngine.UserTypes.Librarian>();
          //  data.search("Librarian", this.ID.Text.ToString());
           // ApplicationEngine.UserTypes.Librarian lib = data.GetLibrarian("Librarian", this.ID.Text.ToString());
         
            this.ID.Text = lib.ID.ToString();
            this.FirstName.Text = lib.FirstName.ToString();
            this.LastName.Text = lib.LastName.ToString();
            lib = data.GetLibrarian("Librarian", this.ID.Text.ToString());
         
        }

        public void dooer()
        {

    
        }
        
    }
}
