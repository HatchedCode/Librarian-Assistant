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
    }
}
