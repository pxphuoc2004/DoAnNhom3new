using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoAnNhom3.Model;

namespace DoAnNhom3
{
    public partial class ucDonHang : UserControl
    {
        private List<MonAn> gioHang = new List<MonAn>();

        public ucDonHang(MonAn monAnDuocChon)
        {
            InitializeComponent();
            if (monAnDuocChon != null)
            {
                gioHang.Add(monAnDuocChon);
                HienThiGioHang();
            }
        }

        private void HienThiGioHang()
        {
            flpgiohang.Controls.Clear();
            foreach (var mon in gioHang)
            {
                Panel panel = new Panel { Width = 400, Height = 40 };

                Label lbl = new Label
                {
                    Text = $"{mon.TenMon} - {mon.GiaTien:N0} đ",
                    Width = 200,
                    Location = new Point(5, 10)
                };

                NumericUpDown numSL = new NumericUpDown
                {
                    Minimum = 1,
                    Value = 1,
                    Width = 60,
                    Location = new Point(220, 7),
                    Tag = mon
                };

                panel.Controls.Add(lbl);
                panel.Controls.Add(numSL);
                flpgiohang.Controls.Add(panel);
            }
        }

        private void btthanhtoanKH_Click(object sender, EventArgs e)
        {
            decimal tongTien = 0;

            foreach (Control item in flpgiohang.Controls)
            {
                if (item is Panel panel)
                {
                    foreach (Control ctrl in panel.Controls)
                    {
                        if (ctrl is NumericUpDown num && num.Tag is MonAn mon)
                        {
                            tongTien += mon.GiaTien * num.Value;
                        }
                    }
                }
            }

            MessageBox.Show($"Tổng tiền thanh toán: {tongTien:N0} đ", "Thông báo");
        }
    }

}
