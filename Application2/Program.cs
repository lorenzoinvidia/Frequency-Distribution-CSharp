using System;
using System.Windows.Forms;

namespace Application2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Start Window Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form1 = new Form1(); 
            Application.Run(form1);
        }
    }
}
