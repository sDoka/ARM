using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ARM
{
   public class MyDB
    {
      

       public MyDB()
       {
          
       }
        SqlConnection MyConnection = new SqlConnection("Data Source=DOKA;Initial Catalog=ARM;Integrated Security=True;" +
                                                            "Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        SqlDataAdapter da = new SqlDataAdapter();


       public bool check_user(string a, string b)
       {

           MyConnection.Open();
           DataSet ds1 = new DataSet();
           SqlDataAdapter da = new SqlDataAdapter("Use ARM Exec check_user '" + a + "','" + b + "'", MyConnection);
           da.Fill(ds1, "Res");
           MyConnection.Close();
           if (ds1.Tables["Res"].Rows.Count == 0)
               return false;
           else
               return true;
       }
       public bool reg_user(string a, string b)
       {
           MyConnection.Open();
           DataSet ds1 = new DataSet();
           try
           {
               string sql = "use ARM exec add_admin '"+a+"','"+b+"'";
               da.InsertCommand= new SqlCommand(sql, MyConnection);
               da.InsertCommand.ExecuteNonQuery();
               MessageBox.Show("Новый администратор успешно зарегистрирован");
               MyConnection.Close();
               return true;

           }
           catch
           {
               MessageBox.Show("Невозможно добавить пользователя.");
               MyConnection.Close();
               return false;
           }
          

       }

       public DataSet show_personal()
       {
           MyConnection.Open();
           DataSet ds = new DataSet();
           SqlDataAdapter da = new SqlDataAdapter("Use ARM Exec show_personal", MyConnection);
           da.Fill(ds, "Workers");
           MyConnection.Close();
           return ds;

       }



       public void add_worksession( string s,string f)
       {
           try
           {
               MyConnection.Open();
               string sql = "use ARM exec add_work '" + s +"','" + f + "'";
               da.InsertCommand = new SqlCommand(sql, MyConnection);
               da.InsertCommand.ExecuteNonQuery();
               MyConnection.Close();
           }
           catch
           { }

       }
       public DataSet universal_select(string s)
       {
           try
           {
               MyConnection.Open();
               DataSet ds = new DataSet();
               SqlDataAdapter da = new SqlDataAdapter("Select * From dbo.["+s+"]", MyConnection);
               da.Fill(ds, "Workers");
               MyConnection.Close();
               return ds;

           }
           catch
           {
               MessageBox.Show("Произошла ошибка отображения");
               return null; 
           }
       }

       public void form_Wider(Form f, int w)//альтернативная анимация изменения формы. активная
       {
          if (f.Width < w)
           for (int i = f.Width; f.Width < w; i++)//если текущая ширина меньше - увеличиваем
           {
               f.Width = f.Width + 5;
               f.Refresh();
           }
          else if (f.Width > w)
              for (int i = w; f.Width > w; i++)//если больше- уменьшаем
              {
                  f.Width = f.Width - 5;
                  f.Refresh();
              }
          

       }
    }
}
