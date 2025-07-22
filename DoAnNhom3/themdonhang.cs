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
using System.IO;

namespace DoAnNhom3
{
    public partial class themdonhang: UserControl
    {
        public themdonhang()
        {
            InitializeComponent();
        }

        private void themdonhang_Load(object sender, EventArgs e)
        {

        }
        /*public void SetData(DonHang dh)
        {
            txbtenmonan.Text = dh.TenMon;
            txbdongia.Text = dh.DonGia.ToString("N0") + "đ";

            string imgPath = Path.Combine(Application.StartupPath, "HinhAnh", dh.HinhAnh);
            if (File.Exists(imgPath))
            {
                pictureBox1.Image = Image.FromFile(imgPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }*/
    }
}
