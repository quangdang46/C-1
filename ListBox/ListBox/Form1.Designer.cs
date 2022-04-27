namespace ListBox
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteFL = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhâp số";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(99, 21);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(377, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Location = new System.Drawing.Point(35, 73);
            this.lstA.Name = "lstA";
            this.lstA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstA.Size = new System.Drawing.Size(229, 303);
            this.lstA.TabIndex = 2;
            this.lstA.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOdd);
            this.groupBox1.Controls.Add(this.btnEven);
            this.groupBox1.Controls.Add(this.btnSquare);
            this.groupBox1.Controls.Add(this.btnAdd2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnDeleteFL);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Location = new System.Drawing.Point(281, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 303);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(28, 25);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(273, 31);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Tổng phần tử";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFL
            // 
            this.btnDeleteFL.Location = new System.Drawing.Point(28, 62);
            this.btnDeleteFL.Name = "btnDeleteFL";
            this.btnDeleteFL.Size = new System.Drawing.Size(273, 31);
            this.btnDeleteFL.TabIndex = 0;
            this.btnDeleteFL.Text = "Xoá phần tử đầu và cuối";
            this.btnDeleteFL.UseVisualStyleBackColor = true;
            this.btnDeleteFL.Click += new System.EventHandler(this.btnDeleteFL_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(273, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xoá phần tử đang chọn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(28, 136);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(273, 31);
            this.btnAdd2.TabIndex = 0;
            this.btnAdd2.Text = "Tăng mỗi phần tử lên 2";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(28, 173);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(273, 31);
            this.btnSquare.TabIndex = 0;
            this.btnSquare.Text = "Thay bằng bình phương";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(28, 210);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(273, 31);
            this.btnEven.TabIndex = 0;
            this.btnEven.Text = "Chọn số chẵn";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.Location = new System.Drawing.Point(28, 247);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(273, 31);
            this.btnOdd.TabIndex = 0;
            this.btnOdd.Text = "Chọn số lẻ";
            this.btnOdd.UseVisualStyleBackColor = true;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(35, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(572, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Kết thúc";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(496, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 25);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 441);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteFL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
    }
}

