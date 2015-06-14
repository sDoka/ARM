using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyDB m = new MyDB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string s = m.first_start();
            if (s == "True")
            {
                Application.Run(new WelcomeForm());

            }
            else
            Application.Run(new LoginPage());
        }
    }
}
