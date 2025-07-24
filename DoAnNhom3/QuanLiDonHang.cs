using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DoAnNhom3
{
    public partial class QuanLiDonHang : UserControl
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True;Trust Server Certificate=True";

        public QuanLiDonHang()
        {
            InitializeComponent();
            btnTaiLai.Click += BtnTaiLai_Click;
            LoadDanhSachDonHang();
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDanhSachDonHang();
        }

        private void LoadDanhSachDonHang()
        {
            string query = @"
                SELECT h.MaHoaDon, h.NgayLap, h.SoDienThoaiKH, h.MaNhanVien,
                       c.MaMon, m.TenMon, c.SoLuong, c.DonGia, c.ThanhTien
                FROM HoaDon h
                JOIN ChiTietHoaDon c ON h.MaHoaDon = c.MaHoaDon
                JOIN MonAn m ON c.MaMon = m.MaMon
                ORDER BY h.NgayLap DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDonHang.DataSource = dt;
                dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void Reload()
        {
            LoadDanhSachDonHang();
        }
    }
}
