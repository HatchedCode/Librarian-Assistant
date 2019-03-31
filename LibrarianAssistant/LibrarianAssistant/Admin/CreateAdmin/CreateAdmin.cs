using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarianAssistant.Admin.CreateAdmin
{
    public partial class CreateAdmin : Form
    {
        public CreateAdmin()
        {
            InitializeComponent();

            this.registerButton.BackColor = Color.FromArgb(172, 30, 50);
            this.adminregistrationLabel.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        private void CreateAdmin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void textbox_EndEdit(object sender, EventArgs e)
        {

        }

            private void registerButton_Click(object sender, EventArgs e)
        {
            // Check each field
            // Check passwords
            // Check database for Network ID
            // Check name is not already associated with a NetworkID


            // All of the stuff below should be done in the handlers else where.

            // Check Nothing is null

            // Check that the passwords match

            // Check Network ID is valid 8/9 digit ID number


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
