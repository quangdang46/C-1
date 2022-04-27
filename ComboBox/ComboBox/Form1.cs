using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lstB.Items.Add("Thong tin dat hang:");
            lstB.Items.Add("Khach hang:" + txtName.Text);
            lstB.Items.Add("Dien thoai: " + txtPhone.Text);
            lstB.Items.Add("San pham dat mua:");
            string txt="";
            txt += lstA.SelectedItem;
            lstB.Items.Add(txt);
            lstB.Items.Add("Cach thanh toan:" + cboPay.SelectedItem);
        }

        private void cboPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPay.SelectedIndex != -1)
            {
                MessageBox.Show("Ban chon thanh toan " + cboPay.SelectedItem);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cboPay1.SelectedIndex != -1)
            {
                MessageBox.Show("Ban chon thanh toan " + cboPay1.SelectedItem + "Phi la: " + ht3.Phithanhtoan);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HinhThucThanhToan ht1 = new HinhThucThanhToan();
            ht1.Ma = 1;
            ht1.Hinhthucthanhtoan = "Thanh toan tien mat";
            ht1.Phithanhtoan = 10;
            cboPay1.Items.Add(ht1);
            HinhThucThanhToan ht2 = new HinhThucThanhToan();
            ht2.Ma = 2;
            ht2.Hinhthucthanhtoan = "Thanh toan qua ATM";
            ht2.Phithanhtoan = 20;
            cboPay1.Items.Add(ht2);
            HinhThucThanhToan ht3 = new HinhThucThanhToan();
            ht3.Ma = 3;
            ht3.Hinhthucthanhtoan = "Thanh toan qua Internet";
            ht3.Phithanhtoan = 30;
            cboPay1.Items.Add(ht3);


            
        }
    }
}
