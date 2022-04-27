namespace CoBanWF
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.textInBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radYellow = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.chxBold = new System.Windows.Forms.CheckBox();
            this.chxItalic = new System.Windows.Forms.CheckBox();
            this.chxUnderLine = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textOutBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textInBox
            // 
            this.textInBox.Location = new System.Drawing.Point(183, 30);
            this.textInBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInBox.Name = "textInBox";
            this.textInBox.Size = new System.Drawing.Size(390, 22);
            this.textInBox.TabIndex = 1;
            this.textInBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.radBlack);
            this.groupBox1.Controls.Add(this.radYellow);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Location = new System.Drawing.Point(96, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(191, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox2.Controls.Add(this.chxUnderLine);
            this.groupBox2.Controls.Add(this.chxItalic);
            this.groupBox2.Controls.Add(this.chxBold);
            this.groupBox2.Location = new System.Drawing.Point(370, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(203, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(38, 41);
            this.radRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(44, 20);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Đỏ";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Blue;
            this.radGreen.Location = new System.Drawing.Point(38, 86);
            this.radGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(59, 20);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Xanh";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radYellow
            // 
            this.radYellow.AutoSize = true;
            this.radYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYellow.ForeColor = System.Drawing.Color.Yellow;
            this.radYellow.Location = new System.Drawing.Point(38, 154);
            this.radYellow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radYellow.Name = "radYellow";
            this.radYellow.Size = new System.Drawing.Size(61, 20);
            this.radYellow.TabIndex = 2;
            this.radYellow.TabStop = true;
            this.radYellow.Text = "Vàng";
            this.radYellow.UseVisualStyleBackColor = true;
            this.radYellow.CheckedChanged += new System.EventHandler(this.radYellow_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(38, 218);
            this.radBlack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(52, 20);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Đen";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // chxBold
            // 
            this.chxBold.AutoSize = true;
            this.chxBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxBold.ForeColor = System.Drawing.Color.Salmon;
            this.chxBold.Location = new System.Drawing.Point(17, 55);
            this.chxBold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chxBold.Name = "chxBold";
            this.chxBold.Size = new System.Drawing.Size(72, 20);
            this.chxBold.TabIndex = 0;
            this.chxBold.Text = "In đậm";
            this.chxBold.UseVisualStyleBackColor = true;
            this.chxBold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chxItalic
            // 
            this.chxItalic.AutoSize = true;
            this.chxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxItalic.ForeColor = System.Drawing.Color.Salmon;
            this.chxItalic.Location = new System.Drawing.Point(18, 125);
            this.chxItalic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chxItalic.Name = "chxItalic";
            this.chxItalic.Size = new System.Drawing.Size(97, 20);
            this.chxItalic.TabIndex = 1;
            this.chxItalic.Text = "In nghiêng";
            this.chxItalic.UseVisualStyleBackColor = true;
            this.chxItalic.CheckedChanged += new System.EventHandler(this.chxItalic_CheckedChanged);
            // 
            // chxUnderLine
            // 
            this.chxUnderLine.AutoSize = true;
            this.chxUnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxUnderLine.ForeColor = System.Drawing.Color.Salmon;
            this.chxUnderLine.Location = new System.Drawing.Point(17, 195);
            this.chxUnderLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chxUnderLine.Name = "chxUnderLine";
            this.chxUnderLine.Size = new System.Drawing.Size(99, 20);
            this.chxUnderLine.TabIndex = 2;
            this.chxUnderLine.Text = "Gạch chân";
            this.chxUnderLine.UseVisualStyleBackColor = true;
            this.chxUnderLine.CheckedChanged += new System.EventHandler(this.chxUnderLine_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(101, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập trình bởi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textOutBox
            // 
            this.textOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutBox.Location = new System.Drawing.Point(210, 365);
            this.textOutBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textOutBox.Name = "textOutBox";
            this.textOutBox.Size = new System.Drawing.Size(287, 22);
            this.textOutBox.TabIndex = 5;
            this.textOutBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(505, 363);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 24);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(651, 437);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textOutBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textInBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.frmMain_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radYellow;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chxUnderLine;
        private System.Windows.Forms.CheckBox chxItalic;
        private System.Windows.Forms.CheckBox chxBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOutBox;
        private System.Windows.Forms.Button btnClose;
    }
}

