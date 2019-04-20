using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace LibrarianAssistant.Login.Screen
{
    public partial class Login : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;

        public Login()
        {
            // this.userNameInput.Select();
            InitializeComponent();
            this.Text = "Login";
            this.passwordInput.LostFocus += new EventHandler(textbox_EndEdit);
            this.userNameInput.LostFocus += new EventHandler(textbox_EndEdit);
            this.errorResponselabel.Visible = false;

            

            // this.passwordInput.Validating += textbox_Validating;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            this.Icon = new Icon(this.Icon, new Size(50, 50));
            this.BackColor = Color.White;
            this.loginButton.BackColor = Color.FromArgb(152, 30, 50);
            this.loginButton.ForeColor = Color.White;
            this.loginButton.Font = new Font("Arial", 15, FontStyle.Bold);
            this.loginButton.FlatAppearance.BorderColor = Color.White;

            this.applicationTitle.Font = new Font("Arial", 17, FontStyle.Bold);
            this.applicationTitle.ForeColor = Color.FromArgb(152, 30, 50);
            this.applicationTitle.Hide();

            this.Size = new Size(872, 495);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.userNameInput.Font = new Font("Arial", 14);
            this.userNameInput.ForeColor = Color.Gray;

            this.passwordInput.Font = new Font("Arial", 14);
            this.passwordInput.ForeColor = Color.Gray;

            this.errorResponselabel.ForeColor = Color.FromArgb(172, 30, 50);
        }

        private bool shouldMoveOnPass = false;
        private bool shouldMoveOnUser = false;

        private void textbox_EndEdit(object sender, EventArgs e)
        {
            string input = ((TextBox)sender).Text;
            string errorMsg = "";

            if (((TextBox)sender).Name == "userNameInput")
            {
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    this.errorResponselabel.Visible = false;
                }
                else
                {
                    // Make the error message a specific message and clear the text.
                    errorMsg = "Incorrect username!";
                    this.errorResponselabel.Visible = true;
                }
            }
            else
            {
                if (Regex.IsMatch(input, @"^[\w]+$"))
                {
                    // We need to check database then the boolean shouldMoveOnUser should be switched to true if the credentials are found in db.
                    this.errorResponselabel.Visible = false;
                }
                else
                {
                    // Make the error message a specific message and clear the text.
                    errorMsg = "Incorrect username!";
                    this.errorResponselabel.Text = errorMsg;
                    this.errorResponselabel.Visible = true;
                }
            }
        }

        private async void loginButton_ClickAsync(object sender, EventArgs e)
        {

       
            string search = this.userNameInput.Text.ToString();
            FirebaseResponse response = await client.GetTaskAsync("Librarian/" + search);
            ApplicationEngine.UserTypes.Librarian lib = response.ResultAs<ApplicationEngine.UserTypes.Librarian>();


            



            if (lib.Password != this.passwordInput.Text.ToString())
            {
                MessageBox.Show("incorrect password");
            }
            else
            {
                //if admin
                Admin.AdminUI.AdminMainScreenUI admin = new Admin.AdminUI.AdminMainScreenUI();
                admin.ShowDialog();
               
                //if libraria
            }






            if (shouldMoveOnPass && shouldMoveOnUser)
            {
                // We need to check database then the boolean shouldMoveOnUser should be switched to true if the credentials are found in db.

                // If db fails then we need to allow the user to reenter the information.
            }


            // Check that the network id box contains a vlaue
            // Password textbox is contains value

            // Query the database to see if the id exits,
            // If it does exist, check the corresponding password in the database is correct.

            // If true, proceed to the next screen
            // else, display appropriate message in teh response box.

        }

        private void userNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
