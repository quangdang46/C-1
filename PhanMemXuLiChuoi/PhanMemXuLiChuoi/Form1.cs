using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemXuLiChuoi
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDem_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    cnt++;
            }
            txtOutput.Text = cnt.ToString();
        }

        private void btnHoa_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToUpper();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.ToLower();
        }

        private void btnDemHoa_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            int tmp =0;
            foreach (char x in s)
            {
                if (x >= 'A' && x <= 'Z')
                {
                    tmp++;
                }
                        }
            txtOutput.Text = tmp.ToString();
        }

        private void btnDemThuong_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            int tmp = 0;
            foreach (char x in s)
            {
                if (x >= 'a' && x <= 'z')
                {
                    tmp++;
                }
            }
            txtOutput.Text = tmp.ToString();
        }

        private void btnDemSo_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            int tmp = 0;
            foreach (char x in s)
            {
                if (x >= '0' && x <= '9')
                {
                    tmp++;
                }
            }
            txtOutput.Text = tmp.ToString();
        }

        private void btnDao_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            String tmp = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                tmp += s[i];
            }
            txtOutput.Text = tmp;
        }

        private void btnToiUu_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            String tmp = "";
            s.Trim();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] == ' ' || s[i - 1] == ' ' && s[i] != s[i-1])
                {
                    s.Remove(i, 1);
                }
            }
            txtOutput.Text =s;
        }

        private void btnDauTien_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            String check = txtDauTien.Text;
            txtOutput.Text = s.IndexOf(check).ToString();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text;
            String check = txtCuoi.Text;
            txtOutput.Text = s.LastIndexOf(check).ToString();
        }

        private void btnTachTu_Click(object sender, EventArgs e)
        {
            
            /*
            String[] arr = txtInput.Text.Split(new string[] { regex }, 
                StringSplitOptions.None);
            foreach(String s in arr)
            {
                txtOutput.Text += s + "\r\n";
            }
            */
            char[] regex = txtTachTu.Text.ToCharArray();
            String[] arr = txtInput.Text.Split(regex, StringSplitOptions.None);
            foreach (String s in arr)
            {
                txtOutput.Text += s + "\r\n";
            }

        }

        private void btnDemXh_Click(object sender, EventArgs e)
        {
            String check = txtInput.Text;
            String tmp = txtDemXh.Text;
            int dem = 0;
            int vt = check.IndexOf(tmp);
            if (vt!= -1)
            {
                while (vt != -1)
                {
                    dem++;
                    //bo qua doan da lay duoc
                    check = check.Substring(vt + tmp.Length);
                    vt = check.IndexOf(tmp);
                }
                txtOutput.Text = dem.ToString();
            }
            else
            {
                txtOutput.Text = "Khong";
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtInput.Text.Replace(txtOld.Text, txtNew.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int vt = txtInput.Text.IndexOf(txtXoa.Text);
            if (vt != -1)
            {
                txtOutput.Text = txtInput.Text.Remove(vt, txtXoa.Text.Length);
            }
            else
            {
                txtOutput.Text = "Khong";
            }
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            String s = txtInput.Text.Insert(int.Parse(txtVitri.Text),txtChuoi.Text);
            txtOutput.Text = s;
        }

        private void btnTrich_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtViTri2.Text) < txtInput.Text.Length)
            {
                txtOutput.Text = txtInput.Text.Substring(int.Parse(txtViTri1.Text), int.Parse(txtViTri2.Text));
            }
            else
            {
                txtOutput.Text = "Khong";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Ban co muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
