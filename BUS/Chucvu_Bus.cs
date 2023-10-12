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
    public class Chucvu_Bus
    {
        Chucvu_DAl chucvu = new Chucvu_DAl();
        public DataTable Load_Bus()
        {
            return chucvu.Load_DL();
        }
        public void Insert_Bus(Chuc_vu ob)
        {
            chucvu.Insert_Chucvu(ob);
        }
        public void Update_Bus(Chuc_vu ob)
        {
            chucvu.Update_Chucvu(ob);
        }
        public void Delete_Bus(string Ma_chuc_vu)
        {
            chucvu.Delete_Chucvu(Ma_chuc_vu);
        }
    }
}
