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
using System.Data.Sql;

namespace ARM
{
   public class MyDB
    {
      

       public MyDB()
       {
          
       }
        SqlConnection MyConnection = new SqlConnection("Data Source=Doka;Initial Catalog=ARM;Integrated Security=True;" +
                                                          "Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
      //  SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ARM.mdf;Integrated Security=True;Connect Timeout=30");




       SqlDataAdapter da = new SqlDataAdapter();


       public bool check_user(string a, string b)
       {

           MyConnection.Open();
           DataSet ds1 = new DataSet();
          // SqlDataAdapter da = new SqlDataAdapter("Use ARM Exec check_user '" + a + "','" + b + "'", MyConnection);
           SqlDataAdapter da = new SqlDataAdapter("select [Login],[Password] From dbo.Users WHERE (login='"+a+"' AND Password = '"+b+"')",MyConnection);

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
             //  string sql = "use ARM exec add_admin '"+a+"','"+b+"'";
               string sql = " insert into dbo.Users (Login, Password) values ('"+a+"','"+b+"')";
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
          // SqlDataAdapter da = new SqlDataAdapter("Use ARM Exec show_personal", MyConnection);
           SqlDataAdapter da = new SqlDataAdapter(" SELECT * from dbo.[Персонал]", MyConnection);
           da.Fill(ds, "Workers");
           MyConnection.Close();
           return ds;

       }



       public void add_worksession( string s,string f)
       {
           try
           {
               MyConnection.Open();
             //  string sql = "use ARM exec add_work '" + s +"','" + f + "'";
               string sql = " insert into dbo.[WorkSessions] ([Начало работы],[Конец работы]) values ('" + s + "','" + f + "')";
                          
               da.InsertCommand = new SqlCommand(sql, MyConnection);
               da.InsertCommand.ExecuteNonQuery();
               MyConnection.Close();
           }
           catch
           { MyConnection.Close(); }

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



       public void universal_insert(string tablename, string headers, string input)//шаблон для вставки headers- набор столбцов, input- набор ячеек
       {
          //нам нужен набор столбцов и набор ячеек для вставки


           try
           {
               MyConnection.Open();
               string sql = " Insert into dbo.[" + tablename + "] (" + headers + ") values ('" + input + "') ";
               da.InsertCommand = new SqlCommand(sql, MyConnection);
               da.InsertCommand.ExecuteNonQuery();
               MyConnection.Close();
               MessageBox.Show("Расчёт добавлен");
           }
           catch { MessageBox.Show("Не удалось выполнить вставку"); return; }



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

              public void form_Heigher(Form f, int w)//альтернативная анимация изменения формы. активная
              {
                  if (f.Height < w)
                      for (int i = f.Height; f.Height < w; i++)//если текущая высота меньше - увеличиваем
                      {
                          f.Height = f.Height + 5;
                          f.Refresh();
                      }
                  else if (f.Height > w)
                      for (int i = w; f.Height > w; i++)//если больше- уменьшаем
                      {
                          f.Height = f.Height - 5;
                          f.Refresh();
                      }
              }


       public DataSet show_me_worktime(DateTime s, DateTime f)
              {
                    
                  try
                  {
                      MyConnection.Open();
                      DataSet ds = new DataSet();
                      SqlDataAdapter da = new SqlDataAdapter("Select * From [dbo].[WorkSessions]", MyConnection);
                      da.Fill(ds, "Sessions");
                      MyConnection.Close();
                      return ds;

                  }
                  catch
                  {
                      MessageBox.Show("Произошла ошибка вывода");
                      return null;
                  }
              }
       public DataSet show_orders(string s)
       {
           MyConnection.Open();
           DataSet ds = new DataSet();
         try
             {
              switch (s)
               {
               case "Все заказы":
                       da = new SqlDataAdapter("Select [Наименование],[Материал],[Размеры изделия],[Площадь заготовки],[Количество][Примечание],[Ответственный] From [dbo].[Заказы]", MyConnection);
                   break;
               case "Выполненные заказы":
                   da = new SqlDataAdapter("Select [Наименование],[Материал],[Размеры изделия],[Площадь заготовки],[Количество][Примечание],[Ответственный] From [dbo].[Заказы] Where ([Статус] = 1)", MyConnection);
                   break;
               case "Заказы в производстве":
                   da = new SqlDataAdapter("Select [Наименование],[Материал],[Размеры изделия],[Площадь заготовки],[Количество][Примечание],[Ответственный] From [dbo].[Заказы] Where ([Статус] = 0)", MyConnection);
                   break;

           }
               da.Fill(ds, "Sessions");
               MyConnection.Close();
               return ds;

           }
           catch
           {
               MessageBox.Show("Произошла ошибка вывода");
               return null;
           }
       }

       public List<string> get_exact_name()
       {
           List<string> ls = new List<string>();
           try
           {
               MyConnection.Open();
               DataSet ds = new DataSet();
               SqlDataAdapter da = new SqlDataAdapter("Select [Наименование] From [dbo].[Заказы]", MyConnection);
               da.Fill(ds, "Names");
               MyConnection.Close();
               DataTable dt = ds.Tables[0];
               for (int i = 0; i < dt.Rows.Count; i++)
                   ls.Add(dt.Rows[i][0].ToString().Trim());
               ls = ls.Distinct().ToList();
                   return ls;

           }
           catch
           {
               MessageBox.Show("Произошла ошибка вывода");
               ls.Add("Не удалось загрузить список");
               return ls;

           }
       }

       public DataSet show_exact_order(string s)
       {
           try
                  {
                      MyConnection.Open();
                      DataSet ds = new DataSet();
                      da = new SqlDataAdapter("Select [Материал],[Размеры изделия],[Площадь заготовки],[Количество][Примечание],[Ответственный] From [dbo].[Заказы] where ( [Наименование] = '"+s+"')", MyConnection);
                      da.Fill(ds, "Sessions");
                      MyConnection.Close();
                      return ds;

                  }
                  catch
                  {
                      MessageBox.Show("Произошла ошибка вывода");
                      return null;
                  }
       }


    }
}
