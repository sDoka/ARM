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
    public partial class AdminForm : Form
    {

        string s = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
        MyDB m = new MyDB();
        
        
        string f;//время завершения работы
        string input;
     
        public AdminForm()
        {
            InitializeComponent();
           
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            f = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");

            m.add_worksession(s,f);
            

           LoginPage lp = new LoginPage();
           lp.Show();
        }

        private void excel_export_Click(object sender, EventArgs e)//выгрузка в ексель
        {

        }

        private void workers_Click(object sender, EventArgs e)
        {
           
            Personal p = new Personal();
            p.Show();
        }

        private void raschet_Click(object sender, EventArgs e)
        {

        }

        private void findFileBnt_Click(object sender, EventArgs e)//поиск файлов excel через проводник
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.FileName = "";
            sfd.Title = "Выберите файл";
            sfd.DefaultExt = "xls";
            sfd.Filter = "Файлы excel | *.xls; *.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fuckExcel fe = new fuckExcel();
                input = sfd.FileName.ToString();
                fe.open_file(input);

            }
                
           
        }

        private void workSessionBtn_Click(object sender, EventArgs e)
        {
            WorkSession ws = new WorkSession();
            ws.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_orderBTN_Click(object sender, EventArgs e)
        {
            NewOrderForm nof = new NewOrderForm();
            nof.Show();
        }






    }
}
