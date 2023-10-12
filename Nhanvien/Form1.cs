using Microsoft.Reporting.WinForms;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhanvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(this.reportViewer1);
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4TDH76B\\DELL3501;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        public DataTable Load_DL(string sql)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            //SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
            con.Close();
            return dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Nhan_vien, Chuc_vu,Phong_ban where Nhan_vien.Ma_phong=Phong_ban.Ma_phong and Nhan_vien.Ma_chuc_vu=Chuc_vu.Ma_chuc_vu  ";
            DataTable dt = new DataTable();
            dt = Load_DL(sql);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"D:\Windows form\Duannhom\Nhanvien\Nhanvien\Report1.rdlc";
            if (dt.Rows.Count > 0)
            {
                ReportDataSource ds = new ReportDataSource();
                ds.Name = "DataSet1";
                ds.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.RefreshReport();
            }
            else MessageBox.Show("Khong co du lieu");
        }
    }
}
