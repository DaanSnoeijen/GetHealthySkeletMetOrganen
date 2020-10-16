using System;
using System.Windows.Forms;

namespace GetHealthySkelet
{
    static class Program
    {
        public static GebruikerContainer gc = new GebruikerContainer();
        public static InvoerContainer ic = new InvoerContainer();
        public static UitkomstContainer uc = new UitkomstContainer();
        public static ProductContainer pc = new ProductContainer();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Home f1 = new Home();
            f1.Show();
            Application.Run();
        }
    }
}
