using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class Phucap_DAL:Ketnoi
    {
        public Phucap_DAL() { }
        public DataTable Load_DL()
        {
            return Load_DL("select * from Phu_cap");
        }
        string connection = ("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        public void Insert_Phucap(Phu_cap ob)
        {
            string sql = "INSERT INTO Phu_cap (Ma_phu_cap, He_so_phu_cap,He_so_luong) VALUES (@Maphucap, @Hesophucap, @Hesoluong)";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Maphucap", ob.Ma_phu_cap);
                    command.Parameters.AddWithValue("@Hesophucap", ob.He_so_phu_cap);
                    command.Parameters.AddWithValue("@Hesoluong", ob.He_so_luong);


                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void Update_Phucap(Phu_cap ob)
        {
            string sql = "Update Phu_cap Set He_so_phu_cap=@He_so_phu_cap, He_so_luong=@Hesoluong where Ma_phu_cap=@Maphucap)";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Maphucap", ob.Ma_phu_cap);
                    command.Parameters.AddWithValue("@Hesophucap", ob.He_so_phu_cap);
                    command.Parameters.AddWithValue("@Hesoluong", ob.He_so_luong);


                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void Delete_Phucap(string Ma_phu_cap)
        {
            string sql = "DELETE FROM Phu_cap WHERE Ma_phu_cap = @Maphucap";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Maphucap", Ma_phu_cap);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
