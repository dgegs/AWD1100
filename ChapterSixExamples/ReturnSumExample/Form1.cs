using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnSumExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Sum(double a, double b, double c)
        {
            double theSum = a + b + c;
            lblSumDisplay.Text = $"{theSum}";
            return theSum;
        }

        private double Average(double total, double divideBy)
        {
             total /= divideBy;
            return total;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double num3 = Convert.ToDouble(txtNumber3.Text);
            double total = Sum(num1, num2, num3);
            double average =  Average(total, 3);
            lblAvgDisplay.Text = average.ToString();

        }
    }
}
