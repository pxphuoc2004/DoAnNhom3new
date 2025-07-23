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

        private void ucDonHang_Load(object sender, EventArgs e)
        {
            flpgiohang.Controls.Clear();
            foreach (var mon in GioHangService.DanhSachMon)
            {
                themdonhang uc = new themdonhang();
                uc.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh); // Tạo hàm SetData phù hợp
                flpgiohang.Controls.Add(uc);
            }
        }
        public void ThemDonHangVaoGio(string tenMon, decimal giaTien, Image hinhAnh)
        {
            themdonhang uc = new themdonhang();
            uc.SetData(tenMon, giaTien, hinhAnh);
            flpgiohang.Controls.Add(uc);
        }

        private void btthanhtoanKH_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler QuayLaiClicked;
        private void btquaylai_Click(object sender, EventArgs e)
        {
            var parent = this.FindForm() as KhachHangDangNhap;
            if (parent != null)
            {
                parent.HienMenu(); // gọi hàm để hiển thị menu
            }
        }
        
    }
}
