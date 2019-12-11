using System;
using System.Drawing;
using System.Windows.Forms;

namespace FiveColors2
{
    public partial class FiveColors2 : Form
    {
        public FiveColors2()
        {
            InitializeComponent();
        }

        private void radColorOne_CheckedChanged(object sender, EventArgs e)
        {
            if (radColorOne.Checked) {
                ActiveForm.BackColor = Color.Blue;
            } else {
                ActiveForm.BackColor = DefaultBackColor;
            }
        }
        private void radColorTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radColorTwo.Checked) {
                ActiveForm.BackColor = Color.Black;
            } else {
                ActiveForm.BackColor = DefaultBackColor;
            }
        }
        private void radColorThree_CheckedChanged(object sender, EventArgs e)
        {
            if (radColorThree.Checked) {
                ActiveForm.BackColor = Color.Red;
            } else {
                ActiveForm.BackColor = DefaultBackColor;
            }
        }
        private void radColorFour_CheckedChanged(object sender, EventArgs e)
        {
            if (radColorFour.Checked) {
                ActiveForm.BackColor = Color.Brown;
            } else {
                ActiveForm.BackColor = DefaultBackColor;
            }
        }
        private void radColorFive_CheckedChanged(object sender, EventArgs e)
        {
            if (radColorFive.Checked) {
                ActiveForm.BackColor = Color.White;
            } else {
                ActiveForm.BackColor = DefaultBackColor;
            }
        }
    }
}
