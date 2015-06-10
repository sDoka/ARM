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
    public partial class super_admin_check : Form
    {
        public super_admin_check()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "12345")
            {
                Add_user ad = new Add_user();
                ad.Show();
                this.Close();
            }
                
        }
    }
}
