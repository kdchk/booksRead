﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_02_Cow_calculator
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"I need {farmer.BagsOfFeed} bags of feed for {farmer.NumberOfCows} cows");
        }
    }
}
