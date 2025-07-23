using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using DoAnNhom3.Model;

namespace DoAnNhom3
{
    public partial class NhanVien : Form
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline;Integrated Security=True;Trust Server Certificate=True";
        private MonAn monAnDangChon;

        public NhanVien()
        {
            InitializeComponent();

            this.Load += NhanVien_Load;
            dgvmenuNV.SelectionChanged += dgvmenuNV_SelectionChanged;
            btqldanhmuc.Click += btqldanhmuc_Click;
            bttaodonhang.Click += bttaodonhang_Click;
            txbtimkiemmon.TextChanged += txbtimkiemmon_TextChanged;
            cbbDanhMuc.SelectedIndexChanged += cbbDanhMuc_SelectedIndexChanged;
            btqldonhang.Click += btqldonhang_Click;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            TimKiemVaLocMonAn(); // tự động hiển thị menu ban đầu
        }
        private void LoadMonAn()
        {
            string query = @"
        SELECT m.MaMon, m.TenMon, m.GiaTien, d.SoLuong, dm.TenDanhMuc AS LoaiMonAn
        FROM MonAn m
        LEFT JOIN DanhMuc_MonAn d ON m.MaMon = d.MaMon
        LEFT JOIN DanhMuc dm ON d.MaDanhMuc = dm.MaDanhMuc";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvmenuNV.DataSource = table;
                    dgvmenuNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Load tên món vào ComboBox (nếu bạn có dùng)
                    cbbTenmonmenuNV.Items.Clear();
                    foreach (DataRow row in table.Rows)
                    {
                        string tenMon = row["TenMon"].ToString();
                        if (!cbbTenmonmenuNV.Items.Contains(tenMon))
                            cbbTenmonmenuNV.Items.Add(tenMon);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải món ăn: " + ex.Message);
            }
        }

        private void LoadDanhMuc()
        {
            string query = "SELECT DISTINCT TenDanhMuc FROM DanhMuc";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cbbDanhMuc.Items.Clear();
                        cbbDanhMuc.Items.Add("Tất cả");
                        while (reader.Read())
                        {
                            cbbDanhMuc.Items.Add(reader.GetString(0));
                        }
                        cbbDanhMuc.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh mục: " + ex.Message);
            }
        }

        private void dgvmenuNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvmenuNV.SelectedRows.Count > 0)
            {
                var row = dgvmenuNV.SelectedRows[0];

                monAnDangChon = new MonAn
                {
                    MaMon = row.Cells["MaMon"].Value.ToString(),
                    TenMon = row.Cells["TenMon"].Value.ToString(),
                    GiaTien = Convert.ToDecimal(row.Cells["GiaTien"].Value),
                    SoLuong = row.Cells["SoLuong"].Value != DBNull.Value
                        ? Convert.ToInt32(row.Cells["SoLuong"].Value)
                        : 1
                };

                // Hiển thị xuống các ô nhập
                cbbTenmonmenuNV.Text = monAnDangChon.TenMon;
                txbdongiamenuNV.Text = monAnDangChon.GiaTien.ToString("N0") + " đ";
                txbsoluongmenuNV.Text = monAnDangChon.SoLuong.ToString();

                if (monAnDangChon.SoLuong == 0)
                {
                    MessageBox.Show("Món này hiện đã hết hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btqldanhmuc_Click(object sender, EventArgs e)
        {
            LoadMonAn();
        }

        private void bttaodonhang_Click(object sender, EventArgs e)
        {
            if (monAnDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn trước khi tạo đơn hàng!");
                return;
            }

            if (monAnDangChon.SoLuong <= 0)
            {
                MessageBox.Show("Món này đã hết hàng, không thể đặt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ucDonHang donHangUC = new ucDonHang(monAnDangChon)
            {
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(donHangUC);
        }

        private void txbtimkiemmon_TextChanged(object sender, EventArgs e)
        {
            TimKiemVaLocMonAn();
        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemVaLocMonAn();
        }

        private void TimKiemVaLocMonAn()
        {
            string tenMon = txbtimkiemmon.Text.Trim();
            string danhMuc = cbbDanhMuc.SelectedItem?.ToString();

            string query = @"
                SELECT m.MaMon, m.TenMon, m.GiaTien, d.SoLuong
                FROM MonAn m
                JOIN DanhMuc_MonAn d ON m.MaMon = d.MaMon
                JOIN DanhMuc dm ON dm.MaDanhMuc = d.MaDanhMuc
                WHERE m.TenMon LIKE @tenMon
                  AND (@danhMuc = N'Tất cả' OR dm.TenDanhMuc = @danhMuc)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenMon", "%" + tenMon + "%");
                    cmd.Parameters.AddWithValue("@danhMuc", string.IsNullOrEmpty(danhMuc) ? "Tất cả" : danhMuc);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvmenuNV.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc món ăn: " + ex.Message);
            }
        }

        private void btqldonhang_Click(object sender, EventArgs e)
        {
            ucXemDonHang xemUC = new ucXemDonHang
            {
                Dock = DockStyle.Fill
            };

            panelMain.Controls.Clear();
            panelMain.Controls.Add(xemUC);
        }
    }
}
