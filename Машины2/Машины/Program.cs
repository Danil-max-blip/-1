using System;
using System.Windows.Forms;

namespace CarsharingApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Программа всегда стартует с окна входа
            Application.Run(new LoginForm());
        }
    }
}
