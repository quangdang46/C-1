using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cklbLeft.Items.AddRange(cklbRight.Items);
            cklbRight.Items.Clear();
        }

        private void cklbLeft_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             cklbLeft.Items.AddRange(new String[]
             {
                "Teo",
                "Ty",
                "Hang",
                "Huong"
             });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            foreach(int i in cklbLeft.SelectedIndices)
            {
                cklbRight.Items.Add(cklbLeft.Items[i]);
                cklbLeft.Items.RemoveAt(i);
            }
            */
            for(int i = 0; i < cklbLeft.Items.Count; ++i)
            {
                if (cklbLeft.GetItemChecked(i))
                {
                    cklbRight.Items.Add(cklbLeft.Items[i]);
                    cklbLeft.Items.RemoveAt(i);
                }
            }

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            cklbRight.Items.AddRange(cklbLeft.Items);
            cklbLeft.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach(int i in cklbRight.SelectedIndices)
            {
                cklbLeft.Items.Add(cklbRight.Items[i]);
                cklbRight.Items.RemoveAt(i);
            }
        }
    }
}
