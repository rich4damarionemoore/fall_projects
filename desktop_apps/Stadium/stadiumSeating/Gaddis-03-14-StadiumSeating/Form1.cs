using System;
using System.Windows.Forms;

namespace stadiumSeating
{
    public partial class frmStadiumSeating : Form
    {
        public frmStadiumSeating()
        {
            InitializeComponent();
        }

        private void btnCalculateIncome_Click(object sender, EventArgs e)
        {
            const int CLASS_A_COST = 15;
            const int CLASS_B_COST = 12;
            const int CLASS_C_COST = 9;


            string classATicketStr = txtClassA.Text;
            string classBTicketStr = txtClassB.Text;
            string classCTicketStr = txtClassC.Text;
       
               

            int classATicketsSoldNum = Convert.ToInt32(classATicketStr);
            int classBTicketsSoldNum = Convert.ToInt32(classBTicketStr);
            int classCTicketsSoldNum = Convert.ToInt32(classCTicketStr);
            
            int classAIncomeNum = classATicketsSoldNum * CLASS_A_COST;
            int classBIncomeNum = classBTicketsSoldNum * CLASS_B_COST;
            int classCIncomeNum = classCTicketsSoldNum * CLASS_C_COST;


            int totalIncome = classAIncomeNum + classBIncomeNum + classCIncomeNum;
           
            txtClassAIncome.Text = classAIncomeNum.ToString("c");
            txtClassBIncome.Text = classBIncomeNum.ToString("c");
            txtClassCIncome.Text = classBIncomeNum.ToString("c");
            txtTotalIncome.Text = totalIncome.ToString("C");
       }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Clear();
            txtClassB.Clear();
            txtClassC.Clear();


            txtClassAIncome.Clear();
            txtClassBIncome.Clear();
            txtClassCIncome.Clear();
            txtTotalIncome.Clear();

            txtClassA.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



