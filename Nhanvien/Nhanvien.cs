using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;

namespace Nhanvien
{
    public partial class Nhanvien:Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }
        Nhanvien_Bus nhanvien = new Nhanvien_Bus();
         private void Nhanvien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.Load_Bus();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
       
        private void Insert_Click(object sender, EventArgs e)
        {
            Nhan_vien ob = new Nhan_vien(Ma_nhan_vien.Text, Ma_chuc_vu.Text, Ho_dem.Text, Ten.Text, Ngay_sinh.Text, So_dien_thoai.Text, Que_quan.Text, Gioi_tinh.Text, Ma_phong.Text);
            nhanvien.Insert_Bus(ob);
            Nhanvien_Load(sender, e);
            Ma_nhan_vien.Clear();
            Ma_chuc_vu.Clear();
            Ho_dem.Clear();
            Ten.Clear();
            Ngay_sinh.Clear();
            So_dien_thoai.Clear();
            Que_quan.Clear();
            Gioi_tinh.Clear();
            Ma_phong.Clear();

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            
            Ma_nhan_vien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            Ma_chuc_vu.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            Ho_dem.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            Ten.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            Ngay_sinh.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            So_dien_thoai.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            Que_quan.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            Gioi_tinh.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            Ma_phong.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }

       private void Update_Click(object sender, EventArgs e)
        {
            Nhan_vien ob = new Nhan_vien(Ma_nhan_vien.Text, Ma_chuc_vu.Text, Ho_dem.Text, Ten.Text, Ngay_sinh.Text, So_dien_thoai.Text, Que_quan.Text, Gioi_tinh.Text, Ma_phong.Text);
            nhanvien.Insert_Bus(ob);
            Nhanvien_Load(sender, e);
            Ma_nhan_vien.Clear();
            Ma_chuc_vu.Clear();
            Ho_dem.Clear();
            Ten.Clear();
            Ngay_sinh.Clear();
            So_dien_thoai.Clear();
            Que_quan.Clear();
            Gioi_tinh.Clear();
            Ma_phong.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            nhanvien.Delete_Bus(Ma_chuc_vu.Text);
            Nhanvien_Load(sender, e);
            Ma_chuc_vu.Clear();
        }

        private void Excel_Click(object sender, EventArgs e)
        {
         string filePath = "";
       
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";
            if (dialog.ShowDialog() == DialogResult.OK) { filePath = dialog.FileName; }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("duong dan bao cao khong hop le");
                return;
            }
            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Author = "Phan Thi Duyen ";
                    p.Workbook.Properties.Title = " Danh sach nhan vien ";
                    p.Workbook.Worksheets.Add("Danh_sach_Nhan_vien");
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];
                    ws.Name = "Danh_sach_Nhan_vien ";
                    ws.Cells.Style.Font.Size = 14;
                    ws.Cells.Style.Font.Name = "Calibri";
                    string[] arrColumnHeader =
                    {
                        "Số thứ tự",
                        "Mã nhân viên",
                        "Mã chức vụ",
                        "Họ đệm",
                        "Tên",
                        "Ngày sinh",
                        "Số điện thoại",
                        "Quê quán",
                        "Giới tính",
                        "Mã phòng"
                    };
                    var countColHeader = arrColumnHeader.Count();
                    ws.Cells[1, 1].Value = "Danh sách nhân viên:" + Ma_nhan_vien.Text;
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    int colIndex = 1;
                    int rowIndex = 2;
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];
                        cell.Value = item;
                        colIndex++;
                        
                    }
                    List<Nhan_vien> userList = new List<Nhan_vien>();
                    for (int i = 0; i < dataGridView1.Rows.Count-1 ; i++)
                      {
                        Nhan_vien ob = new Nhan_vien();
                       ob.STT = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        ob.Ma_nhan_vien = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        ob.Ma_chuc_vu = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ob.Ho_dem = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        ob.Ten = dataGridView1.Rows[i].Cells[4].Value.ToString();
                       ob.Ngay_sinh = dataGridView1.Rows[i].Cells[5].Value.ToString();
                       ob.So_dien_thoai = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        ob.Que_quan = dataGridView1.Rows[i].Cells[7].Value.ToString();
                       ob.Gioi_tinh = dataGridView1.Rows[i].Cells[8].Value.ToString();
                        ob.Ma_phong = dataGridView1.Rows[i].Cells[9].Value.ToString();
                      
                        userList.Add(ob);
                    }
                   // MessageBox.Show(userList[0].Ma_phong + "," + userList[0].Ma_nhan_vien);
                    foreach (var item in userList)
                    {
                        colIndex = 1;
                        rowIndex++;
                        
                        ws.Cells[rowIndex, colIndex++].Value = item.STT;
                        ws.Cells[rowIndex, colIndex++].Value = item.Ma_nhan_vien;
                        ws.Cells[rowIndex, colIndex++].Value = item.Ma_chuc_vu;
                        ws.Cells[rowIndex, colIndex++].Value = item.Ho_dem;
                        ws.Cells[rowIndex, colIndex++].Value = item.Ten;
                        ws.Cells[rowIndex, colIndex++].Value = item.Ngay_sinh;
                        ws.Cells[rowIndex, colIndex++].Value = item.So_dien_thoai;
                        ws.Cells[rowIndex, colIndex++].Value = item.Que_quan;
                        ws.Cells[rowIndex, colIndex++].Value = item.Gioi_tinh;
                        ws.Cells[rowIndex, colIndex++].Value = item.Ma_phong;
                    }
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin );
                }
                MessageBox.Show("Xuat excel thanh cong!");
            }
            catch (Exception EE) 
            {
                MessageBox.Show("Co loi khi luu file!");
            }
        }

        private void Ma_nhan_vien_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
