using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DoAnNhom3.Model;

namespace DoAnNhom3
{
    public partial class ucDonHang : UserControl
    {
        private List<MonAn> gioHang = new List<MonAn>();

        public event Action QuayVeClicked;
        public event Action<List<MonAn>> ThanhToanClicked;

        public ucDonHang()
        {
            InitializeComponent();

            btQuayVe.Click += (s, e) => QuayVeClicked?.Invoke();
            btthanhtoanKH.Click += btthanhtoanKH_Click;

            // Cấu hình FlowLayoutPanel
            flpgiohang.FlowDirection = FlowDirection.TopDown;
            flpgiohang.WrapContents = false;
            flpgiohang.AutoScroll = true;
        }

        public void AddItem(MonAn monAn)
        {
            var existing = gioHang.FirstOrDefault(m => m.MaMon == monAn.MaMon);
            if (existing != null)
            {
                existing.SoLuong += monAn.SoLuong;
            }
            else
            {
                gioHang.Add(new MonAn
                {
                    MaMon = monAn.MaMon,
                    TenMon = monAn.TenMon,
                    GiaTien = monAn.GiaTien,
                    SoLuong = monAn.SoLuong,
                    HinhAnh = monAn.HinhAnh
                });
            }

            HienThiGioHang();
        }

        private void HienThiGioHang()
        {
            flpgiohang.Controls.Clear();

            foreach (var mon in gioHang)
            {
                Panel panel = new Panel
                {
                    Width = 500,
                    Height = 100,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Tag = mon
                };

                PictureBox pic = new PictureBox
                {
                    Size = new Size(100, 80),
                    Location = new Point(5, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                string path = Path.Combine(Application.StartupPath, "HinhAnh", mon.HinhAnh);
                if (File.Exists(path))
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pic.Image = Image.FromStream(stream);
                    }
                }

                TextBox txbTen = new TextBox
                {
                    Text = mon.TenMon,
                    Location = new Point(110, 10),
                    Width = 150,
                    ReadOnly = true
                };

                TextBox txbGia = new TextBox
                {
                    Text = mon.GiaTien.ToString("N0") + " đ",
                    Location = new Point(110, 40),
                    Width = 150,
                    ReadOnly = true
                };

                NumericUpDown numSL = new NumericUpDown
                {
                    Minimum = 1,
                    Value = mon.SoLuong,
                    Location = new Point(110, 70),
                    Width = 80
                };

                numSL.ValueChanged += (s, e) =>
                {
                    mon.SoLuong = (int)numSL.Value;
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(txbTen);
                panel.Controls.Add(txbGia);
                panel.Controls.Add(numSL);

                flpgiohang.Controls.Add(panel);
            }
        }

        private void btthanhtoanKH_Click(object sender, EventArgs e)
        {
            foreach (Control panel in flpgiohang.Controls)
            {
                if (panel is Panel p && p.Tag is MonAn mon)
                {
                    foreach (Control ctrl in p.Controls)
                    {
                        if (ctrl is NumericUpDown num)
                        {
                            mon.SoLuong = (int)num.Value;
                        }
                    }
                }
            }

            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!");
                return;
            }

            ThanhToanClicked?.Invoke(new List<MonAn>(gioHang));
        }
    }
}
