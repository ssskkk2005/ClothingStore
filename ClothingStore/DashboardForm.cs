namespace clothingstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Dashboard1.Click += Dashboard1_Click;
            Products2.Click += Products2_Click;
            ManagementSizesColors3.Click += ManagementSizesColors3_Click;
            Inventory4.Click += Inventory4_Click;
            ManagementReports5.Click += ManagementReports5_Click;
            ManagementSales6.Click += ManagementSales6_Click;
            SignOut7.Click += SignOut7_Click;
        }

        private void Dashboard1_Click(object? sender, EventArgs e) { }
        private void Products2_Click(object? sender, EventArgs e) { }
        private void ManagementSizesColors3_Click(object? sender, EventArgs e) { }
        private void Inventory4_Click(object? sender, EventArgs e) { }
        private void ManagementReports5_Click(object? sender, EventArgs e) { }
        private void ManagementSales6_Click(object? sender, EventArgs e) { }

        private void SignOut7_Click(object? sender, EventArgs e) { }
    }
}