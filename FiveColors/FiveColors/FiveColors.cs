﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors
{
    public partial class FiveColors : Form
    {
        public FiveColors()
        {
            InitializeComponent();
        }
        private void btnColorOne_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Blue;
        }
        private void btnColorTwo_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Black;
        }
        private void btnColorThree_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Red;
        }
        private void btnColorFour_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.Brown;
        }
        private void btnColorFive_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColor = Color.White;
        }
    }
}
