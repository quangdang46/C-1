using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex != -1)
            {
                lstSinhVien.Items.RemoveAt(lstSinhVien.SelectedIndex);
            }
            txtMa.Text = "";
            txtTen.Text = "";
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv=new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            lstSinhVien.Items.Add(sv);
            txtMa.Text = "";
            txtTen.Text = "";
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex != -1)
            {
                SinhVien sv=lstSinhVien.SelectedItem as SinhVien;
                txtMa.Text = sv.Ma.ToString();
                txtTen.Text = sv.Ten;
            }
        }
    }
}
