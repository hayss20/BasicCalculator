using System;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void computebtn_Click(object sender, EventArgs e)
        {
            try {
                if (opecb.Text == "+")
                {
                    resultrtb.Text = BasicComputation.Add(float.Parse(num1tb.Text), float.Parse(num2tb.Text)).ToString();
                }
                else if (opecb.Text == "-")
                {
                    resultrtb.Text = BasicComputation.Subtract(float.Parse(num1tb.Text), float.Parse(num2tb.Text)).ToString();
                }
                else if (opecb.Text == "*")
                {
                    resultrtb.Text = BasicComputation.Multiply(float.Parse(num1tb.Text), float.Parse(num2tb.Text)).ToString();
                }
                else if (opecb.Text == "/")
                {
                    resultrtb.Text = BasicComputation.Divide(float.Parse(num1tb.Text), float.Parse(num2tb.Text)).ToString();
                }
                else
                {
                    resultrtb.Text = "Please select a valid operation.";
                }   
            }
            catch (FormatException)
            {
                resultrtb.Text = "Please enter valid numbers.";
            }
            catch (DivideByZeroException ex)
            {
                resultrtb.Text = ex.Message;
            }
            catch (Exception ex)
            {
                resultrtb.Text = "An error occurred: " + ex.Message;
            }
        }
    }
}
