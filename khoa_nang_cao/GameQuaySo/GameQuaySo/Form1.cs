using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameQuaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random rd = new Random();
        int tienMay =100;
        int tienNguoi = 100;
        int cnt = 0;
        int so1;
        int so2;
        int so3;
        private void btnQuay_Click(object sender, EventArgs e)
        {
            tienMay = int.Parse(lblMay.Text);
            tienNguoi = int.Parse(lblNguoi.Text);
            if (tienNguoi >= 30)
            {
                timer1.Start();
                tienNguoi -= 30;
                tienMay += 30;
                lblNguoi.Text = tienNguoi.ToString();
                lblMay.Text = tienMay.ToString();
            }
            else
            {
                MessageBox.Show("Bạn không đủ tiền");
            }

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            lblNguoi.Text = "100";
            lblMay.Text = "100";
            lbl1.Text = "7";
            lbl2.Text = "7";
            lbl3.Text = "7";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int so1 = rd.Next(0, 9);
            int so2 = rd.Next(0, 10);
            int so3 = rd.Next(0, 11);
            lbl1.Text = so1.ToString();
            lbl2.Text = so2.ToString();
            lbl3.Text = so3.ToString();
            if (cnt > 100)
            {
                if (so1 == 7)
                {
                    tienNguoi += 100 + (int)0.5 * tienMay;
                    tienMay -= 100 + (int)0.5 * tienMay;
                }
                if (so2 == 7)
                {
                    tienNguoi += 30 + (int)0.5 * tienMay;
                    tienMay -= 30 + (int)0.5 * tienMay;
                }
                if (so3 == 7)
                {
                    tienNguoi += 10;
                    tienMay -= 10;
                }
                lblNguoi.Text = tienNguoi.ToString();
                lblMay.Text = tienMay.ToString();

                timer1.Stop();
                cnt = 0;
            }
            cnt++;
        }
    }
}
