namespace BaiTapListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grQuanLi = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.btnDeleteA = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteB = new System.Windows.Forms.Button();
            this.grQuanLi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sinh Viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Cập Nhật";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(106, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(366, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // grQuanLi
            // 
            this.grQuanLi.Controls.Add(this.btnDeleteB);
            this.grQuanLi.Controls.Add(this.btnClose);
            this.grQuanLi.Controls.Add(this.btnDeleteA);
            this.grQuanLi.Controls.Add(this.btnLeftAll);
            this.grQuanLi.Controls.Add(this.btnLeft);
            this.grQuanLi.Controls.Add(this.btnRightAll);
            this.grQuanLi.Controls.Add(this.btnRight);
            this.grQuanLi.Controls.Add(this.lstB);
            this.grQuanLi.Controls.Add(this.lstA);
            this.grQuanLi.Location = new System.Drawing.Point(28, 70);
            this.grQuanLi.Name = "grQuanLi";
            this.grQuanLi.Size = new System.Drawing.Size(604, 349);
            this.grQuanLi.TabIndex = 0;
            this.grQuanLi.TabStop = false;
            this.grQuanLi.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Location = new System.Drawing.Point(25, 19);
            this.lstA.Name = "lstA";
            this.lstA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstA.Size = new System.Drawing.Size(198, 251);
            this.lstA.TabIndex = 1;
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.Location = new System.Drawing.Point(379, 23);
            this.lstB.Name = "lstB";
            this.lstB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstB.Size = new System.Drawing.Size(198, 251);
            this.lstB.TabIndex = 0;
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRight.Location = new System.Drawing.Point(247, 18);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(106, 46);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRightAll.Location = new System.Drawing.Point(247, 89);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(106, 46);
            this.btnRightAll.TabIndex = 2;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLeft.Location = new System.Drawing.Point(247, 153);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(106, 46);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLeftAll.Location = new System.Drawing.Point(247, 224);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.Size = new System.Drawing.Size(106, 46);
            this.btnLeftAll.TabIndex = 4;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.UseVisualStyleBackColor = true;
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // btnDeleteA
            // 
            this.btnDeleteA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteA.Location = new System.Drawing.Point(51, 292);
            this.btnDeleteA.Name = "btnDeleteA";
            this.btnDeleteA.Size = new System.Drawing.Size(121, 42);
            this.btnDeleteA.TabIndex = 5;
            this.btnDeleteA.Text = "Xoá lớp A";
            this.btnDeleteA.UseVisualStyleBackColor = true;
            this.btnDeleteA.Click += new System.EventHandler(this.btnDeleteA_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(243, 292);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Kết thúc";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteB
            // 
            this.btnDeleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteB.Location = new System.Drawing.Point(410, 292);
            this.btnDeleteB.Name = "btnDeleteB";
            this.btnDeleteB.Size = new System.Drawing.Size(121, 42);
            this.btnDeleteB.TabIndex = 7;
            this.btnDeleteB.Text = "Xoá lớp B";
            this.btnDeleteB.UseVisualStyleBackColor = true;
            this.btnDeleteB.Click += new System.EventHandler(this.btnDeleteB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 432);
            this.Controls.Add(this.grQuanLi);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Li";
            this.grQuanLi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grQuanLi;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.Button btnDeleteB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteA;
        private System.Windows.Forms.Button btnLeftAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnRight;
    }
}

