using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTIenBanSach
{
    public partial class Form1 : Form
    {
        DanhSachKhachHang csdl=new DanhSachKhachHang();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
        void XoaTrang()
        {
            txtTen.Text = "";
            txtSoLuong.Text = "";
            txtTT.Text = "";
            chxLaSv.Checked = false;
            txtTen.Focus();
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang kh=new KhachHang();
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else
            {
                kh.MaKH=txtTen.Text;
            }
            int sl = 0;
            if(int.TryParse(txtSoLuong.Text,out sl) == false)
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            {
                kh.SoLuong=sl;
            }
            //kh.LaSV=chxLaSv.Checked;
            if (chxLaSv.Checked)
            {
                kh.LaSV = true;
            }
            else
            {
                kh.LaSV = false;
            }
            csdl.Mua(kh);
            txtTT.Text = kh.TinhTien + "";
        
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            XoaTrang();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            txtTong.Text = csdl.TongSo + "";
            txtSV.Text = csdl.TongSoSv + "";
            txtDoanhThu.Text = csdl.DoanhThu + "";
        }

        private void txtTong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKh = new Form();
            frmKh.Width = frmKh.Height = 500;
            ListBox lstKh = new ListBox();
            frmKh.Controls.Add(lstKh);
            lstKh.Dock = DockStyle.Fill;
            foreach (KhachHang kh in csdl.dsKh)
            {
                lstKh.Items.Add(kh.MaKH);
            }
            frmKh.ShowDialog();
        }

        private void txtSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frmKh = new Form();
            frmKh.Width = frmKh.Height = 500;
            ListBox lstKh = new ListBox();
            frmKh.Controls.Add(lstKh);
            lstKh.Dock = DockStyle.Fill;
            foreach (KhachHang kh in csdl.dsKh)
            {
                if (kh.LaSV)
                {
                    lstKh.Items.Add(kh.MaKH);
                }
            }

            //Chinh vi tri hien form
            frmKh.StartPosition = FormStartPosition.CenterScreen;
            frmKh.ShowDialog();
        }
    }
}
