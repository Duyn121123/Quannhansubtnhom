using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class Phucap_Bus
    {
        Phucap_DAL phucap=new Phucap_DAL();
        public DataTable Load_Bus()
        {
            return phucap.Load_DL();
        }
        public void Insert_Bus(Phu_cap ob)
        {
            phucap.Insert_Phucap(ob);
        }
        public void Update_Bus(Phu_cap ob)
        {
            phucap.Update_Phucap(ob);
        }
        public void Delete_Bus(string Ma_phu_cap)
        {
            phucap.Delete_Phucap(Ma_phu_cap);
        }
    }

}
