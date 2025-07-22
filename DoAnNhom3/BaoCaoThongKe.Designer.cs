namespace DoAnNhom3
{
    partial class BaoCaoThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpngaybdau = new System.Windows.Forms.DateTimePicker();
            this.cbbchonmonan = new System.Windows.Forms.ComboBox();
            this.dtpngaykthuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Báo cáo doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn món ăn";
            // 
            // dtpngaybdau
            // 
            this.dtpngaybdau.Location = new System.Drawing.Point(75, 154);
            this.dtpngaybdau.Name = "dtpngaybdau";
            this.dtpngaybdau.Size = new System.Drawing.Size(162, 20);
            this.dtpngaybdau.TabIndex = 6;
            // 
            // cbbchonmonan
            // 
            this.cbbchonmonan.FormattingEnabled = true;
            this.cbbchonmonan.Items.AddRange(new object[] {
            "Gà rán nguyên con",
            "Khoai tây chiên",
            "Nước ép dưa hấu",
            "Nước ép dưa chuột"});
            this.cbbchonmonan.Location = new System.Drawing.Point(496, 154);
            this.cbbchonmonan.Name = "cbbchonmonan";
            this.cbbchonmonan.Size = new System.Drawing.Size(168, 21);
            this.cbbchonmonan.TabIndex = 7;
            // 
            // dtpngaykthuc
            // 
            this.dtpngaykthuc.Location = new System.Drawing.Point(284, 154);
            this.dtpngaykthuc.Name = "dtpngaykthuc";
            this.dtpngaykthuc.Size = new System.Drawing.Size(162, 20);
            this.dtpngaykthuc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Biểu đồ doanh thu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpngaykthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbchonmonan);
            this.Controls.Add(this.dtpngaybdau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaoCaoThongKe";
            this.Size = new System.Drawing.Size(692, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpngaybdau;
        private System.Windows.Forms.ComboBox cbbchonmonan;
        private System.Windows.Forms.DateTimePicker dtpngaykthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
