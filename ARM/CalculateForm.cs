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
    public partial class CalculateForm : Form
    {
        int form_width;
        const double p = 3.14;
        double formula;
        MyDB m = new MyDB();
        string s = "";
        public CalculateForm(string Table)
        {
           
            InitializeComponent();
            
            s = Table;
            this.Text += " для " + s + "";
            dgw1.Visible = false;
            this.what_is_it();

        }
        private void what_is_it()
        {
            switch (s)
            {
                case "Прямик":
                    form_width = 800;
                    this.pramik();
                    break;
                case "Зонт трапецевидный":
                    form_width = 700;
                    this.trapec();
                    break;
                case "Зонт конусообразный":
                    form_width = 710;
                    this.konus();
                    break;
                case "Зонт пирамидный":
                    form_width = 820;
                    this.piramid();
                    break;
                case "Переход центровой":
                    form_width = 710;
                    this.centr();
                    break;
                   

            }
            
        }

        private void count_it()
        {
            if (tb1.Text != "" && tb2.Text!= "")
            switch (s)
            {
                case "Прямик":
                    this.pramik_f();
                    break;
                case "Зонт трапецевидный":
                    this.trapec_f();
                    break;
                case "Зонт конусообразный":
                    this.konus_f();
                    break;
                case "Зонт пирамидный":
                    this.piramid_f();
                    break;
                case "Переход центровой":
                    this.centr_f();
                    break;
            }
            else { MessageBox.Show("Введены не все значения"); }
        }
        private void pramik()
        {
           // S=L*B*H
            l1.Text = "Длина заготовки (мм)";
            l2.Text = "Ширина заготовки (мм)";
            l3.Text = "Высота заготовки (мм)";


        }
        private void pramik_f()
        {
            double L = Convert.ToDouble(tb1.Text) / 100;
            double B = Convert.ToDouble(tb2.Text) / 100;
            double H = Convert.ToDouble(tb3.Text) / 100;
            formula = L * B * H;
        }
        private void trapec()
        {
            //S=(((A*B)/2))*H)*4)
            l1.Text = "Длина нижнего основания (мм)";
            l2.Text = "Ширина верхнего основания (мм)";
            l3.Text = "Высота трапеции (мм)";

        }
        private void trapec_f()
        {
            double A = Convert.ToDouble(tb1.Text) / 100;
            double B = Convert.ToDouble(tb2.Text) / 100;
            double H = Convert.ToDouble(tb3.Text) / 100;
            formula = ((((A * B) / 2)) * H) * 4;

        }
        private void konus()
        {
           // S=(πR^2)-(((πR^2)/360)*A)
            l1.Text = "Радиус круга (мм)";
            l2.Text = "Угол вырезаемого сегмента";
            l3.Text = "";
            tb3.Visible = false;

        }
        private void konus_f()
        {
            double R = Convert.ToDouble(tb1.Text) / 100;
            double A = Convert.ToDouble(tb2.Text);
            formula = (p * R * R) - (((p * R * R) / 360) * A);
        }
        private void piramid()
        {
          // S=(((1/2)*A*H)*2)+(((1/2)*B*H)*2)
            l1.Text = "Длина первого основания (мм)";
            l2.Text = "Длина второго основания (мм)";
            l3.Text = "Высота треугольника (мм)";

        }
        private void piramid_f()
        {
            double A = Convert.ToDouble(tb1.Text) / 100;
            double B = Convert.ToDouble(tb2.Text) / 100;
            double H = Convert.ToDouble(tb3.Text) / 100;
            formula = ((1 / 2) * A * H) * 2 + ((1 / 2) * B * H) * 2;

        }
        private void centr()
        {
           // S=(((A*B)/2))*H)*4)
            l1.Text = "Длина нижнего основания (мм)";
            l2.Text = "Длина верхнего основания (мм)";
            l3.Text = "Высота трапеции (мм)";
        }
        private void centr_f()
        {
            double A = Convert.ToDouble(tb1.Text) / 100;
            double B = Convert.ToDouble(tb2.Text) / 100;
            double H = Convert.ToDouble(tb3.Text) / 100;
            formula = ((((A * B) / 2)) * H) * 4;
        }

        private void add_newBtn_Click(object sender, EventArgs e)
        {
            this.count_it();
            res_lbl.Text = "Площадь заготовки";
                ll1.Text = formula.ToString() +" м^2";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void showReadybtn_Click(object sender, EventArgs e)
        {
           
            DataSet ds =  m.universal_select(s) ;
            if (ds != null)
            {
                dgw1.DataSource = m.universal_select(s).Tables[0];
                if (dgw1.Visible == true)
                {
                    dgw1.Visible = false;
                    m.form_Wider(this, 500);
                }

                else
                {
                    m.form_Wider(this, form_width);
                    dgw1.Visible = true;
                }
                   
               
            }

        }






    }
}
