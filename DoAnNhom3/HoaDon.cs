using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom3
{
    public partial class HoaDon: UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }
        public void SetData(string tenMon, decimal donGia, int soLuong, string sdtKH, string hinhAnh)
        {
            // Gán dữ liệu
            txbmahoadon.Text = "HD" + DateTime.Now.Ticks.ToString().Substring(10); // Tạo mã HĐ ngẫu nhiên
            txbtenmonan.Text = tenMon;
            txbdongiathahtoan.Text = donGia.ToString("N0");
            txbslgthanhtoan.Text = soLuong.ToString();
            tbxtongtien.Text = (donGia * soLuong).ToString("N0");
            txbngaylaphoadon.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txbsdtkh.Text = sdtKH;

            // Gán hình ảnh
            string path = Application.StartupPath + "\\HinhAnh\\" + hinhAnh;
            if (System.IO.File.Exists(path))
                ptbmonanthanhtoan.Image = Image.FromFile(path);
        }
    }
}
