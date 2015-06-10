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
    public partial class Add_user : Form
    {
        MyDB m = new MyDB();
        public Add_user()
        {
            InitializeComponent();
        }

        private void reg_new_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.ToString();
            string b = textBox2.Text.ToString();
            if (m.reg_user(a, b))
                this.Close();
            

        }


    }
}
