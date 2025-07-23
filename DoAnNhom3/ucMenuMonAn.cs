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
using DoAnNhom3.QuanLy;
using Microsoft.Identity.Client.NativeInterop;

namespace DoAnNhom3
{
    public partial class ucMenuMonAn : UserControl
    {
        public ucMenuMonAn()
        {
            InitializeComponent();
        }
        /*public event EventHandler<MonAnEventArgs> MonDuocThemVaoGio;
        private void ucMenuMonAn_Load(object sender, EventArgs e)
        {
            string sql = "SELECT TenMon, GiaTien, HinhAnh FROM MonAn";
            DataTable dt = Database.GetData(sql);

             foreach (DataRow row in dt.Rows)
            {
                ucMonAn mon = new ucMonAn();
                mon.SetData(row["TenMon"].ToString(), Convert.ToDecimal(row["GiaTien"]), row["HinhAnh"].ToString());

                // Gán sự kiện từ từng ucMonAn
                mon.ThemVaoGioHang += (s, e) => MonDuocThemVaoGio?.Invoke(this, e);
                mon.MuaNgayClicked += (s, e) => MonDuocThemVaoGio?.Invoke(this, e);

                flpgiohang.Controls.Add(mon);
            }
        }
        */

    }
}
