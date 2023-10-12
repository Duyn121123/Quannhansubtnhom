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
    public class Nhanvien_DAL:Ketnoi
    {
        public Nhanvien_DAL() { }
        public DataTable Load_DL()
        {
            return Load_DL("select * from Nhan_vien");
        }
        string connection = ("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
       public void Insert_Nhanvien(Nhan_vien ob)
        {
            /*   string sql = "INSERT INTO Nhan_vien (Ma_nhan_vien, Ma_chuc_vu, Ho_dem, Ten, Ngay_sinh, So_dien_thoai, Que_quan, Gioi_tinh, Ma_phong, Ma_phu_cap) VALUES (@MaNhanVien, @MaChucVu, @HoDem, @Ten, @NgaySinh, @SoDienThoai, @QueQuan, @GioiTinh, @MaPhong, @MaPhuCap)";
               using (SqlCommand command = new SqlCommand(sql, connection))
               {
                   command.Parameters.AddWithValue("@MaNhanVien", ob.Ma_nhan_vien);
                   command.Parameters.AddWithValue("@MaChucVu", ob.Ma_chuc_vu);
                   command.Parameters.AddWithValue("@HoDem", ob.Ho_dem);
                   command.Parameters.AddWithValue("@Ten", ob.Ten);
                   command.Parameters.AddWithValue("@NgaySinh", ob.Ngay_sinh);
                   command.Parameters.AddWithValue("@SoDienThoai", ob.So_dien_thoai);
                   command.Parameters.AddWithValue("@QueQuan", ob.Que_quan);
                   command.Parameters.AddWithValue("@GioiTinh", ob.Gioi_tinh);
                   command.Parameters.AddWithValue("@MaPhong", ob.Ma_phong);
                   command.Parameters.AddWithValue("@MaPhuCap", ob.Ma_phu_cap);
               }
                   Execute(sql);*/
            string sql = "INSERT INTO Nhan_vien (Ma_nhan_vien, Ma_chuc_vu, Ho_dem, Ten, Ngay_sinh, So_dien_thoai, Que_quan, Gioi_tinh, Ma_phong) VALUES (@MaNhanVien, @MaChucVu, @HoDem, @Ten, @NgaySinh, @SoDienThoai, @QueQuan, @GioiTinh, @MaPhong)";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", ob.Ma_nhan_vien);
                    command.Parameters.AddWithValue("@MaChucVu", ob.Ma_chuc_vu);
                    command.Parameters.AddWithValue("@HoDem", ob.Ho_dem);
                    command.Parameters.AddWithValue("@Ten", ob.Ten);
                    command.Parameters.AddWithValue("@NgaySinh", ob.Ngay_sinh);
                    command.Parameters.AddWithValue("@SoDienThoai", ob.So_dien_thoai);
                    command.Parameters.AddWithValue("@QueQuan", ob.Que_quan);
                    command.Parameters.AddWithValue("@GioiTinh", ob.Gioi_tinh);
                    command.Parameters.AddWithValue("@MaPhong", ob.Ma_phong);
                    

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }//' " + ob.Ma_nhan_vien + "',
        public void Update_Nhanvien(Nhan_vien ob)
        {
            /*   string sql = "update Nhan_vien set Ma_chuc_vu=' " + ob.Ma_chuc_vu + "','" + ob.Ho_dem + "','" + ob.Ten + "','" + ob.Ngay_sinh + " ',' " + ob.So_dien_thoai + " ',' " + ob.Que_quan + "',' " + ob.Gioi_tinh + " ',' " + ob.Ma_phong + "','"+ob.Ma_phu_cap+"'"+"where Ma_nhan_vien='"+ob.Ma_nhan_vien+"'";
               Execute(sql);*/
            string sql = "UPDATE Nhan_vien SET Ma_chuc_vu = @MaChucVu, Ho_dem = @HoDem, Ten = @Ten, Ngay_sinh = @NgaySinh, So_dien_thoai = @SoDienThoai, Que_quan = @QueQuan, Gioi_tinh = @GioiTinh, Ma_phong = @MaPhong WHERE Ma_nhan_vien = @MaNhanVien";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", ob.Ma_nhan_vien);
                    command.Parameters.AddWithValue("@MaChucVu", ob.Ma_chuc_vu);
                    command.Parameters.AddWithValue("@HoDem", ob.Ho_dem);
                    command.Parameters.AddWithValue("@Ten", ob.Ten);
                    command.Parameters.AddWithValue("@NgaySinh", ob.Ngay_sinh);
                    command.Parameters.AddWithValue("@SoDienThoai", ob.So_dien_thoai);
                    command.Parameters.AddWithValue("@QueQuan", ob.Que_quan);
                    command.Parameters.AddWithValue("@GioiTinh", ob.Gioi_tinh);
                    command.Parameters.AddWithValue("@MaPhong", ob.Ma_phong);
                   

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public void Delete_Nhanvien(string Ma_nhan_vien)
        {
            string sql = "DELETE FROM Nhan_vien WHERE Ma_nhan_vien = @MaNhanVien";

            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", Ma_nhan_vien);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
     







    }
}
