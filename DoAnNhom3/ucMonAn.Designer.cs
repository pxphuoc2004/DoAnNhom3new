namespace DoAnNhom3
{
    partial class ucMonAn
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
            lbtenmonan = new Label();
            lbgia = new Label();
            ptbanhmonan = new PictureBox();
            btgiohang = new Button();
            btmuangay = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbanhmonan).BeginInit();
            SuspendLayout();
            // 
            // lbtenmonan
            // 
            lbtenmonan.AutoSize = true;
            lbtenmonan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtenmonan.Location = new Point(64, 141);
            lbtenmonan.Margin = new Padding(4, 0, 4, 0);
            lbtenmonan.Name = "lbtenmonan";
            lbtenmonan.Size = new Size(45, 19);
            lbtenmonan.TabIndex = 1;
            lbtenmonan.Text = "label1";
            // 
            // lbgia
            // 
            lbgia.AutoSize = true;
            lbgia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbgia.Location = new Point(64, 173);
            lbgia.Margin = new Padding(4, 0, 4, 0);
            lbgia.Name = "lbgia";
            lbgia.Size = new Size(45, 19);
            lbgia.TabIndex = 2;
            lbgia.Text = "label2";
            // 
            // ptbanhmonan
            // 
            ptbanhmonan.Location = new Point(0, 0);
            ptbanhmonan.Margin = new Padding(4, 3, 4, 3);
            ptbanhmonan.Name = "ptbanhmonan";
            ptbanhmonan.Size = new Size(178, 127);
            ptbanhmonan.TabIndex = 0;
            ptbanhmonan.TabStop = false;
            // 
            // btgiohang
            // 
            btgiohang.BackgroundImage = Properties.Resources.giohang;
            btgiohang.BackgroundImageLayout = ImageLayout.Stretch;
            btgiohang.Location = new Point(124, 198);
            btgiohang.Margin = new Padding(4, 3, 4, 3);
            btgiohang.Name = "btgiohang";
            btgiohang.Size = new Size(41, 36);
            btgiohang.TabIndex = 22;
            btgiohang.UseVisualStyleBackColor = true;
//            btgiohang.Click += btgiohang_Click;
            // 
            // btmuangay
            // 
            btmuangay.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmuangay.Location = new Point(8, 198);
            btmuangay.Margin = new Padding(4, 3, 4, 3);
            btmuangay.Name = "btmuangay";
            btmuangay.Size = new Size(108, 36);
            btmuangay.TabIndex = 21;
            btmuangay.Text = "Mua ngay";
            btmuangay.UseVisualStyleBackColor = true;
            btmuangay.Click += btmuangay_Click_1;
            // 
            // ucMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btgiohang);
            Controls.Add(btmuangay);
            Controls.Add(lbgia);
            Controls.Add(lbtenmonan);
            Controls.Add(ptbanhmonan);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucMonAn";
            Size = new Size(178, 241);
            Load += ucMonAn_Load;
            ((System.ComponentModel.ISupportInitialize)ptbanhmonan).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbanhmonan;
        private System.Windows.Forms.Label lbtenmonan;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.Button btgiohang;
        private System.Windows.Forms.Button btmuangay;
    }
}
