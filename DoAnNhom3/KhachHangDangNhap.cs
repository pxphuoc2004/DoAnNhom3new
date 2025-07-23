using DoAnNhom3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNhom3.QuanLy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DoAnNhom3
{
    public partial class KhachHangDangNhap : Form
    {
        public KhachHangDangNhap()
        {
            InitializeComponent();
            Load += KhachHangDangNhap_Load;
        }
        private ucDonHang ucDonHang = new ucDonHang();
        private void baoCaoThongKe1_Load(object sender, EventArgs e)
        {

        }

        private void KhachHangDangNhap_Load(object sender, EventArgs e)
        {
            string sql = "SELECT TenMon, GiaTien, HinhAnh FROM MonAn";
            DataTable dt = Database.GetData(sql); // Giả sử bạn có sẵn class Database với hàm GetData

            foreach (DataRow row in dt.Rows)
            {
                string ten = row["TenMon"].ToString();
                decimal gia = Convert.ToDecimal(row["GiaTien"]);
                string fileAnh = row["HinhAnh"].ToString();

                Image img = Image.FromFile(Path.Combine(Application.StartupPath, "HinhAnh", fileAnh));

                ucMonAn mon = new ucMonAn();
                mon.SetData(ten, gia, fileAnh);

                mon.MuaNgayClicked += (s, ev) =>
                {
                    GioHangService.DanhSachMon.Add(ev);

                    // 2. Gọi cập nhật danh sách món trong giỏ hàng
                    //ucDonHang.LoadGioHang();  // tạo phương thức này ở dưới

                    // 3. Hiển thị ucDonHang
                    panelkhachhang.Controls.Clear();
                    panelkhachhang.Controls.Add(ucDonHang);

                    ucMenu = new ucMenuMonAn();
                    panelkhachhang.Controls.Add(ucMenu);
                };

                // Gán sự kiện khi nhấn nút giỏ hàng
                /*mon.ThemVaoGioHang += (s, ev) =>
                {
                    // Thêm vào giỏ
                    GioHangService.DanhSachMon.Add(new MonAnEventArgs
                    {
                        TenMon = ev.TenMon,
                        GiaTien = ev.GiaTien,
                        HinhAnh = ev.HinhAnh
                    });

                    // Chuyển sang ucDonHang
                    ucDonHang donHang = new ucDonHang();
                    panelkhachhang.Controls.Clear();
                    panelkhachhang.Controls.Add(donHang);
                };*/

                flowLayoutPanel1.Controls.Add(mon);

            }
        }
        public void LoadGioHang()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var mon in GioHangService.DanhSachMon)
            {
                themdonhang uc = new themdonhang();
                uc.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
        private void Mon_MuaNgayClicked(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            ucDonHang donHang = new ucDonHang();
            donHang.Dock = DockStyle.Fill;

            flowLayoutPanel1.Controls.Add(donHang);
        }
        private ucMenuMonAn ucMenu;

        public void HienMenu()
        {
            panelkhachhang.Controls.Clear();
            panelkhachhang.Controls.Add(ucMenu);
            ucMenu.Dock = DockStyle.Fill;
        }

        private void btqlitaikhoanKH_Click(object sender, EventArgs e)
        {

        }
    }
}
