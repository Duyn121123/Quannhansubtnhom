using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong_ban
    {
        public string Ma_phong {  get; set; }
        public string Ten_phong { get; set;}
        public string Ten_truong_phong { get; set;}
        public Phong_ban() { }
        public Phong_ban(string Ma_phong, string Ten_phong, string Ten_truong_phong)
        {
            this.Ma_phong = Ma_phong;
            this.Ten_phong = Ten_phong;
            this.Ten_truong_phong = Ten_truong_phong;
        }
    }
}
