using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_for_a_dollar_game
{
    public partial class frmChangeForDollar : Form
    {
        public frmChangeForDollar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Initialized Constant Variables (DO NOT CHANGE DATA)
            const int PENNIES = 1;
            const int NICKLES = 5;
            const int DIMES = 10;
            const int QUARTERS = 25;

            //Declare Integer Variables
            int pennies;
            int nickles;
            int dimes;
            int quarters;
            int sum;

           
            //Initialize Bool Variables
            bool isPennies = int.TryParse(txtPennies.Text, out pennies);
            bool isNickles = int.TryParse(txtNickles.Text, out nickles);
            bool isDimes = int.TryParse(txtDimes.Text, out dimes);
            bool isQuarters = int.TryParse(txtQuarter.Text, out quarters);

          
             if (isPennies && isNickles && isDimes && isQuarters)
            {
                sum = (pennies * PENNIES) + (nickles * NICKLES) + (dimes * DIMES) + (quarters * QUARTERS);
                if(sum == 100)
                {
                    txtOutput.Text = "Congratualtions! The Sum equals $1";
                }else if(sum > 100)
                { 
                     txtOutput.Text = "The amount is greater than a dollar." + (sum/100).ToString("C");
                }
                else
                {
                    txtOutput.Text = "The amount is less than a dollar." + (sum / 100).ToString("C");

                }
            } else
            {
                //Error
                MessageBox.Show("Please enter valid number", "Invalid Input");

            }
    









        }
    }
}
