using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class Ketnoi
    {
        SqlConnection con= new SqlConnection("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        public DataTable Load_DL(string sql)
        {
            con.Open();
            SqlDataAdapter ad= new SqlDataAdapter(sql,con);
           
            DataTable dt = new DataTable();
            ad.Fill(dt);
          
            //SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
            con.Close();
            return dt;
        }
        public void Execute(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
