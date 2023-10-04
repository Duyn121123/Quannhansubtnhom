using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class Nhanvien_Bus 
    {   
        Nhanvien_DAL nhanvien= new Nhanvien_DAL();
        public DataTable Load_Bus()
        {
         return nhanvien.Load_DL();
        }
        public void Insert_Bus(Nhan_vien ob)
        {
            nhanvien.Insert_Nhanvien(ob);
        }
        public void Update_Bus(Nhan_vien ob)
        {
            nhanvien.Update_Nhanvien(ob);
        }
        public void Delete_Bus(string Ma_nhan_vien)
        {
            nhanvien.Delete_Nhanvien(Ma_nhan_vien);
        }
    }
}
