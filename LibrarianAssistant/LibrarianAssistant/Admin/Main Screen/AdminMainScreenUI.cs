
namespace LibrarianAssistant.Admin.AdminUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class AdminMainScreenUI : Form
    {
        public AdminMainScreenUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LibrarianAssistant.CreateLibrarian create = new CreateLibrarian();

            create.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
