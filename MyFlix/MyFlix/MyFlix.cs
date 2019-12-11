using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class MyFlix : Form
    {
        public MyFlix()
        {
            InitializeComponent();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            lblPrice.Text = (lstSelections.SelectedItems.Count * 1.99).ToString("C");
            lblPrice.Visible = true;
        }

        private void lstSelections_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Visible = false;
        }
    }
}
