namespace ListBox
{
    partial class frmSinhVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSinhVien = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLuu = new System.Windows.Forms.Button();
            this.txtXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSinhVien
            // 
            this.lstSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstSinhVien.FormattingEnabled = true;
            this.lstSinhVien.ItemHeight = 16;
            this.lstSinhVien.Location = new System.Drawing.Point(69, 144);
            this.lstSinhVien.Name = "lstSinhVien";
            this.lstSinhVien.Size = new System.Drawing.Size(533, 212);
            this.lstSinhVien.TabIndex = 0;
            this.lstSinhVien.SelectedIndexChanged += new System.EventHandler(this.lstSinhVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(111, 24);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(452, 20);
            this.txtMa.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(111, 65);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(452, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtLuu
            // 
            this.txtLuu.Location = new System.Drawing.Point(174, 100);
            this.txtLuu.Name = "txtLuu";
            this.txtLuu.Size = new System.Drawing.Size(94, 26);
            this.txtLuu.TabIndex = 3;
            this.txtLuu.Text = "Lưu";
            this.txtLuu.UseVisualStyleBackColor = true;
            this.txtLuu.Click += new System.EventHandler(this.txtLuu_Click);
            // 
            // txtXoa
            // 
            this.txtXoa.Location = new System.Drawing.Point(322, 100);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(88, 26);
            this.txtXoa.TabIndex = 5;
            this.txtXoa.Text = "Xoá";
            this.txtXoa.UseVisualStyleBackColor = true;
            this.txtXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 392);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtLuu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSinhVien);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button txtLuu;
        private System.Windows.Forms.Button txtXoa;
    }
}