using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_With_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            String tmp = "";
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
                tmp += arr[i] + " ";
            }
            txtInput.Text = tmp.Trim();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            String[] arr = txtInput.Text.Split(' ');
            foreach(String s in arr)
            {
                sum += int.Parse(s);
            }
            txtOutput.Text = sum.ToString();
        }

        private void btnDemLe_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            String[] arr = txtInput.Text.Split(' ');
            foreach (String s in arr)
            {
                if (int.Parse(s) % 2 != 0)
                {
                    cnt++;
                }
            }
            txtOutput.Text = cnt.ToString();
        }

        private void btnSumLe_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            String[] arr = txtInput.Text.Split(' ');
            foreach (String s in arr)
            {
                if (int.Parse(s) % 2 != 0)
                {
                    cnt+= int.Parse(s);
                }
            }
            txtOutput.Text = cnt.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            String[] arr = txtInput.Text.Split(' ');
            int cnt = int.Parse(arr[0]);
            foreach (String s in arr)
            {
                if (int.Parse(s) < cnt)
                {
                    cnt = int.Parse(s);
                }
            }
            txtOutput.Text = cnt.ToString();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            String tmp = "";
            String[] arr = txtInput.Text.Split(' ');
            foreach (String s in arr)
            {
                tmp += (int.Parse(s) + 2) + " ";
            }
            txtOutput.Text = tmp;
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            String tmp = "";
            String[] arr = txtInput.Text.Split(' ');
            int[] arr2 = new int[arr.Length];
            for (int i= 0; i < arr.Length; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            Array.Sort(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                tmp += arr2[i] + " ";
            }
            txtOutput.Text = tmp.Trim();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            String tmp = "";
            String[] arr = txtInput.Text.Split(' ');
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            Array.Sort(arr2);
            Array.Reverse(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                tmp += arr2[i] + " ";
            }
            txtOutput.Text = tmp.Trim();
        }
    }
}
