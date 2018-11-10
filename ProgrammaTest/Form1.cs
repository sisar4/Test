using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammaTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] vettore = { numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, numericUpDown6.Value, numericUpDown7.Value, numericUpDown8.Value, numericUpDown9.Value, numericUpDown10.Value };
            lblMax.Text = vettore.Max().ToString();
            lblMin.Text = vettore.Min().ToString();
            int x = 0;
	    int y = 4;
	    int xy = y-x;
        }
    }
}
