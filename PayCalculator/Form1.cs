using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        double hours;
        double payRate;
        double preTax;

        double taxRate = 0.25;
        double taxAmount;
        double earnedAmount;


        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the inputs
                hours = Convert.ToDouble(hoursInput.Text);
                payRate = Convert.ToDouble(payRateInput.Text);

                //calculate all values
                preTax = hours * payRate;
                taxAmount = preTax * taxRate;
                earnedAmount = preTax - taxAmount;

                //output all amounts
                pretaxOutput.Text = $"{preTax.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                earnedOutput.Text = $"{earnedAmount.ToString("C")}";
            }
            catch
            {
                pretaxOutput.ForeColor = Color.Red;
                pretaxOutput.Text = "";
                taxOutput.Text = "";
                earnedOutput.Text = "";
            }
        }
    }
}
