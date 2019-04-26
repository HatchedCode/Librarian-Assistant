using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LibrarianAssistant.Librarian
    
{
    public partial class LibrarianMain : Form
    {
        public LibrarianMain()
        {
            InitializeComponent();
            this.label1.Font = new Font("Arial", 24, FontStyle.Bold);
            this.label1.Text = "Main Menu";

            this.label1.Font = new Font("Arial", 18, FontStyle.Bold);
            this.loggedInUserNameLabel.Text = "Welcome, " + "Zane";

            this.BackColor = Color.White;

            this.SearchBook.BackColor = Color.FromArgb(152, 30, 50);
            this.SearchBook.ForeColor = Color.White;

            this.addbook.BackColor = Color.FromArgb(152, 30, 50);
            this.addbook.ForeColor = Color.White;

            this.Checkout.BackColor = Color.FromArgb(152, 30, 50);
            this.Checkout.ForeColor = Color.White;

            this.editBookButton.BackColor = Color.FromArgb(152, 30, 50);
            this.editBookButton.ForeColor = Color.White;

        }

        private void addbook_Click(object sender, EventArgs e)
        {
            Librarian.AddBook add = new Librarian.AddBook();
            add.ShowDialog();
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            Librarian.SearchBookcs search = new Librarian.SearchBookcs();
            search.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LibrarianAssistant.EditBook edit = new EditBook();
            edit.ShowDialog();
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            LibrarianAssistant.Librarian.Checkout check = new Librarian.Checkout();
            check.ShowDialog();
        }

        private void LibrarianMain_Load(object sender, EventArgs e)
        {

        }

        private void AddHolder_Click(object sender, EventArgs e)
        {
            AddCardHolder addCH = new AddCardHolder();
            addCH.ShowDialog();
        } 

        private void SearchUser_Click(object sender, EventArgs e)
        {
            SearchUser searchU = new SearchUser();
            searchU.ShowDialog();
        }
    }
}
