namespace DoAnNhom3
{
    partial class ucBaoCaoThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnQuayLai = new Button();
            lblTongDoanhThu = new Label();
            btnThongKe = new Button();
            dgvBaoCao = new DataGridView();
            label5 = new Label();
            dtpDenNgay = new DateTimePicker();
            label4 = new Label();
            dtpTuNgay = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(225, 186);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 28;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(103, 142);
            lblTongDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(97, 15);
            lblTongDoanhThu.TabIndex = 27;
            lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(103, 186);
            btnThongKe.Margin = new Padding(4, 3, 4, 3);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(88, 27);
            btnThongKe.TabIndex = 26;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(112, 284);
            dgvBaoCao.Margin = new Padding(4, 3, 4, 3);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.Size = new Size(645, 202);
            dgvBaoCao.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(351, 246);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 22;
            label5.Text = "Bảng Thống Kê";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(351, 85);
            dtpDenNgay.Margin = new Padding(4, 3, 4, 3);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(188, 23);
            dtpDenNgay.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(351, 57);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 20;
            label4.Text = "Ngày kết thúc";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(103, 85);
            dtpTuNgay.Margin = new Padding(4, 3, 4, 3);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(188, 23);
            dtpTuNgay.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 18;
            label2.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 27);
            label1.TabIndex = 17;
            label1.Text = "Báo cáo doanh thu";
            // 
            // ucBaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnQuayLai);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(btnThongKe);
            Controls.Add(dgvBaoCao);
            Controls.Add(label5);
            Controls.Add(dtpDenNgay);
            Controls.Add(label4);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucBaoCaoThongKe";
            Size = new Size(861, 513);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private Label lblTongDoanhThu;
        private Button btnThongKe;
        private DataGridView dgvBaoCao;
        private Label label5;
        private DateTimePicker dtpDenNgay;
        private Label label4;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private Label label1;
    }
}
