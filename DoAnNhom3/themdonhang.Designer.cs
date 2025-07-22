namespace DoAnNhom3
{
    partial class themdonhang
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbtenmonan = new System.Windows.Forms.TextBox();
            this.txbdongia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbtenmonan
            // 
            this.txbtenmonan.Location = new System.Drawing.Point(135, 20);
            this.txbtenmonan.Name = "txbtenmonan";
            this.txbtenmonan.Size = new System.Drawing.Size(172, 20);
            this.txbtenmonan.TabIndex = 1;
            // 
            // txbdongia
            // 
            this.txbdongia.Location = new System.Drawing.Point(135, 46);
            this.txbdongia.Name = "txbdongia";
            this.txbdongia.Size = new System.Drawing.Size(172, 20);
            this.txbdongia.TabIndex = 2;
            // 
            // themdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbdongia);
            this.Controls.Add(this.txbtenmonan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "themdonhang";
            this.Size = new System.Drawing.Size(322, 86);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbtenmonan;
        private System.Windows.Forms.TextBox txbdongia;
    }
}
