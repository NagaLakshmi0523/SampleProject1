using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPluse_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtbtn1.Text);
            double num2 = double.Parse(txtbtn2.Text);   
            double result = num1 + num2;
            txtResult.Text = result.ToString();

        }

        private void btnMInus_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtbtn1.Text);
            double num2 = double.Parse(txtbtn2.Text);
            double result = num1 - num2;
            txtResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtbtn1.Text);
            double num2 = double.Parse(txtbtn2.Text);
            double result = num1 * num2;
            txtResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtbtn1.Text);
            double num2 = double.Parse(txtbtn2.Text);
            double result = num1 / num2;
            txtResult.Text = result.ToString();
        }
    }
}
