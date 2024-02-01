using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WindowsForm_
{
    public partial class Form1 : Form
    {
        RUleCalculator calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool ValidateInput()
        {
            bool isValid = true;
            if (Number1.Value == 0)
            {
                isValid = false;               
                MessageBox.Show("PLs Enter first number !");
            }
            else 
            {
                if (Number2.Value==0) 
                {
                    isValid = false;
                    MessageBox.Show("PLs Enter second number !");
                }
            }
            return isValid;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int Minus = calculate.Minus((int)Number1.Value, (int)Number2.Value);
                MessageBox.Show("Result is : " + Minus);
            }

        }

        private void btnMultipule_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int Multipule = calculate.Multipule((int)Number1.Value, (int)Number2.Value);
                MessageBox.Show("Result is : " + Multipule);
            }

        }

        private void btnDivde_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int Divide = calculate.Divide((int)Number1.Value, (int)Number2.Value);
                MessageBox.Show("Result is : " + Divide);
            }

        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int Sum = calculate.Sum((int)Number1.Value, (int)Number2.Value);
                MessageBox.Show("Result is : " + Sum);
            }
        }
    }
}
