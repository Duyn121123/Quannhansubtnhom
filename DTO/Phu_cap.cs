using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phu_cap
    {
        public string Ma_phu_cap {  get; set; }
        public string He_so_phu_cap { get; set; }
        public string He_so_luong {  get; set; }
        public Phu_cap() { }
        public Phu_cap(string Ma_phu_cap, string He_so_phu_cap, string He_so_luong)
        {
            this.Ma_phu_cap = Ma_phu_cap;
            this.He_so_phu_cap = He_so_phu_cap;
            this.He_so_luong = He_so_luong;
        }
    }
}
