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
    public class Chucvu_DAl:Ketnoi
    {
        public Chucvu_DAl() { }
        public DataTable Load_DL()
        {
            return Load_DL("select * from Chuc_vu");
        }
        string connection = ("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        public void Insert_Chucvu(Chuc_vu ob)
        {
            string sql = "INSERT INTO Chuc_vu (Ma_chuc_vu, Ten_chuc_vu,Ma_phu_cap) VALUES (@Machucvu, @Tenchucvu, @Maphucap)";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Machucvu", ob.Ma_chuc_vu);
                    command.Parameters.AddWithValue("@Tenchucvu", ob.Ten_chuc_vu);
                    command.Parameters.AddWithValue("@Maphucap", ob.Ma_phu_cap);


                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void Update_Chucvu(Chuc_vu ob)
        {
            string sql = "Update Chuc_vu Set Ten_chuc_vu=@Tenchucvu, Ma_phu_cap=@Maphucap where Ma_chuc_vu=@Machucvu)";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Machucvu", ob.Ma_chuc_vu);
                    command.Parameters.AddWithValue("@Tenchucvu", ob.Ten_chuc_vu);
                    command.Parameters.AddWithValue("@Maphucap", ob.Ma_phu_cap);


                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void Delete_Chucvu(string Ma_chuc_vu)
        {
            string sql = "DELETE FROM Chuc_vu WHERE Ma_chuc_vu = @Machucvu";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@Machucvu", Ma_chuc_vu);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
