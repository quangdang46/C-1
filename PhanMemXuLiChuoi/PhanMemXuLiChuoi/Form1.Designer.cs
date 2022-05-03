namespace PhanMemXuLiChuoi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDem = new System.Windows.Forms.Button();
            this.btnHoa = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.btnDemHoa = new System.Windows.Forms.Button();
            this.btnDemThuong = new System.Windows.Forms.Button();
            this.btnDemSo = new System.Windows.Forms.Button();
            this.btnDao = new System.Windows.Forms.Button();
            this.btnDauTien = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDemXh = new System.Windows.Forms.Button();
            this.btnTachTu = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnTrich = new System.Windows.Forms.Button();
            this.txtDauTien = new System.Windows.Forms.TextBox();
            this.txtCuoi = new System.Windows.Forms.TextBox();
            this.txtDemXh = new System.Windows.Forms.TextBox();
            this.txtTachTu = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtXoa = new System.Windows.Forms.TextBox();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.txtViTri1 = new System.Windows.Forms.TextBox();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.txtViTri2 = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToiUu = new System.Windows.Forms.Button();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDem
            // 
            this.btnDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDem.Location = new System.Drawing.Point(30, 143);
            this.btnDem.Name = "btnDem";
            this.btnDem.Size = new System.Drawing.Size(281, 30);
            this.btnDem.TabIndex = 1;
            this.btnDem.Text = "Số kí tự trong chuỗi";
            this.btnDem.UseVisualStyleBackColor = true;
            this.btnDem.Click += new System.EventHandler(this.btnDem_Click);
            // 
            // btnHoa
            // 
            this.btnHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoa.Location = new System.Drawing.Point(30, 179);
            this.btnHoa.Name = "btnHoa";
            this.btnHoa.Size = new System.Drawing.Size(281, 30);
            this.btnHoa.TabIndex = 1;
            this.btnHoa.Text = "In chữ hoa";
            this.btnHoa.UseVisualStyleBackColor = true;
            this.btnHoa.Click += new System.EventHandler(this.btnHoa_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuong.Location = new System.Drawing.Point(30, 215);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(281, 30);
            this.btnThuong.TabIndex = 1;
            this.btnThuong.Text = "In chữ thường";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // btnDemHoa
            // 
            this.btnDemHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemHoa.Location = new System.Drawing.Point(30, 251);
            this.btnDemHoa.Name = "btnDemHoa";
            this.btnDemHoa.Size = new System.Drawing.Size(281, 30);
            this.btnDemHoa.TabIndex = 1;
            this.btnDemHoa.Text = "Đếm số ký tự in hoa";
            this.btnDemHoa.UseVisualStyleBackColor = true;
            this.btnDemHoa.Click += new System.EventHandler(this.btnDemHoa_Click);
            // 
            // btnDemThuong
            // 
            this.btnDemThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemThuong.Location = new System.Drawing.Point(30, 287);
            this.btnDemThuong.Name = "btnDemThuong";
            this.btnDemThuong.Size = new System.Drawing.Size(281, 30);
            this.btnDemThuong.TabIndex = 1;
            this.btnDemThuong.Text = "Đếm số ký tự in thường";
            this.btnDemThuong.UseVisualStyleBackColor = true;
            this.btnDemThuong.Click += new System.EventHandler(this.btnDemThuong_Click);
            // 
            // btnDemSo
            // 
            this.btnDemSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemSo.Location = new System.Drawing.Point(30, 323);
            this.btnDemSo.Name = "btnDemSo";
            this.btnDemSo.Size = new System.Drawing.Size(281, 30);
            this.btnDemSo.TabIndex = 1;
            this.btnDemSo.Text = "Đếm ký tự là số";
            this.btnDemSo.UseVisualStyleBackColor = true;
            this.btnDemSo.Click += new System.EventHandler(this.btnDemSo_Click);
            // 
            // btnDao
            // 
            this.btnDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDao.Location = new System.Drawing.Point(30, 359);
            this.btnDao.Name = "btnDao";
            this.btnDao.Size = new System.Drawing.Size(281, 30);
            this.btnDao.TabIndex = 1;
            this.btnDao.Text = "Đảo chuỗi";
            this.btnDao.UseVisualStyleBackColor = true;
            this.btnDao.Click += new System.EventHandler(this.btnDao_Click);
            // 
            // btnDauTien
            // 
            this.btnDauTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTien.Location = new System.Drawing.Point(329, 143);
            this.btnDauTien.Name = "btnDauTien";
            this.btnDauTien.Size = new System.Drawing.Size(189, 30);
            this.btnDauTien.TabIndex = 1;
            this.btnDauTien.Text = "Tìm vị trí xuất hiện đầu tiên";
            this.btnDauTien.UseVisualStyleBackColor = true;
            this.btnDauTien.Click += new System.EventHandler(this.btnDauTien_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.Location = new System.Drawing.Point(329, 179);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(189, 30);
            this.btnCuoi.TabIndex = 1;
            this.btnCuoi.Text = "Tìm vị trí xuất hiện cuối cùng";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnDemXh
            // 
            this.btnDemXh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemXh.Location = new System.Drawing.Point(329, 215);
            this.btnDemXh.Name = "btnDemXh";
            this.btnDemXh.Size = new System.Drawing.Size(189, 30);
            this.btnDemXh.TabIndex = 1;
            this.btnDemXh.Text = "Đếm số lần xuất hiện:";
            this.btnDemXh.UseVisualStyleBackColor = true;
            this.btnDemXh.Click += new System.EventHandler(this.btnDemXh_Click);
            // 
            // btnTachTu
            // 
            this.btnTachTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTachTu.Location = new System.Drawing.Point(329, 251);
            this.btnTachTu.Name = "btnTachTu";
            this.btnTachTu.Size = new System.Drawing.Size(189, 30);
            this.btnTachTu.TabIndex = 1;
            this.btnTachTu.Text = "Tách từ";
            this.btnTachTu.UseVisualStyleBackColor = true;
            this.btnTachTu.Click += new System.EventHandler(this.btnTachTu_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.Location = new System.Drawing.Point(329, 287);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(117, 30);
            this.btnThayDoi.TabIndex = 1;
            this.btnThayDoi.Text = "Thay đổi chuỗi con";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(329, 323);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(189, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá chuỗi con";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChen
            // 
            this.btnChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChen.Location = new System.Drawing.Point(329, 359);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(117, 30);
            this.btnChen.TabIndex = 1;
            this.btnChen.Text = "Chèn chuỗi";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnTrich
            // 
            this.btnTrich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrich.Location = new System.Drawing.Point(329, 395);
            this.btnTrich.Name = "btnTrich";
            this.btnTrich.Size = new System.Drawing.Size(117, 30);
            this.btnTrich.TabIndex = 1;
            this.btnTrich.Text = "Trích lọc";
            this.btnTrich.UseVisualStyleBackColor = true;
            this.btnTrich.Click += new System.EventHandler(this.btnTrich_Click);
            // 
            // txtDauTien
            // 
            this.txtDauTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDauTien.Location = new System.Drawing.Point(535, 143);
            this.txtDauTien.Name = "txtDauTien";
            this.txtDauTien.Size = new System.Drawing.Size(105, 24);
            this.txtDauTien.TabIndex = 2;
            // 
            // txtCuoi
            // 
            this.txtCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuoi.Location = new System.Drawing.Point(534, 182);
            this.txtCuoi.Name = "txtCuoi";
            this.txtCuoi.Size = new System.Drawing.Size(105, 24);
            this.txtCuoi.TabIndex = 3;
            // 
            // txtDemXh
            // 
            this.txtDemXh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemXh.Location = new System.Drawing.Point(535, 215);
            this.txtDemXh.Name = "txtDemXh";
            this.txtDemXh.Size = new System.Drawing.Size(105, 24);
            this.txtDemXh.TabIndex = 3;
            // 
            // txtTachTu
            // 
            this.txtTachTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTachTu.Location = new System.Drawing.Point(535, 251);
            this.txtTachTu.Name = "txtTachTu";
            this.txtTachTu.Size = new System.Drawing.Size(105, 24);
            this.txtTachTu.TabIndex = 3;
            this.txtTachTu.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(535, 290);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(105, 24);
            this.txtNew.TabIndex = 3;
            // 
            // txtXoa
            // 
            this.txtXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXoa.Location = new System.Drawing.Point(535, 326);
            this.txtXoa.Name = "txtXoa";
            this.txtXoa.Size = new System.Drawing.Size(105, 24);
            this.txtXoa.TabIndex = 3;
            // 
            // txtChuoi
            // 
            this.txtChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoi.Location = new System.Drawing.Point(459, 361);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(88, 24);
            this.txtChuoi.TabIndex = 3;
            // 
            // txtViTri1
            // 
            this.txtViTri1.Location = new System.Drawing.Point(508, 399);
            this.txtViTri1.Name = "txtViTri1";
            this.txtViTri1.Size = new System.Drawing.Size(39, 20);
            this.txtViTri1.TabIndex = 3;
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(599, 365);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(41, 20);
            this.txtVitri.TabIndex = 3;
            this.txtVitri.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtViTri2
            // 
            this.txtViTri2.Location = new System.Drawing.Point(611, 399);
            this.txtViTri2.Name = "txtViTri2";
            this.txtViTri2.Size = new System.Drawing.Size(29, 20);
            this.txtViTri2.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 16);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(275, 106);
            this.txtInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(326, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 16);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(304, 106);
            this.txtOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(553, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vị trí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(456, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vị trí 1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(553, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vị trí 2:";
            // 
            // btnToiUu
            // 
            this.btnToiUu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToiUu.Location = new System.Drawing.Point(30, 395);
            this.btnToiUu.Name = "btnToiUu";
            this.btnToiUu.Size = new System.Drawing.Size(281, 30);
            this.btnToiUu.TabIndex = 1;
            this.btnToiUu.Text = "Tối ưu chuỗi";
            this.btnToiUu.UseVisualStyleBackColor = true;
            this.btnToiUu.Click += new System.EventHandler(this.btnToiUu_Click);
            // 
            // txtOld
            // 
            this.txtOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOld.Location = new System.Drawing.Point(452, 290);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(77, 24);
            this.txtOld.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(665, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVitri);
            this.Controls.Add(this.txtViTri2);
            this.Controls.Add(this.txtViTri1);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.txtXoa);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtTachTu);
            this.Controls.Add(this.txtDemXh);
            this.Controls.Add(this.txtCuoi);
            this.Controls.Add(this.txtDauTien);
            this.Controls.Add(this.btnTrich);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnToiUu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDao);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.btnDemSo);
            this.Controls.Add(this.btnTachTu);
            this.Controls.Add(this.btnDemThuong);
            this.Controls.Add(this.btnDemXh);
            this.Controls.Add(this.btnDemHoa);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnDauTien);
            this.Controls.Add(this.btnHoa);
            this.Controls.Add(this.btnDem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnDem;
        private System.Windows.Forms.Button btnHoa;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Button btnDemHoa;
        private System.Windows.Forms.Button btnDemThuong;
        private System.Windows.Forms.Button btnDemSo;
        private System.Windows.Forms.Button btnDao;
        private System.Windows.Forms.Button btnDauTien;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnDemXh;
        private System.Windows.Forms.Button btnTachTu;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnTrich;
        private System.Windows.Forms.TextBox txtDauTien;
        private System.Windows.Forms.TextBox txtCuoi;
        private System.Windows.Forms.TextBox txtDemXh;
        private System.Windows.Forms.TextBox txtTachTu;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtXoa;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.TextBox txtViTri1;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.TextBox txtViTri2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToiUu;
        private System.Windows.Forms.TextBox txtOld;
    }
}

