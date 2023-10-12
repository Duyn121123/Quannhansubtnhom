using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Phongban_Bus
    {
        Phongban_DAL phongban = new Phongban_DAL();
        public DataTable Load_Bus()
        {
            return phongban.Load_DL();
        }
        public void Insert_Bus(Phong_ban ob)
        {
            phongban.Insert_Phongban(ob);
        }
        public void Update_Bus(Phong_ban ob)
        {
            phongban.Update_Phongban(ob);
        }
        public void Delete_Bus(string Ma_phong)
        {
            phongban.Delete_Phongban(Ma_phong);
        }
    }
}
