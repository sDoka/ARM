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
    public partial class Orders : Form
    {
        MyDB m = new MyDB();
        int i, k = 0;
        public Orders()
        {
            InitializeComponent();
           // cb1.SelectedIndex = 0;
            cb2.Visible = false;
            label2.Visible = false;
            dgw1.Visible = false;
            this.Width = 291;
            this.Height = 90;
           
            //нужная высота 250
            
           
        }

        private void Заказы_Resize(object sender, EventArgs e)
        {
            dgw1.Width = this.Width-10;

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)//когда выбираем чё ваще хотим
        {
            cb2.Visible = false;
            label2.Visible = false;
            cb2.Items.Clear();
            string s = cb1.SelectedItem.ToString();
            if (s != "Детали комплекта...")
            {
                k = 0;
                DataTable dt = m.show_orders(s).Tables[0];
                dgw1.DataSource = dt;
                if (i == 0)
                {
                    m.form_Heigher(this, 250);
                    m.form_Wider(this, 650);
                    i = 1;
                }

                dgw1.Visible = true;
            }
            else
            {
                i = 0;
                dgw1.Visible = false;
                List<string> temp = m.get_exact_name();
                foreach (var item in temp)
                {
                    cb2.Items.Add(item);
                }
                cb2.Visible = true;
                label2.Visible = true;
                m.form_Wider(this, 485);
                m.form_Heigher(this, 90);
            }



           
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = cb2.SelectedItem.ToString();
           DataTable dt = m.show_exact_order(s).Tables[0];
           dgw1.DataSource = dt;
           if (k == 0)
           {
               m.form_Heigher(this, 260);
               m.form_Wider(this, 540);
               k = 1;
           }

           dgw1.Visible = true;

        }
    }
}
