using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AllScreens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}


namespace LibrarianAssistant
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            //this.FormClosed +=
            //   new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //(new Form2()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // (new Form2()).Show();
            //   this.Close();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form2());

          //  this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            (new EditBook()).Show();
            (new CreateLibrarian()).Show();
        }
    }
}