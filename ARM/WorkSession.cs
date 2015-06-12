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
        MyDB m = new MyDB();
        public WorkSession()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            List<TimeSpan> ts = new List<TimeSpan>();
            DateTime s = dtStart.Value;
            DateTime f = dtEnd.Value;
          DataTable dt = m.show_me_worktime(s,f).Tables[0];
          for (int i = 0; i < dt.Rows.Count; i++ )
          {
           TimeSpan   cur = (Convert.ToDateTime(dt.Rows[i][2]) - Convert.ToDateTime(dt.Rows[i][1]));
           ts.Add(cur);
          }
          TimeSpan sum = TimeSpan.Zero;
          foreach (TimeSpan elem in ts)
          {
              sum += elem;
          }
          string hour, min, sec;
          string[] time = sum.ToString().Split(':');
          hour = time[0];
          min = time[1];
          sec = time[2];
          l3.Visible = true;
          ll1.Visible = true;
          ll1.Text += " "+hour+" часов "+min+" минут "+sec+" секунд";
             //this.Close();

        }
    }
}
