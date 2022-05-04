using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim
{
    public partial class Form1 : Form
    {
        List<Customer> dskh = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnGhe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tao100Ghe();
        }

        private void Tao100Ghe()
        {
            int ghe = 1;
            pnGhe.Controls.Clear();
            for(int i = 0; i < pnGhe.RowCount; i++)
            {
                for (int j = 0; j < pnGhe.ColumnCount; j++)
                {
                    Label lbl = new Label();
                    lbl.Text = ghe + "";
                    ghe++;
                    lbl.AutoSize = false;
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.BackColor = Color.WhiteSmoke;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    pnGhe.Controls.Add(lbl, j, i);
                    lbl.Click += Lbl_Click;
                    //cot dong
                }
            }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label lbl_ghe = sender as Label;
            if (lbl_ghe.BackColor == Color.WhiteSmoke)
            {
                lbl_ghe.BackColor = Color.Green;
            }
            else if (lbl_ghe.BackColor == Color.Green)
            {
                lbl_ghe.BackColor = Color.WhiteSmoke;
            }
            else if (lbl_ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghe da duoc chon");
            }

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            NguoiDat frm = new NguoiDat();
            cus.Name = frm.txtTen.Text;
            cus.Phone = frm.txtSdt.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < pnGhe.Controls.Count; i++)
                {
                    Label lbl = pnGhe.Controls[i] as Label;
                    if (lbl.BackColor == Color.Green)
                    {
                        lbl.BackColor = Color.Yellow;
                        cus.ghes.Add(int.Parse(lbl.Text));
                    }
                }
            }
            dskh.Add(cus);
            lblThanhTien.Text = cus.TinhTien+"";
            HienThiTongTien();
            HienThiKhachHang();
        }

        private void HienThiKhachHang()
        {
            lstKhachHang.Items.Clear();
            foreach (Customer cs in dskh)
            {
                lstKhachHang.Items.Add(cs);
            }
        }

        private void HienThiTongTien()
        {
            int tong = 0;
            foreach(Customer cs in dskh)
            {
                tong += cs.TinhTien;
            }
            lblTongThanhTien.Text = tong + "";
        }
    }
}
