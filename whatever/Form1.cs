﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whatever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, c;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World~";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0424 hello world");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            b = int.Parse(textBox3.Text);
            label2.Text = "-";
            c = a - b;
            textBox4.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            MessageBox.Show("good");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            b = int.Parse(textBox3.Text);
            label2.Text = "+";
            c = a + b;
            textBox4.Text = c.ToString();
        }
    }
}