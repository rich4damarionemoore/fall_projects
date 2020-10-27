using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radFirstRed.Checked && radSecondRed.Checked)
                this.BackColor = System.Drawing.Color.Red;
            else if (radFirstBlue.Checked && radSecondBlue.Checked)
                this.BackColor = System.Drawing.Color.Blue;
            else if (radFirstYellow.Checked && radSecondYellow.Checked)
                this.BackColor = System.Drawing.Color.Yellow;
            else if ((radFirstRed.Checked && radSecondBlue.Checked) ||
                (radFirstBlue.Checked && radSecondRed.Checked))
                this.BackColor = System.Drawing.Color.Purple;
            else if ((radFirstBlue.Checked && radSecondYellow.Checked) ||
                radFirstYellow.Checked && radSecondBlue.Checked)
                this.BackColor = System.Drawing.Color.Green;
            else
                this.BackColor = System.Drawing.Color.Orange;

            {

            }
        }
    }
}
