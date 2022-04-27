using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //visiable kiem tra co hien tren form khong
            if (picOff.Visible == true)
            {
                btnDisplay.Text = txtName.Text + ". Turn on the light please!!";
            }
            else
            {
                btnDisplay.Text = txtName.Text + ". Turn off the light please!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (picOff.Visible == true)
            {
                picOff.Visible = false;
                picOn.Visible = true;
                btnDisplay.Text = txtName.Text + ". Turn off the light please!!";
            }
            else
            {
                picOff.Visible = true;
                picOn.Visible = false;
                btnDisplay.Text = txtName.Text + ". Turn on the light please!!";
            }
        }

        private void picOff_Click(object sender, EventArgs e)
        {

        }
    }
}
