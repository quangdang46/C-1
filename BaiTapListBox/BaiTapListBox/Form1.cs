using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            if (txtInput.Text != "")
            {
                sv.Ten=txtInput.Text;
                lstA.Items.Add(sv);
                txtInput.Text = "";
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteA_Click(object sender, EventArgs e)
        {
            lstA.Items.Clear();
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            lstB.Items.Clear ();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstA.SelectedIndex != -1)
            {
                lstB.Items.Add(lstA.Items[lstA.SelectedIndex]);
                lstA.Items.RemoveAt(lstA.SelectedIndex);
            }

        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            while(lstA.Items.Count!=0)
            {
                lstB.Items.Add (lstA.Items[0]);
                lstA.Items.RemoveAt(0);
            }
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
            while (lstB.Items.Count != 0)
            {
                lstA.Items.Add(lstB.Items[0]);
                lstB.Items.RemoveAt(0);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstB.SelectedIndex != -1)
            {
                lstA.Items.Add(lstA.Items[lstB.SelectedIndex]);
                lstB.Items.RemoveAt(lstA.SelectedIndex);
            }
        }
    }
}
