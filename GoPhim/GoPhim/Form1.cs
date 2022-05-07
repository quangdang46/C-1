using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    lbl0.BackColor = Color.Red;
                    break;
                case '1':
                    lbl1.BackColor = Color.Red;
                    break;
                case '2':
                    lbl2.BackColor = Color.Red;
                    break;
                case '3':
                    lbl3.BackColor = Color.Red;
                    break;
                case '4':
                    lbl4.BackColor = Color.Red;
                    break;
                case '5':
                    lbl5.BackColor = Color.Red;
                    break;
                case '6':
                    lbl6.BackColor = Color.Red;
                    break;
                case '7':
                    lbl7.BackColor = Color.Red;
                    break;
                case '8':
                    lbl8.BackColor = Color.Red;
                    break;
                case '9':
                    lbl9.BackColor = Color.Red;
                    break;
                case 'A':
                    lblA.BackColor = Color.Red;
                    break;
                case 'B':
                    lblB.BackColor = Color.Red;
                    break;
                case 'C':
                    lblC.BackColor = Color.Red;
                    break;
                case 'D':
                    lblD.BackColor = Color.Red;
                    break;
                case 'E':
                    lblE.BackColor = Color.Red;
                    break;
                case 'F':
                    lblF.BackColor = Color.Red;
                    break;
                case 'G':
                    lblG.BackColor = Color.Red;
                    break;
                case 'H':
                    lblH.BackColor = Color.Red;
                    break;
                case 'I':
                    lblI.BackColor = Color.Red;
                    break;
                case 'J':
                    lblJ.BackColor = Color.Red;
                    break;
                case 'K':
                    lblK.BackColor = Color.Red;
                    break;
                case 'L':
                    lblL.BackColor = Color.Red;
                    break;
                case 'M':
                    lblM.BackColor = Color.Red;
                    break;
                case 'N':
                    lblN.BackColor = Color.Red;
                    break;
                case 'O':
                    lblO.BackColor = Color.Red;
                    break;
                case 'P':
                    lblP.BackColor = Color.Red;
                    break;
                case 'Q':

                    lblQ.BackColor = Color.Red;
                    break;

                case 'R':
                    lblR.BackColor = Color.Red;
                    break;
                case 'S':
                    lblS.BackColor = Color.Red;
                    break;
                case 'T':
                    lblT.BackColor = Color.Red;
                    break;
                case 'U':
                    lblU.BackColor = Color.Red;
                    break;
                case 'V':
                    lblV.BackColor = Color.Red;
                    break;
                case 'W':
                    lblW.BackColor = Color.Red;
                    break;
                case 'X':
                    lblX.BackColor = Color.Red;
                    break;
                case 'Y':
                    lblY.BackColor = Color.Red;
                    break;
                case 'Z':
                    lblZ.BackColor = Color.Red;
                    break;
                
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
