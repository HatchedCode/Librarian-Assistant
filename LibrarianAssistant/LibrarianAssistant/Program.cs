using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarianAssistant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new LibrarianAssistant.Admin.CreateAdmin.CreateAdmin());
            Application.Run(new LibrarianAssistant.Librarian.ViewUsers());

            //Application.Run(new LibrarianAssistant.Login.Screen.Login());

            // Application.Run(new MainForm());
        }
    }
}
