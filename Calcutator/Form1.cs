using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.CodeDom.Compiler;
using System.Security.Permissions;
using CSE;

namespace Calcutator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{textBox1.Text}/";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            //double num1 = Double.Parse(textBox1.Text);

            //decimal total = Decimal.Add(Decimal.Multiply(test, Decimal.Zero), Decimal.Zero);
            //計算式
            CsEval.EvalEnvironment = this;
            var eval = CsEval.Eval(textBox1.Text);
            textBox1.Text = eval.ToString();
            
        }
    }
}
