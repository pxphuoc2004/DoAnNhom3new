using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAnNhom3.Model;
using Microsoft.Data.SqlClient;


namespace DoAnNhom3
{
    public partial class HoaDon : UserControl
    {
        public event Action DonHangDatThanhCong;
        private List<MonAn> danhSachMon = new List<MonAn>();
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True";

        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            txbmahoadon.Text = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
            txbngaylaphoadon.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void SetData(List<MonAn> dsMon, string sdtKH)
        {
            danhSachMon = dsMon;

            txbmahoadon.Text = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
            txbngaylaphoadon.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txbsdtkh.Text = sdtKH;

            decimal tongTien = 0;
            flpMonAnHoaDon.Controls.Clear();

            foreach (var mon in dsMon)
            {
                tongTien += mon.GiaTien * mon.SoLuong;

                Panel panel = new Panel
                {
                    Width = 500,
                    Height = 70,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                PictureBox pic = new PictureBox
                {
                    Width = 60,
                    Height = 60,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(5, 5)
                };
                string imgPath = Path.Combine(Application.StartupPath, "HinhAnh", mon.HinhAnh);
                if (File.Exists(imgPath))
                    pic.Image = Image.FromFile(imgPath);

                Label lblTenMon = new Label
                {
                    Text = mon.TenMon,
                    AutoSize = true,
                    Location = new Point(75, 10)
                };

                Label lblDonGia = new Label
                {
                    Text = $"Đơn giá: {mon.GiaTien:N0} đ",
                    AutoSize = true,
                    Location = new Point(75, 30)
                };

                Label lblSoLuong = new Label
                {
                    Text = $"Số lượng: {mon.SoLuong}",
                    AutoSize = true,
                    Location = new Point(250, 30)
                };

                Label lblThanhTien = new Label
                {
                    Text = $"Thành tiền: {(mon.GiaTien * mon.SoLuong):N0} đ",
                    AutoSize = true,
                    Location = new Point(75, 50)
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(lblTenMon);
                panel.Controls.Add(lblDonGia);
                panel.Controls.Add(lblSoLuong);
                panel.Controls.Add(lblThanhTien);

                flpMonAnHoaDon.Controls.Add(panel);
            }

            tbxtongtien.Text = tongTien.ToString("N0") + " đ";
        }

        public void BatSuKienDatHang(EventHandler handler)
        {
            btdathang.Click += async (s, e) =>
            {
                try
                {
                    await ThemBaoCaoNgayAsync();
                    handler.Invoke(s, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm báo cáo ngày: " + ex.Message);
                }
            };
        }

        private async Task ThemBaoCaoNgayAsync()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                foreach (var mon in danhSachMon)
                {
                    string maBCN = "BCN" + DateTime.Now.Ticks.ToString().Substring(10);

                    string query = @"
                        INSERT INTO BaoCaoNgay (MaBaoCaoNgay, Ngay, MaMon, DonViTinh, SoLuong, DoanhThuNgay)
                        VALUES (@MaBCN, @Ngay, @MaMon, @DonViTinh, @SoLuong, @DoanhThu)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBCN", maBCN);
                        cmd.Parameters.AddWithValue("@Ngay", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@MaMon", mon.MaMon);
                        cmd.Parameters.AddWithValue("@DonViTinh", "Phần");
                        cmd.Parameters.AddWithValue("@SoLuong", mon.SoLuong);
                        cmd.Parameters.AddWithValue("@DoanhThu", mon.SoLuong * mon.GiaTien);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
        }

        public void GoiSuKienDatHangThanhCong()
        {
            DonHangDatThanhCong?.Invoke();
        }

        public string MaHoaDon => txbmahoadon.Text;
        public DateTime NgayLap => DateTime.Now;
        public string SoDienThoaiKH => txbsdtkh.Text;
        public decimal TongTien => decimal.TryParse(tbxtongtien.Text.Replace(",", "").Replace(" đ", ""), out decimal tong) ? tong : 0;
        public List<MonAn> DanhSachMon => danhSachMon;
    }
}
