using System;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            lblMake.Text += " unregistered";
            lblModel.Text += " unregistered";
            lblYear.Text += $" {new Random().Next(1900, 2021)}";
        }
    }
}
