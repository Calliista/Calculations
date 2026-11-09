using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEquation.Text = "8 + 8 = " + (8 + 8);
            btnAddition.Enabled = false;
        }

        private void lblEquation_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            lblEquation.Text = "8 - 8 = " + (8 - 8);
            btnSubtraction.Enabled = false;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            lblEquation.Text = "8 / 8 = " + (8 / 8);
            btnDivision.Enabled = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblEquation.Text = "8 x 8 = " + (8 * 8);
            btnMultiply.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
