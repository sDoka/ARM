using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class Personal : Form
    {
        
        MyDB m = new MyDB();
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {

            this.dgw_fill();
          
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           
           
            this.Close();
        }

        private void Personal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
        }

        private void excel_our_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "";

            sfd.DefaultExt = ".csv";
            sfd.Filter = "Файлы Excel (*.xlsx)| *.xlsx; *.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);


                    }
                    catch
                    {
                        MessageBox.Show("Документ открыт в другом приложении. Закройте и повторите попытку.");
                    }
                }

                //вызвать метод для записи из dgw1 -> excel
                MessageBox.Show("Файл сохранен", "Всё ок =)");
            }
        }

        private void dgw1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ((DataGridView)sender).SelectedCells[0].Selected = false;
            }
            catch { }
        }
        private void dgw_fill()
        {
            dgw1.DataSource = m.show_personal().Tables[0];
            int width = dgw1.Width / dgw1.ColumnCount;
            for (int i = 0; i < dgw1.ColumnCount; i++)
                dgw1.Columns[i].Width = width;
        }
    }
}
