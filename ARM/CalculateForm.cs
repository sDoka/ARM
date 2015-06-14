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
        string headers;
        MyDB m = new MyDB();
        string s = "";
        public CalculateForm(string Table)
        {
           
            InitializeComponent();
            this.Height = 188;
            save_btn.Enabled = false;
            s = Table;
            this.Text += " для " + s + "";
            dgw1.Visible = false;
            this.what_is_it();

        }
        private void what_is_it()
        {
            switch (s)
            {
                case "Прямик"://headers- потом передать в функцию инсерта
                    headers = "[Наименование заготовки],[Материал заготовки],[Длина заготовки],[Ширина заготовки],[Высота заготовки],[Площадь]";
                    form_width = 800;
                    this.pramik();
                    break;
                case "Зонт трапецевидный":
                    headers = "[Наименование заготовки],[Материал заготовки],[Длина нижнего основания],[Длина верхнего основания],[Высота трапеции],[Площадь]";
                    form_width = 700;
                    this.trapec();
                    break;
                case "Зонт конусообразный":
                    headers = "[Наименование заготовки],[Материал заготовки],[Радиус круга],[Угол вырезаемого сегмента],[Площадь]";
                    form_width = 710;
                    this.konus();
                    break;
                case "Зонт пирамидный":
                    headers = "[Наименование заготовки],[Материал заготовки],[Длина первого основания],[Длина второго основания],[Высота треугольника],[Площадь]";
                    form_width = 820;
                    this.piramid();
                    break;
                case "Переход центровой":
                    headers = "[Наименование заготовки],[Материал заготовки],[Длина нижнего основания],[Длина верхнего основания],[Высота трапеции],[Площадь]";
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
            double L = Convert.ToDouble(tb1.Text) / 1000;
            double B = Convert.ToDouble(tb2.Text) / 1000;
            double H = Convert.ToDouble(tb3.Text) / 1000;
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
            double A = Convert.ToDouble(tb1.Text) / 1000;
            double B = Convert.ToDouble(tb2.Text) / 1000;
            double H = Convert.ToDouble(tb3.Text) / 1000;
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
            double R = Convert.ToDouble(tb1.Text) / 1000;
            double A = Convert.ToDouble(tb2.Text);
            if (A > 180)
            {
                MessageBox.Show("Угол не может быть более 180 градусов!");
                return;
            }
                
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
            double A = Convert.ToDouble(tb1.Text) / 1000;
            double B = Convert.ToDouble(tb2.Text) / 1000;
            double H = Convert.ToDouble(tb3.Text) / 1000;
            formula = ((0.5) * A * H) * 2 + ((0.5) * B * H) * 2;

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
            double A = Convert.ToDouble(tb1.Text) / 1000;
            double B = Convert.ToDouble(tb2.Text) / 1000;
            double H = Convert.ToDouble(tb3.Text) / 1000;
            formula = ((((A * B) / 2)) * H) * 4;
        }

        private void add_newBtn_Click(object sender, EventArgs e)
        {
            this.count_it();
            res_lbl.Text = "Площадь заготовки";
            ll1.Text = formula.ToString("0.####") + " м^2";
            this.save_btn.Enabled = true;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (formula != 0)
            {
                tb1.Enabled = false;
                tb2.Enabled = false;
                tb3.Enabled = false;
                m.form_Heigher(this, 260);
            }
            else { MessageBox.Show("Расчёты не произведены, нечего сохранять"); }

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

        private void okbTN_Click(object sender, EventArgs e)//вызывает запись измерений в базу
        {

            //собрать строку инпута
            StringBuilder sb = new StringBuilder();
            if (s!="Зонт конусообразный")
                sb.Append(name_zag.Text.ToString() + "','" + mat_zag.Text.ToString() + "','" + tb1.Text.ToString() + "','" + tb2.Text.ToString() + "','" + tb3.Text.ToString() + "','" + formula.ToString("0.####"));
            else
                sb.Append(name_zag.Text.ToString() + "','" + mat_zag.Text.ToString() + "','" + tb1.Text.ToString() + "','" + tb2.Text.ToString() + "','" + formula.ToString("0.####"));
            string input = sb.ToString();//почему то не вставляет неровные запросы 45,1599
            m.universal_insert(s, headers, input);
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
            m.form_Heigher(this, 180);
             string[] args;
             if (s!="Зонт конусообразный")
                   args = new string[]{ name_zag.Text.ToString(),mat_zag.Text.ToString(), tb1.Text.ToString() +"x"+tb2.Text.ToString()+"x"+tb3.Text.ToString(), formula.ToString("0.####"),s };
             else 
                 args = new string[]{ name_zag.Text.ToString(),mat_zag.Text.ToString(), tb1.Text.ToString() ,tb2.Text.ToString(), formula.ToString("0.####"),s };
           //  System.Threading.Thread.Sleep(20);
             NewOrderForm nog = new NewOrderForm(args);
            // MessageBox.Show("Расчёт добавлен");
             nog.Show();
             this.Close();

        }








    }
}
