using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class LoginPage : Form
    {
       
        MyDB m = new MyDB();
        
        public LoginPage()
        {
          
            InitializeComponent();
           
           
        }

        private void adminEntrance_Click(object sender, EventArgs e)
        {
            string a = LoginTB.Text.ToString();
            string b = PassTB.Text.ToString();
            if (m.check_user(a, b) == false)
            {
                MessageBox.Show("Неверный логин/пароль");
            }
            else
            {
                AdminForm af = new AdminForm();
                af.Show();
                this.Hide();
            }

        }

        private void GuestEntrance_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
     
        }

        private void reg_ll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            super_admin_check s = new super_admin_check();
            s.Show();
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                Application.Exit();
            }
            catch //(Exception ex)
            {
                Application.ExitThread();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {


                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.once_more();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Установите SQL LocalDB для вашей ОС", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.microsoft.com/ru-ru/download/details.aspx?id=29062");
            }
        }


    }
}
