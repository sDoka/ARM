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
    public partial class NewOrderForm : Form
    {
        MyDB m = new MyDB();
        public  NewOrderForm()
        {
           
            InitializeComponent();
            

            cb1.SelectedIndex = 0;
        }
        public NewOrderForm(string[] args)
        {
            InitializeComponent();
            cb1.Enabled = false;
            raschet.Enabled = false;
            DataTable dt = m.show_personal().Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                workresCB.Items.Add(dt.Rows[i][0]);
            }
            workresCB.SelectedIndex = 0;
              if (args.Count() == 5)//все кроме конуса
              {
                  
                  nameTB.Text = args[0].ToString();//не хочет падла((( доделать
                  matTB.Text = args[1];
                  sizeTB.Text = args[2];
                  sTB.Text = args[3];
                  typeTB.Text = args[4];
              }
              else
              {//для конуса

              }
            //список рабочих
          
            //workresCB.Items.AddRange(da.Columns[1]);
        }


        

        private void raschet_Click(object sender, EventArgs e)
        {
            string s = cb1.SelectedItem.ToString();

            CalculateForm calc = new CalculateForm(s);
            calc.Show();
            this.Close();

        }


    }
}
