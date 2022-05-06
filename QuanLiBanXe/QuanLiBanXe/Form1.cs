using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanXe
{
    public partial class Form1 : Form
    {
        List<KhachHang> dskh = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {


        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Ten = txtTen.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SoDienThoai = txtSdt.Text;
            if (rdDen.Checked)
            {
                kh.MauXe = "Den";
                lblPhu.Text = kh.PHU_THU_DEN.ToString();
            }
            else
            {
                kh.MauXe = "Khac";
                lblPhu.Text = "0";
            }
            kh.GiaXe = int.Parse(txtGia.Text);
            lblThue.Text = kh.THUE.ToString()+"%";
            lblThanhTien.Text = kh.ThanhTien.ToString();
            dskh.Add(kh);
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtGia.Text = "";
            txtSdt.Text = "";
            lblPhu.Text = "";
            lblThanhTien.Text = "";
            lblThue.Text = "";
            lblTong.Text = "";
            lblDen.Text = "";
            lblDoanhThu.Text = "";
            rdDen.Checked = false;
            rdKhac.Checked = false;
            txtTen.Focus();
            
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lblTong.Text = dskh.Count.ToString();
            int cnt = 0;
            double Tong = 0;
            foreach(KhachHang kh in dskh)
            {
                Tong += kh.ThanhTien;
                if (kh.MauXe == "Den")
                    cnt++;
            }
            lblDen.Text = cnt.ToString();
            lblDoanhThu.Text = Tong.ToString();
        }

        private void label11_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lblTong_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            ListBox lst = new ListBox();
            lst.Dock = DockStyle.Fill;
            frm.Controls.Add(lst);
            foreach (KhachHang kh in dskh)
            {
                lst.Items.Add(kh.Ten);
            }
        }
    }
}
