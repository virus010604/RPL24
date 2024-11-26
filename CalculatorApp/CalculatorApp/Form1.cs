using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text == "0" || isOperationPerformed)
            {
                tbDisplayResult.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            // validation on decimals more than 1
            if (button.Text == ".")
            {
                if (!tbDisplayResult.Text.Contains("."))
                {
                    tbDisplayResult.Text += button.Text;
                }
            }
            else
            {
                tbDisplayResult.Text += button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(tbDisplayResult.Text);
            lbCurrentOp.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                tbDisplayResult.Text = (resultValue + double
                .Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                tbDisplayResult.Text = (resultValue - double
                .Parse(tbDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "x")
            {
                tbDisplayResult.Text = (resultValue * double
                .Parse(tbDisplayResult.Text)).ToString();
            }
            else
            {
                tbDisplayResult.Text = (resultValue / double
                .Parse(tbDisplayResult.Text)).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbDisplayResult.Text.Length > 0)
            {
                tbDisplayResult.Text = tbDisplayResult.Text
                .Remove(tbDisplayResult.Text.Length - 1, 1);
            }
            if (tbDisplayResult.Text == "")
            {
                tbDisplayResult.Text = "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
            resultValue = 0;
            lbCurrentOp.Text = "";
        }
    }
}
