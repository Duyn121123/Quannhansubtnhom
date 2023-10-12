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
    public class Phongban_DAL:Ketnoi
    {
        public Phongban_DAL() { }
        public DataTable Load_DL()
        {
            return Load_DL("select * from Phong_ban");
        }
        string connection = ("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        public void Insert_Phongban(Phong_ban ob)
        {
            string sql = "INSERT INTO Phong_ban (Ma_phong, Ten_phong,Ten_truong_phong) VALUES (@MaPhong, @Tenphong, @Tentruongphong)";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Maphong", ob.Ma_phong);
                    command.Parameters.AddWithValue("@Tenphong", ob.Ten_phong);
                    command.Parameters.AddWithValue("@Tentruongphong", ob.Ten_truong_phong);
                   

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void Update_Phongban(Phong_ban ob)
        {
            string sql = "Update Phong_ban Set Ten_phong=@Tenphong, Ten_truong_phong=@Tentruongphong where Ma_phong=@Maphong)";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Maphong", ob.Ma_phong);
                    command.Parameters.AddWithValue("@Tenphong", ob.Ten_phong);
                    command.Parameters.AddWithValue("@Tentruongphong", ob.Ten_truong_phong);


                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void Delete_Phongban(string Ma_phong)
        {
            string sql = "DELETE FROM Phong_ban WHERE Ma_phong = @Maphong";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Maphong", Ma_phong);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
