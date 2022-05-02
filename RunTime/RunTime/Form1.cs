using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunTime
{
    public partial class Form1 : Form
    {
        Button last = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Button btn = new Button();
            btn.Text = rd.Next(101).ToString();
            btn.BackColor = Color.Yellow;
            btn.Height = 30;
            btn.Width = 100;
            pnButton.Controls.Add(btn);
            btn.Click += Btn_Click; 
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (last!=null)//da chon truoc do
            {
                last.BackColor = Color.Yellow;
            }
            btn.BackColor = Color.Red;
            last = btn;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (last != null)
            {
                pnButton.Controls.Remove(last);
                last = null;
            }
        }
    }
}
