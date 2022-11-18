using System;
using System.Windows.Forms;

namespace Corrupt_Your_Own_Files
{
    internal static class Program
    {
        /// <summary>Punto de entrada principal para la aplicación.</summary>
        [STAThread]
        
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
    }
}
