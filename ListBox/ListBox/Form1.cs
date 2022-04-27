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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int element = 0;
            if(int.TryParse(txtInput.Text,out element))
            {
                lstA.Items.Add(element);
            }
            txtInput.Text = "";
        }

        private void btnDeleteFL_Click(object sender, EventArgs e)
        {
            lstA.Items.RemoveAt(0);
            lstA.Items.RemoveAt(lstA.Items.Count-1);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum=0,n=lstA.Items.Count;
            for(int i = 0; i < n; i++)
            {
                sum += (int)lstA.Items[i];
            }
            lstA.Items.Add(sum);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (lstA.SelectedIndex != -1)
            //{
              //  lstA.Items.Remove(lstA.SelectedIndex);
            //}
            while(lstA.SelectedIndices.Count > 0)
            {
                lstA.Items.RemoveAt(lstA.SelectedIndices[0]);
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstA.Items.Count; i++)
            {
                lstA.Items[i]= (int)lstA.Items[i]+2;
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstA.Items.Count; i++)
            {
                lstA.Items[i] =Math.Pow((int)lstA.Items[i],2);
            }
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            //bo chon toan bo cac so da con
            lstA.SelectedIndex = -1;
            for (int i = 0; i < lstA.Items.Count; i++)
            {
                if ((int)lstA.Items[i] % 2 == 0)
                {
                    lstA.SelectedIndex = i;
                }
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            //bo chon toan bo cac so da con
            lstA.SelectedIndex = -1;
            for (int i = 0; i < lstA.Items.Count; i++)
            {
                if ((int)lstA.Items[i] % 2 != 0)
                {
                    lstA.SelectedIndex = i;
                }
            }

        }
    }
}
