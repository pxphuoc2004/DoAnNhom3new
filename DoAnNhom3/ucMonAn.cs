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
            this.btmuangay.Click += new System.EventHandler(this.btmuangay_Click);
           // this.btgiohang.Click += btgiohang_Click;
        }
        private string TenFileAnh;
        private void ucMonAn_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string tenMon, decimal gia, string tenFileAnh)
        {

            lbtenmonan.Text = tenMon;
            lbgia.Text = gia.ToString("N0") + " đ";

            string duongDan = Path.Combine(Application.StartupPath, "HinhAnh", tenFileAnh);
            if (File.Exists(duongDan))
            {
                ptbanhmonan.Image = Image.FromFile(duongDan);
                ptbanhmonan.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                // Gán ảnh mặc định nếu không tìm thấy ảnh
                ptbanhmonan.Image = null;
            }
        }

        /*private void ucMonAn_Load(object sender, EventArgs e)
        {

        }*/
        public event EventHandler<MonAnEventArgs> MuaNgayClicked;
        private void btmuangay_Click(object sender, EventArgs e)
        {
            var args = new MonAnEventArgs
            {
                TenMon = this.GetTenMon(),
                GiaTien = this.GetGiaTien(),
                HinhAnh = this.GetImage()
            };
            MuaNgayClicked?.Invoke(this, args);
        }
        public string GetTenMon() => lbtenmonan.Text;
        public decimal GetGiaTien() => decimal.Parse(lbgia.Text.Replace(",", "").Replace(" đ", ""));
        public Image GetImage() => ptbanhmonan.Image;

        
       /* private void btgiohang_Click(object sender, EventArgs e)
        {
            var mon = new MonAnEventArgs
            {
                TenMon = GetTenMon(),
                GiaTien = GetGiaTien(),
                HinhAnh = GetImage()
            }
            ;
            GioHangService.DanhSachMon.Add(mon);

            // Tìm form chứa ucMonAn và chuyển sang ucDonHang
            var parentForm = this.FindForm() as KhachHangDangNhap;
            if (parentForm != null)
            {
                var donHangUC = new ucDonHang();
                parentForm.Controls["panelkhachhang"].Controls.Clear();
                parentForm.Controls["panelkhachhang"].Controls.Add(donHangUC);
            }


        }*/

        private void btmuangay_Click_1(object sender, EventArgs e)
        {
            // Thêm vào giỏ hàng
            GioHangService.DanhSachMon.Add(new MonAnEventArgs
            {
                TenMon = GetTenMon(),
                GiaTien = GetGiaTien(),
                HinhAnh = GetImage()
            });

            // Mở giao diện ucDonHang
            /*var parent = this.FindForm() as KhachHangDangNhap;
            if (parent != null)
            {
                parent.MoGioHang();
            }*/

        }
    }
}
