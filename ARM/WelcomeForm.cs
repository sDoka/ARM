using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class WelcomeForm : Form
    {
        MyDB m = new MyDB();
        public WelcomeForm()
        {
            InitializeComponent();
            this.Height = 0;
            
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            
        }
        private void check_Net()//конечно прикольно, но нафиг он нужен, если прога просто не запустится без дот нета
        {
          
            var keyName = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Client";
            var key = Registry.LocalMachine.OpenSubKey(keyName);
            // если ключа нет, тут будет null – значит фреймворк не установлен
            if (key != null)
            {
                //  var version = (string)key.GetValue("Version");
                var installed = (int)key.GetValue("Install");
               
                // проверяем значения
                if (installed == 1)
                {
                    MessageBox.Show(" .Net Framework установлен");
                }
            }
        }

       

        private void WelcomeForm_Shown(object sender, EventArgs e)
        {
           // Thread.Sleep(1500);
            
            for (int i= 0; i< 160;i++)
            {
                this.Height += 1;
                this.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверка успешно завершена, программа готова к работе.");
            this.Close();
            m.no_more();
            Application.Restart();            
            
        }

    }
}
