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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Librarian.LibrarianMain library = new Librarian.LibrarianMain();
            library.ShowDialog();
        }
    }
}
