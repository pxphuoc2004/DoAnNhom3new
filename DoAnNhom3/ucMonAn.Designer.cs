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
            this.lbtenmonan = new System.Windows.Forms.Label();
            this.lbgia = new System.Windows.Forms.Label();
            this.ptbanhmonan = new System.Windows.Forms.PictureBox();
            this.btgiohang = new System.Windows.Forms.Button();
            this.btmuangay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbanhmonan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtenmonan
            // 
            this.lbtenmonan.AutoSize = true;
            this.lbtenmonan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenmonan.Location = new System.Drawing.Point(55, 122);
            this.lbtenmonan.Name = "lbtenmonan";
            this.lbtenmonan.Size = new System.Drawing.Size(45, 19);
            this.lbtenmonan.TabIndex = 1;
            this.lbtenmonan.Text = "label1";
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgia.Location = new System.Drawing.Point(55, 150);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(45, 19);
            this.lbgia.TabIndex = 2;
            this.lbgia.Text = "label2";
            // 
            // ptbanhmonan
            // 
            this.ptbanhmonan.Location = new System.Drawing.Point(0, 0);
            this.ptbanhmonan.Name = "ptbanhmonan";
            this.ptbanhmonan.Size = new System.Drawing.Size(153, 110);
            this.ptbanhmonan.TabIndex = 0;
            this.ptbanhmonan.TabStop = false;
            // 
            // btgiohang
            // 
//            this.btgiohang.BackgroundImage = global::DoAnNhom3.Properties.Resources.giohang;
            this.btgiohang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btgiohang.Location = new System.Drawing.Point(106, 172);
            this.btgiohang.Name = "btgiohang";
            this.btgiohang.Size = new System.Drawing.Size(35, 31);
            this.btgiohang.TabIndex = 22;
            this.btgiohang.UseVisualStyleBackColor = true;
            // 
            // btmuangay
            // 
            this.btmuangay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmuangay.Location = new System.Drawing.Point(7, 172);
            this.btmuangay.Name = "btmuangay";
            this.btmuangay.Size = new System.Drawing.Size(93, 31);
            this.btmuangay.TabIndex = 21;
            this.btmuangay.Text = "Mua ngay";
            this.btmuangay.UseVisualStyleBackColor = true;
  //          this.btmuangay.Click += new System.EventHandler(this.btmuangay_Click);
            // 
            // ucMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btgiohang);
            this.Controls.Add(this.btmuangay);
            this.Controls.Add(this.lbgia);
            this.Controls.Add(this.lbtenmonan);
            this.Controls.Add(this.ptbanhmonan);
            this.Name = "ucMonAn";
            this.Size = new System.Drawing.Size(153, 209);
     //       this.Load += new System.EventHandler(this.ucMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbanhmonan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbanhmonan;
        private System.Windows.Forms.Label lbtenmonan;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.Button btgiohang;
        private System.Windows.Forms.Button btmuangay;
    }
}
