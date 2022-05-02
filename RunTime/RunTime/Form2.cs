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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Button last = null;
        Random rd = new Random();
        Button[,] Arrbtn = null;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            pnButton.Controls.Clear();
            int n = int.Parse(txtHang.Text);
            int m = int.Parse(txtCot.Text);
            Arrbtn = new Button[n, m];
            for(int i = 0; i < Arrbtn.GetLength(0); i++)
            {
                for (int j = 0; j < Arrbtn.GetLength(1); j++)
                {
                    Arrbtn[i, j] = new Button();
                    Arrbtn[i, j].Width = 50;
                    Arrbtn[i, j].Height = 50;
                    Arrbtn[i, j].BackColor = Color.WhiteSmoke;
                    Arrbtn[i, j].Text = rd.Next(101) + "";
                    Arrbtn[i, j].Location = new Point(j * Arrbtn[i, j].Width, i * Arrbtn[i, j].Height);
                    pnButton.Controls.Add(Arrbtn[i, j]);
                    Arrbtn[i, j].Tag = i + ";" + j;
                    Arrbtn[i, j].Click +=Btn_Click;
                }

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {

            if (last != null)
            {
                DoiMau(last, Color.WhiteSmoke);
            }
            Button btn = sender as Button;
            last = btn;
            DoiMau(last, Color.Yellow);
            last.BackColor = Color.Red;
        }


        void DoiMau(Button btn,Color cl)
        {
            String[] arr = btn.Tag.ToString().Split(';');
            int n = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);
            for (int i = 0; i < Arrbtn.GetLength(0); i++)
            {
                for (int j = 0; j < Arrbtn.GetLength(1); j++)
                {
                    if (i == n || j == m)
                    {
                        Arrbtn[i, j].BackColor = cl;
                    }
                }
            }

        }
        

    }
}
