using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhan_vien
    {   public string STT {  get; set; }
        public string Ma_nhan_vien {  get; set; }
        public string Ma_chuc_vu {  get; set; }
        public string Ho_dem {  get; set; }
        public string Ten {  get; set; }
        public string Ngay_sinh {  get; set; }
        public string So_dien_thoai {  get; set; }
        public string Que_quan {  get; set; }
        public string Gioi_tinh { get; set;  }
        public string Ma_phong { get; set;}
        public Nhan_vien() { }
        public Nhan_vien (string Ma_nhan_vien, string Ma_chuc_vu, string Ho_dem, string Ten, 
            string Ngay_sinh, string So_dien_thoai, string Que_quan, string Gioi_tinh, string Ma_phong)
        {
           
           this. Ma_nhan_vien = Ma_nhan_vien;
           this. Ma_chuc_vu = Ma_chuc_vu;
           this. Ho_dem = Ho_dem;
            this.Ten = Ten;
            this.Ngay_sinh = Ngay_sinh;
            this.So_dien_thoai = So_dien_thoai;
            this.Que_quan = Que_quan;
            this.Gioi_tinh = Gioi_tinh;
            this.Ma_phong = Ma_phong;
        }
    }
}
