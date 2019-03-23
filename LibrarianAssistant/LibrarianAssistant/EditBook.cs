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
    public partial class EditBook : Form
    {
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
            this.Submit.Text = "Submit Changes";
            this.Back.Text = "previouse Page";
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

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        private void EditBook_Load_1(object sender, EventArgs e)
        {

        }
    }
}
