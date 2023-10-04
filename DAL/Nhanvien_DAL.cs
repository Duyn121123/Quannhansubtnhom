using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class Nhanvien_DAL:Ketnoi
    {
        public Nhanvien_DAL() { }
        public DataTable Load_DL()
        {
            return Load_DL("select * from Nhan_vien");
        }
        public void Insert_Nhanvien(Nhan_vien ob)
        {
            string sql = "insert into Nhan_vien values('"+ob.Ma_nhan_vien+"','" + ob.Ma_chuc_vu + "','" + ob.Ho_dem + "','" + ob.Ten + "','" + ob.Ngay_sinh + "','" + ob.So_dien_thoai + "','" + ob.Que_quan + "','" + ob.Gioi_tinh + "','" + ob.Ma_phong + "') ";
            Execute(sql);
        }//' " + ob.Ma_nhan_vien + "',
        public void Update_Nhanvien(Nhan_vien ob)
        {
            string sql = "update Nhan_vien set Ma_chuc_vu=' " + ob.Ma_nhan_vien + " ','" + ob.Ma_chuc_vu + "','" + ob.Ho_dem + "','" + ob.Ten + "','" + ob.Ngay_sinh + " ',' " + ob.So_dien_thoai + " ',' " + ob.Que_quan + "',' " + ob.Gioi_tinh + "' ,' " + ob.Ma_phong + "'";
            Execute(sql);
        }
        public void Delete_Nhanvien(string Ma_nhan_vien)
        {
            string sql = " delete from Nhan_vien where Ma_nhan_vien =' " + Ma_nhan_vien + " ' ";
            Execute(sql);
        }
    }
}
