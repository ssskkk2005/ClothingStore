using System;
using System.Windows.Forms;

namespace ReportsDemo
{
    
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            //(backend): get sales between dtpFrom.Value and dtpTo.Value,
          
        }

        private void btnShowStock_Click(object sender, EventArgs e)
        {
            //(backend): get products with quantity below numThreshold.Value,
            
        }

        private void btnShowTop_Click(object sender, EventArgs e)
        {
            //(backend): get products ordered by units sold (highest first),
            
        }
    }
}
