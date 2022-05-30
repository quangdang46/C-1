namespace QuanLiGiaoVien
{
    partial class Form1
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst3 = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(22, 79);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(193, 212);
            this.lst1.TabIndex = 0;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(258, 79);
            this.lst2.Name = "lst2";
            this.lst2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst2.Size = new System.Drawing.Size(193, 212);
            this.lst2.TabIndex = 0;
            this.lst2.SelectedIndexChanged += new System.EventHandler(this.lst2_SelectedIndexChanged);
            // 
            // lst3
            // 
            this.lst3.FormattingEnabled = true;
            this.lst3.Location = new System.Drawing.Point(570, 79);
            this.lst3.Name = "lst3";
            this.lst3.Size = new System.Drawing.Size(193, 212);
            this.lst3.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(632, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 33);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Location = new System.Drawing.Point(489, 157);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(59, 40);
            this.btnPhanCong.TabIndex = 2;
            this.btnPhanCong.Text = "Xuất";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lst3);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.ListBox lst3;
        public System.Windows.Forms.ListBox lst1;
    }
}

