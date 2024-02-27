using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//header comment

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        double hours;
        double rate;
        double subtotal;
        double taxAmount;
        double totalAmount;
        double taxRate = 0.2;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                hours = Convert.ToDouble(hoursInput.Text);
                rate = Convert.ToDouble(rateInput.Text);

                subtotal = hours * rate;
                taxAmount = subtotal * taxRate;
                totalAmount = subtotal - taxAmount;

                subtotalOutput.Text = $"{subtotal.ToString(".00")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalAmount.ToString("C")}";
            }
            catch
            {
                subtotalOutput.Text = "ERROR";
                taxOutput.Text = "";
                totalOutput.Text = "";
            }
        }
    }
}
