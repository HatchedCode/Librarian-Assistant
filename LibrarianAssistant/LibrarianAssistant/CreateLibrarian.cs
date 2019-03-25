using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarianAssistant
{
    public partial class CreateLibrarian : Form
    {
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

        }

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
