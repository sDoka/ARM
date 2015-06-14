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

            m.save_to_excel(dgw1,"workers");
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
            fioCB.Items.Clear();
            dgw1.DataSource = m.show_personal().Tables[0];
            int width = dgw1.Width / dgw1.ColumnCount;
            for (int i = 0; i < dgw1.ColumnCount; i++)
                dgw1.Columns[i].Width = width;
            DataTable dt = m.show_personal().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fioCB.Items.Add(dt.Rows[i][0]);
            }
            fioCB.SelectedIndex = 0;
        }

        private void fire_workerBTN_Click(object sender, EventArgs e)
        {
            string s = fioCB.SelectedItem.ToString();
            m.fire_worker(s);
            
            this.dgw_fill();
        }

        private void hireBTN_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb4.Text == "" || tb5.Text == "" || tb6.Text == "" || tb7.Text == "")
            {
                MessageBox.Show("Заполнены не все поля");

            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(tb1.Text + "','" + tb2.Text + "','" + tb3.Text + "','" + tb4.Text + "','" + tb5.Text + "','" + tb6.Text + "','" + tb7.Text);
                string s = sb.ToString();
                m.hire_worker(s);
                dgw1.DataSource = null;
                this.dgw_fill();
                dgw1.Visible = true;

            }


        }

        private void new_workerBTN_Click(object sender, EventArgs e)
        {
            dgw1.Visible = false;
        }
    }
}
