using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoBanWF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {
    
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textOutBox.Text = textInBox.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chxBold.Checked)
            {
                textOutBox.Font = new Font(textOutBox.Font.Name, textOutBox.Font.Size, textOutBox.Font.Style ^ FontStyle.Bold);
            }
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                textOutBox.ForeColor = radRed.ForeColor;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                textOutBox.ForeColor = radGreen.ForeColor;
            }
        }

        private void radYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radYellow.Checked)
            {
                textOutBox.ForeColor = radYellow.ForeColor;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                textOutBox.ForeColor = radBlack.ForeColor;
            }
        }

        private void chxItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chxItalic.Checked)
            {
                textOutBox.Font = new Font(textOutBox.Font.Name, textOutBox.Font.Size, textOutBox.Font.Style ^ FontStyle.Italic);
            }
        }

        private void chxUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chxUnderLine.Checked)
            {
                textOutBox.Font = new Font(textOutBox.Font.Name, textOutBox.Font.Size, textOutBox.Font.Style ^ FontStyle.Underline);
            }
        }
    }
}
