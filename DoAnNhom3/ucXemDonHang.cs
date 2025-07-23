using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom3
{
    public partial class ucXemDonHang : UserControl
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline;Integrated Security=True;Trust Server Certificate=True";

        public ucXemDonHang()
        {
            InitializeComponent();
            LoadDonHang();
        }

        private void LoadDonHang()
        {
            string query = @"
                SELECT hd.MaHoaDon, hd.NgayLap, hd.SoDienThoaiKH, kh.TenKhachHang, 
                       nv.HoTen AS TenNhanVien, ct.MaMon, ma.TenMon, ct.SoLuong, ct.DonGia, ct.ThanhTien
                FROM HoaDon hd
                JOIN ChiTietHoaDon ct ON hd.MaHoaDon = ct.MaHoaDon
                JOIN KhachHang kh ON kh.SoDienThoai = hd.SoDienThoaiKH
                JOIN NhanVien nv ON nv.MaNhanVien = hd.MaNhanVien
                JOIN MonAn ma ON ma.MaMon = ct.MaMon
                ORDER BY hd.NgayLap DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDonHang.DataSource = dt;
                    dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đơn hàng: " + ex.Message);
            }
        }
    }
}
