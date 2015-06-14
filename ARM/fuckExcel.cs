using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ARM
{
    class fuckExcel
    {
        public void open_file(string path)
        {
            Application Excel = new Application();
            Workbook wb = Excel.Workbooks.Open(path);
            Excel.Visible = true;
        }
    }
}
