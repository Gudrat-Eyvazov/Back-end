using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_WindowsFormCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string total;
        int num1;
        int num2;
        string option;
        int result;

        private void txtResault_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "2";
        }
         private void button10_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtResault.Clear();
            result = 0;
            num2 = 0;
            num1    = 0;
        }

        private void btnnoqte_Click(object sender, EventArgs e)
        {
            txtResault.Text = txtResault.Text + ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            option = "+";
            num1=int.Parse(txtResault.Text);
            txtResault.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtResault.Text);
            txtResault.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtResault.Text);
            txtResault.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtResault.Text);
            txtResault.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2=int.Parse(txtResault.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            if (option.Equals("-"))
            {
                result = num1 - num2;
            }
            if (option.Equals("*"))
            {
                result = num1 * num2;
            }
            if (option.Equals("/"))
            {
                result = num1 / num2;
            }
            txtResault.Text=result+" ";
        }
    }
}
