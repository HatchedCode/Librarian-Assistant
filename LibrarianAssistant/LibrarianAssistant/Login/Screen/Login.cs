using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarianAssistant.Login.Screen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Login";
        }

        private void Login_Load(object sender, EventArgs e)
        {
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

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
