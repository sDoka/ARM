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
    public partial class WorkSession : Form
    {
        public WorkSession()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }
    }
}
