using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhom3.Model;

namespace DoAnNhom3
{
    public partial class ucDonHang : UserControl
    {
        public ucDonHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private DonHang donHang;
        private void ucDonHang_Load(object sender, EventArgs e)
        {
            if (donHang != null)
            {
                // Tạo UserControl themdonhang và truyền dữ liệu
                var uc = new themdonhang();
                uc.SetData(donHang);

                // Thêm vào giỏ hàng
                flpgiohang.Controls.Clear();
                flpgiohang.Controls.Add(uc);
            }
        }
        private int maMon;
        private string tenMon;
        private decimal donGia;

        public void SetData(int ma, string ten, decimal gia)
        {
            maMon = ma;
            tenMon = ten;
            donGia = gia;

            // Tùy bạn hiển thị label hoặc cho nhập số lượng
            Label lbl = new Label();
            lbl.Text = $"Món: {tenMon}, Giá: {donGia:N0}đ";
            flpgiohang.Controls.Add(lbl);

            NumericUpDown numSL = new NumericUpDown();
            numSL.Minimum = 1;
            numSL.Value = 1;
            flpgiohang.Controls.Add(numSL);
        }

        private void btthanhtoanKH_Click(object sender, EventArgs e)
        {
            if (donHang == null) return;

            int soLuong = 1; // mặc định, hoặc bạn có thể thêm NumericUpDown riêng trong themdonhang

            decimal tongTien = donHang.DonGia * soLuong;
            donHang.SoLuong = soLuong;

            var frm = this.FindForm() as KhachHangDangNhap;
            if (frm != null)
            {
                frm.MoHoaDon(donHang.TenMon, donHang.DonGia, soLuong, donHang.SDTKH, donHang.HinhAnh);
            }
        
        }

        public void SetDonHang(DonHang dh)
        {
            donHang = dh;
        }
    }
    
}
