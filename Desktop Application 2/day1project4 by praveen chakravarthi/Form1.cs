﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day1project4_by_praveen_chakravarthi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fn =Convert.ToInt32(textBox1.Text);
            int sn =Convert.ToInt32(textBox2.Text);
            int p = 1;
            for (int i = 1; i <= sn; i++)
                p = p * fn;

            textBox3.Text = p.ToString();

        }
    }
}
