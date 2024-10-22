﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENT_VALUE = 0.05m;
        const decimal TEN_CENT_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENT_VALUE = 0.25m;
        const decimal FIFTY_CENT_VALUE = 0.50m;
        private decimal total = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + 0.05m;
            totalLabel.Text = total.ToString("c");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + 0.10m;
            totalLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + 0.25m;
            totalLabel.Text = total.ToString("c");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total + 0.50m;
            totalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            totalLabel.Text = "";
        }
    }
}
