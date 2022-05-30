using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGiaoVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst1.Items.AddRange(new string[] { "Tran Van A", "Tran Van B", "Nguyen Thi C", "Tran Quang Dang" });
            lst2.Items.AddRange(new string[] { "10A1", "10A2", "10A3", "10A4" });
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        static Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        static List<string> lst = new List<string>();
        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        static bool isExit(String[] lop) {
            foreach (string s in lop)
            {
                if (lst.Contains(s))
                    return true;
            }
            return false;

        }
        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            String gv=lst1.SelectedItem.ToString();
            String[] lop = lst2.SelectedItems.Cast<string>().ToArray();
            if (isExit(lop))
            {
                MessageBox.Show("Lop da phan cong");
                return;
            }
            if (lop.Length >= 3)
            {
                MessageBox.Show("Chon toi da 2 lop");
                return;
            }



            if (dic.ContainsKey(gv))
            {
                if (dic[gv].Count+lop.Length>=3)
                {
                    MessageBox.Show("Chon toi da 2 lop");
                }
                else
                {
                    //
    
                    dic[gv].AddRange(lop);
                    lst.AddRange(lop);
                    foreach (string s in lop)
                    {
                        lst3.Items.Add(gv + " CN LOP " + s);
                    }
                }
            }
            else
            {
                dic.Add(gv, new List<string>());
                dic[gv].AddRange(lop);
                lst.AddRange(lop);
                foreach (string s in lop)
                {
                    lst3.Items.Add(gv + " CN LOP " + s);
                }
            }
        }
    }
}
