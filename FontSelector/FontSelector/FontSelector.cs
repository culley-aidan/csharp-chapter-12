using System;
using System.Drawing;
using System.Windows.Forms;

namespace FontSelector
{
    public partial class FontSelector : Form
    {
        public FontSelector()
        {
            InitializeComponent();
        }
        private void btnFinish_Click(object sender, EventArgs e) 
            => lblDisplay.Font = new Font(lstFonts.Items[lstFonts.SelectedIndex].ToString(), int.Parse((string)lstSize.Items[lstSize.SelectedIndex]));

        private void FontSelector_Load(object sender, EventArgs e)
        {
            lstFonts.SelectedIndex = 0;
            lstSize.SelectedIndex = 0;
        }
    }
}
