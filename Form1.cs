﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS_PBKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal input))
            {
                decimal result = input * 14925;
                textBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            decimal inputNumber;
            if (decimal.TryParse(textBox1.Text, out inputNumber))
            {
                decimal result = inputNumber * 113.433m;
                textBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input value. Please enter a valid decimal number.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal inputNumber;
            if (decimal.TryParse(textBox1.Text, out inputNumber))
            {
                decimal result = inputNumber * 0.46m;
                textBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input value. Please enter a valid decimal number.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal inputNumber;
            if (decimal.TryParse(textBox1.Text, out inputNumber))
            {
                decimal result = inputNumber * 7.17m;
                textBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input value. Please enter a valid decimal number.");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            decimal inputNumber;
            if (decimal.TryParse(textBox1.Text, out inputNumber))
            {
                decimal result = inputNumber * 0.25m;
                textBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input value. Please enter a valid decimal number.");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            decimal inputNumber;
            if (decimal.TryParse(textBox1.Text, out inputNumber))
            {
                decimal result = inputNumber * 0.06m;
                textBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input value. Please enter a valid decimal number.");
            }
        }
    }
}
