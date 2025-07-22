using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAnNhom3.Model;

namespace DoAnNhom3
{
    public partial class ucMonAn : UserControl
    {
        public ucMonAn()
        {
            InitializeComponent();
        }
        // Các thuộc tính công khai để truyền dữ liệu
        private string maMon;
        private string tenMon;
        private decimal donGia;
        private string hinhAnh;

        public void SetData(string ma, string ten, decimal gia, string tenAnh)
        {
            maMon = ma;
            tenMon = ten;
            donGia = gia;
            lbtenmonan.Text = ten;
            lbgia.Text = gia.ToString("N0") + "đ";

            string path = Path.Combine(Application.StartupPath, "HinhAnh", tenAnh);
            if (File.Exists(path))
            {
                ptbanhmonan.Image = Image.FromFile(path);
                ptbanhmonan.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ucMonAn_Load(object sender, EventArgs e)
        {

        }

        private void btmuangay_Click(object sender, EventArgs e)
        {
            // Tạo đơn hàng thực tế từ món này
            var donHang = new DonHang
            {
                MaMon = this.maMon,
                TenMon = this.tenMon,
                DonGia = this.donGia,
                HinhAnh = this.hinhAnh,
                SoLuong = 1, // có thể để mặc định là 1, hoặc để nhập từ textbox
                SDTKH = KhachHangDangNhap.SDTNguoiDung // hoặc truyền từ form cha
            };

            var frm = this.FindForm() as KhachHangDangNhap;
            if (frm != null)
            {
                frm.MoDonHangVoiDuLieu(donHang);
            }
        }
    }
}
