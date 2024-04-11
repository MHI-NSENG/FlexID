using System;
using System.Windows.Forms;

namespace FlexID
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
            //new MainWindow().ShowDialog();
        }
    }
}
