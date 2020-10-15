using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Joker";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "2 of diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "2 of hearts";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "2 of spades";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            lblOutput.Text = "2 of clubs";
        }
    }

}
