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
using Microsoft.Reporting.WinForms;

using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;
using System.Windows.Media;

namespace Nhanvien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
       
            //this.Controls.Add(this.reportViewer1);

        }
        Nhanvien_Bus nhanvien = new Nhanvien_Bus();
        Phongban_Bus phongban = new Phongban_Bus();
        Chucvu_Bus chucvu = new Chucvu_Bus();
        Phucap_Bus phucap = new Phucap_Bus();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          int i = e.RowIndex;
        
           /* textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox10.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();*/
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i+1;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanvien.Load_Bus();
            dataGridView2.DataSource = phongban.Load_Bus();
            dataGridView3.DataSource = chucvu.Load_Bus();
            dataGridView4.DataSource = phucap.Load_Bus();

        }

        private void button2_Click(object sender, EventArgs e)//thêm
        {
            Nhan_vien ob = new Nhan_vien(textBox1.Text,textBox5.Text, textBox4.Text, textBox3.Text, textBox2.Text, textBox10.Text, textBox9.Text, textBox8.Text, textBox7.Text);
            nhanvien.Insert_Bus(ob);
            Main_Load(sender, e);
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)//xoa
        {
            nhanvien.Delete_Bus(textBox1.Text);
            Main_Load(sender, e);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//sua
        {
            Nhan_vien ob = new Nhan_vien(textBox1.Text, textBox5.Text, textBox4.Text, textBox3.Text, textBox2.Text, textBox10.Text, textBox9.Text, textBox8.Text, textBox7.Text);
            nhanvien.Update_Bus(ob);
            Main_Load(sender, e);
           string Ma_nhan_vien =textBox1.Text;
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox1.Text=Ma_nhan_vien;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                dataGridView4.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGridView3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)// them phong ban
        {
            Phong_ban ob= new Phong_ban(textBox11.Text,textBox13.Text,textBox12.Text);
            phongban.Insert_Bus(ob);
            Main_Load(sender, e);
            textBox11.Clear();
            textBox13.Clear();
            textBox12.Clear();
        }

        private void button8_Click(object sender, EventArgs e)//xoa phong ban
        {
            phongban.Delete_Bus(textBox11.Text);
            Main_Load(sender, e);
            textBox11.Clear();
        }

        private void button7_Click(object sender, EventArgs e)// sửa phong ban
        {
            Phong_ban ob = new Phong_ban(textBox11.Text, textBox13.Text, textBox12.Text);
            phongban.Update_Bus(ob);
            Main_Load(sender, e);
            string Ma_phong=textBox11.Text;
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Text = Ma_phong;
        }

        private void button10_Click(object sender, EventArgs e)//thêm chức vụ
        {
            Chuc_vu ob = new Chuc_vu(textBox14.Text, textBox15.Text, textBox6.Text);
            chucvu.Insert_Bus(ob);
            Main_Load(sender, e);
            textBox14.Clear();
            textBox15.Clear();
            textBox6.Clear();
        }

        private void button11_Click(object sender, EventArgs e)//sửa
        {
            Chuc_vu ob = new Chuc_vu(textBox14.Text, textBox15.Text, textBox6.Text);
            chucvu.Update_Bus(ob);
            Main_Load(sender, e);
            string Ma_chuc_vu = textBox14.Text;
            textBox15.Clear();
            textBox6.Clear();
            textBox14.Text = Ma_chuc_vu;
        }

        private void button12_Click(object sender, EventArgs e)//xoa
        {
            chucvu.Delete_Bus(textBox14.Text);
            Main_Load(sender, e);
            textBox14.Clear();
        }

        private void button14_Click(object sender, EventArgs e)// them phu cap
        {
            Phu_cap ob = new Phu_cap(textBox16.Text, textBox17.Text, textBox18.Text);
            phucap.Insert_Bus(ob);
            Main_Load(sender, e);
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();

        }

        private void button15_Click(object sender, EventArgs e)// sửa
        {
            Phu_cap ob = new Phu_cap(textBox16.Text, textBox17.Text, textBox18.Text);
            phucap.Update_Bus(ob);
            Main_Load(sender, e);
            string Ma_phu_cap = textBox16.Text;
            textBox17.Clear();
            textBox18.Clear();
            textBox16.Text = Ma_phu_cap;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            phucap.Delete_Bus(textBox16.Text);
            Main_Load(sender, e);
            textBox16.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");

            DataTable dt = new DataTable();
            string sql = "Select *";
            sql += " from Nhan_vien,Phong_ban,Chuc_vu,Phu_cap where Nhan_vien.Ma_phong=Phong_ban.Ma_phong and Nhan_vien.Ma_chuc_vu =Chuc_vu.Ma_chuc_vu and Chuc_vu.Ma_phu_cap=Phu_cap.Ma_phu_cap ";
            
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            dataGridView5.DataSource = dt;

        }

        private void dataGridView5_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
            {
                dataGridView5.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)//tim kiem theo ma nv

        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
            DataTable dt = new DataTable();
            string sql = "SELECT Nhan_vien.Ma_nhan_vien, Nhan_vien.Ma_chuc_vu, Nhan_vien.Ho_dem, Nhan_vien.Ten, Nhan_vien.Ngay_sinh, Nhan_vien.So_dien_thoai, Nhan_vien.Que_quan, Nhan_vien.Gioi_tinh, Nhan_vien.Ma_phong, Phong_ban.Ten_phong, Phong_ban.Ten_truong_phong, Chuc_vu.Ten_chuc_vu, Chuc_vu.Ma_phu_cap ";
            sql += "FROM Phong_ban ";
            sql += "JOIN Nhan_vien ON Nhan_vien.Ma_phong = Phong_ban.Ma_phong ";
            sql += "JOIN Chuc_vu ON Nhan_vien.Ma_chuc_vu = Chuc_vu.Ma_chuc_vu ";
            sql += "WHERE Ma_nhan_vien LIKE '%" + textBox19.Text + "%'";


            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(dt);
            dataGridView5.DataSource = dt;
        }

      


        private void button9_Click(object sender, EventArgs e)//xuat excel
        {
            {
                string filePath = "";
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                    return;
                }

                try
                {
                    using (ExcelPackage p = new ExcelPackage())
                    {

                        p.Workbook.Properties.Author = "Phan Thị Duyên";

                        p.Workbook.Properties.Title = "Danh sách nhân viên:" + textBox19.Text;

                        p.Workbook.Worksheets.Add("Danh_sach_Nhan_vien");

                        ExcelWorksheet ws = p.Workbook.Worksheets[1];

                        ws.Name = "Danh_sach_Nhan_vien" + textBox19.Text;
                        ws.Cells.Style.Font.Size = 11;
 
                        ws.Cells.Style.Font.Name = "Calibri";

                        // Tạo danh sách các column header
                        string[] arrColumnHeader = {
                                                "Số thứ tự",
                                                "Mã Nhân viên",
                                                "Mã chức vụ",
                                                "Họ đệm ",
                                                "Tên",
                                                "Ngày sinh",
                                                "Số điện thoại",
                                                "Quê quán",
                                                "Giới tính",
                                                "Mã phòng",
                                                "Tên phòng",
                                                "Tên trưởng phòng",
                                                "Tên chức vụ ",
                                                "Mã phụ cấp",
                                           //     "Hệ số phụ cấp",
                                           //     "Hệ số lương"
                };
                        

                      
                        var countColHeader = arrColumnHeader.Count();

                        ws.Cells[1, 1].Value = "Danh sách Nhân viên " + textBox19.Text;
                        ws.Cells[1, 1, 1, countColHeader].Merge = true;
                        // in đậm
                        ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                        int colIndex = 1;
                        int rowIndex = 2;

                        //tạo các header từ column header đã tạo từ bên trên
                        foreach (var item in arrColumnHeader)
                        {
                            var cell = ws.Cells[rowIndex, colIndex];

                            //gán giá trị
                            cell.Value = item;
                            colIndex++;
                        }
       

                     List<Nhan_vien> userList = new List<Nhan_vien>();
                        // lấy ra danh sách chuyển sang List từ gridview
                        for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
                        {
                            Nhan_vien ob = new Nhan_vien();
                            ob.STT = dataGridView5.Rows[i].Cells[0].Value.ToString();
                            ob.Ma_nhan_vien = dataGridView5.Rows[i].Cells[1].Value.ToString();
                            ob.Ma_chuc_vu = dataGridView5.Rows[i].Cells[2].Value.ToString();
                            ob.Ho_dem = dataGridView5.Rows[i].Cells[3].Value.ToString();
                            ob.Ten = dataGridView5.Rows[i].Cells[4].Value.ToString();
                            ob.Ngay_sinh = dataGridView5.Rows[i].Cells[5].Value.ToString();
                            ob.So_dien_thoai = dataGridView5.Rows[i].Cells[6].Value.ToString();
                            ob.Que_quan= dataGridView5.Rows[i].Cells[7].Value.ToString();
                            ob.Gioi_tinh = dataGridView5.Rows[i].Cells[8].Value.ToString();
                            ob.Ma_phong = dataGridView5.Rows[i].Cells[9].Value.ToString();
                            ob.Ten_phong = dataGridView5.Rows[i].Cells[10].Value.ToString();
                            ob.Ten_truong_phong = dataGridView5.Rows[i].Cells[11].Value.ToString();
                            ob.Ten_chuc_vu = dataGridView5.Rows[i].Cells[12].Value.ToString();
                            ob.Ma_phu_cap = dataGridView5.Rows[i].Cells[13].Value.ToString();
                          //  ob.He_so_phu_cap = dataGridView5.Rows[i].Cells[14].Value.ToString();
                          //  ob.He_so_luong = dataGridView5.Rows[i].Cells[15].Value.ToString();
                            userList.Add(ob);
                        }
                        
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
                            ws.Cells[rowIndex, colIndex++].Value = item.Ten_phong;
                            ws.Cells[rowIndex, colIndex++].Value = item.Ten_truong_phong;
                            ws.Cells[rowIndex, colIndex++].Value = item.Ten_chuc_vu;
                            ws.Cells[rowIndex, colIndex++].Value = item.Ma_phu_cap;
                         //   ws.Cells[rowIndex, colIndex++].Value = item.He_so_phu_cap;
                          //  ws.Cells[rowIndex, colIndex++].Value = item.He_so_luong;
                        }

                        //Lưu file lại
                        Byte[] bin = p.GetAsByteArray();
                        File.WriteAllBytes(filePath, bin);
                    }
                    MessageBox.Show("Xuất excel thành công!");
                }
                catch (Exception EE)
                {
                    MessageBox.Show("Có lỗi khi lưu file!");
                }
            }

        }
       
        
      /*  private void button13_Click(object sender, EventArgs e)
        {
          
            string sql = "Select * from Nhan_vien, Chuc_vu,Phong_ban where Nhan_vien.Ma_phong=Phong_ban.Ma_phong and Nhan_vien.Ma_chuc_vu=Chuc_vu.Ma_chuc_vu";
            DataTable dt = new DataTable(); 
            dt= Load_DL(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"D:\Windows form\Duannhom\Nhanvien\Nhanvien\Report1.rdlc";
            if (dt.Rows.Count > 0)
            {
                ReportDataSource ds = new ReportDataSource();
                ds.Name = "Danh sách nhân viên";
                ds.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Khong co du lieu");
        }*/

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm= new Form1();
            fm.Show();
                }
    }
}
