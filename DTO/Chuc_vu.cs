using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chuc_vu
    {
        public string Ma_chuc_vu {  get; set; }
        public string Ten_chuc_vu { get; set; }
        public string Ma_phu_cap {  get; set; } 
        public Chuc_vu() { }
        public Chuc_vu(string Ma_chuc_vu, string Ten_chuc_vu, string Ma_phu_cap)
        {
            this.Ma_chuc_vu = Ma_chuc_vu;
            this.Ten_chuc_vu = Ten_chuc_vu;
            this.Ma_phu_cap = Ma_phu_cap;
        }
    }
   
}
