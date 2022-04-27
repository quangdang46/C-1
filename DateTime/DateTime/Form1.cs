using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(txtAge, "");
            errorProvider1.SetError(dtpDate, "");
            if (txtName.Text =="")
            {
                errorProvider1.SetError(txtName, "Nhap khong dung dinh dang");
            }
            int tuoi=0;
            if(int.TryParse(txtAge.Text, out tuoi)==false)
            {
                errorProvider1.SetError(txtAge, "Khong dung dinh dang");
            }
            else
            {
                if(tuoi< 18)
                {
                    errorProvider1.SetError(txtAge, "Khong du tuoi dang ki");
                }
            }
            if (dtpDate.Value.DayOfWeek ==DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dtpDate, "Chu nhat khong lam");

            }
        }
    }
}