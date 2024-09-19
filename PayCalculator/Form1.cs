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
        //global variables
        double hours;
        double payRate;
        double pretax;
        double taxAmount;
        double earned;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //get inputs
            hours = Convert.ToDouble(hoursInput.Text);
            payRate = Convert.ToDouble(payRateInput.Text);

            //calculate values
            pretax = hours * payRate;
            taxAmount = pretax * 0.25;
            earned = pretax - taxAmount;

            //display outputs
            pretaxOutput.Text = $"{pretax.ToString("$.00")}";
            taxOutput.Text = $"{taxAmount.ToString("C")}";
            earnedOutput.Text = $"{earned.ToString("C")}";
        }
    }
}
