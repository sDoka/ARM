using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace ARM
{
    class fuckExcel
    {
        public void open_file(string path)
        {
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open(path);
            excel.Visible = true;
        }
    }
}
