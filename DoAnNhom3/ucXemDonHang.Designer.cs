namespace DoAnNhom3
{
    partial class ucXemDonHang
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
            label1 = new Label();
            dgvDonHang = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 72);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh sách đơn hàng";
            // 
            // dgvDonHang
            // 
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(80, 135);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.Size = new Size(624, 233);
            dgvDonHang.TabIndex = 1;
            // 
            // ucXemDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvDonHang);
            Controls.Add(label1);
            Name = "ucXemDonHang";
            Size = new Size(770, 548);
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDonHang;
    }
}
