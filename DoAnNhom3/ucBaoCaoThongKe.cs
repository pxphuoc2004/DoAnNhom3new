using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DoAnNhom3
{
    public partial class ucBaoCaoThongKe : UserControl
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True";

        public event Action QuayVeClicked;

        public ucBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string query = @"
    SELECT MaBaoCaoNgay, Ngay, MaMon, DonViTinh, SoLuong, DoanhThuNgay
    FROM BaoCaoNgay
    WHERE Ngay BETWEEN @TuNgay AND @DenNgay
    ORDER BY Ngay DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                    cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBaoCao.DataSource = dt;
                    dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvBaoCao.Columns.Contains("Ngay"))
                        dgvBaoCao.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    if (dgvBaoCao.Columns.Contains("DoanhThuNgay"))
                        dgvBaoCao.Columns["DoanhThuNgay"].DefaultCellStyle.Format = "N0";

                    // Tổng doanh thu
                    decimal tong = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["DoanhThuNgay"] != DBNull.Value)
                            tong += Convert.ToDecimal(row["DoanhThuNgay"]);
                    }

                    lblTongDoanhThu.Text = "Tổng doanh thu: " + tong.ToString("N0") + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }




        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuayVeClicked?.Invoke();
        }
    }
}
