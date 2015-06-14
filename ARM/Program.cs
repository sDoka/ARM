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
              // s = "";
                if (s == "True")
                {
                    Application.Run(new WelcomeForm());

                }
                else if (s=="False")
                    Application.Run(new LoginPage());
            else
            {
                if (MessageBox.Show("Установите SQL LocalDB для вашей ОС", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.microsoft.com/ru-ru/download/details.aspx?id=29062");
                }
                Application.Exit();
            }

        }
    }
}
