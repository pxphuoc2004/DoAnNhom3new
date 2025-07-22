namespace DoAnNhom3
{
    partial class KhoNLieu
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
            this.dgvkhonguyenlieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhonguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách nguyên liệu";
            // 
            // dgvkhonguyenlieu
            // 
            this.dgvkhonguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhonguyenlieu.Location = new System.Drawing.Point(98, 95);
            this.dgvkhonguyenlieu.Name = "dgvkhonguyenlieu";
            this.dgvkhonguyenlieu.Size = new System.Drawing.Size(505, 344);
            this.dgvkhonguyenlieu.TabIndex = 3;
            // 
            // KhoNLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvkhonguyenlieu);
            this.Controls.Add(this.label1);
            this.Name = "KhoNLieu";
            this.Size = new System.Drawing.Size(692, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhonguyenlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvkhonguyenlieu;
    }
}
