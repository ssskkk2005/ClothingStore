#nullable disable
namespace ClothingStoreManager
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnSizesColors = new Button();
            btnInventory = new Button();
            btnReports = new Button();
            btnSales = new Button();
            pnlMain = new Panel();
            dgvLowStock = new DataGridView();
            colLsProduct = new DataGridViewTextBoxColumn();
            colLsSize = new DataGridViewTextBoxColumn();
            colLsColor = new DataGridViewTextBoxColumn();
            colLsQuantity = new DataGridViewTextBoxColumn();
            colLsReorderLevel = new DataGridViewTextBoxColumn();
            lblLowStock = new Label();
            dgvRecentSales = new DataGridView();
            colRsId = new DataGridViewTextBoxColumn();
            colRsDate = new DataGridViewTextBoxColumn();
            colRsCashier = new DataGridViewTextBoxColumn();
            colRsDiscount = new DataGridViewTextBoxColumn();
            colRsTotal = new DataGridViewTextBoxColumn();
            lblRecentSales = new Label();
            flpCards = new FlowLayoutPanel();
            pnlCardProducts = new Panel();
            lblProductsTitle = new Label();
            lblProductsValue = new Label();
            pnlCardVariants = new Panel();
            lblVariantsTitle = new Label();
            lblVariantsValue = new Label();
            pnlCardUnits = new Panel();
            lblUnitsTitle = new Label();
            lblUnitsValue = new Label();
            pnlCardLowStock = new Panel();
            lblLowStockItemsTitle = new Label();
            lblLowStockItemsValue = new Label();
            pnlCardTodaySales = new Panel();
            lblTodaySalesTitle = new Label();
            lblTodaySalesValue = new Label();
            pnlCardTodayRevenue = new Panel();
            lblTodayRevenueTitle = new Label();
            lblTodayRevenueValue = new Label();
            pnlCardTotalRevenue = new Panel();
            lblTotalRevenueTitle = new Label();
            lblTotalRevenueValue = new Label();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            btnSignOut = new Button();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).BeginInit();
            flpCards.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
 
            pnlSidebar.BackColor = Color.Gray;
            pnlSidebar.Controls.Add(btnSales);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnInventory);
            pnlSidebar.Controls.Add(btnSizesColors);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(178, 720);
            pnlSidebar.TabIndex = 1;

            StyleSidebarButton(btnDashboard, "btnDashboard", "Dashboard", 195, 45);
            btnDashboard.Click += btnDashboard_Click;

            StyleSidebarButton(btnProducts, "btnProducts", "Products", 260, 45);
            btnProducts.Click += btnProducts_Click;

            StyleSidebarButton(btnSizesColors, "btnSizesColors", "Management Sizes _Colors", 325, 45);
            btnSizesColors.Click += btnSizesColors_Click;

            StyleSidebarButton(btnInventory, "btnInventory", "Inventory", 404, 45);
            btnInventory.Click += btnInventory_Click;

            StyleSidebarButton(btnReports, "btnReports", "Management Reports", 475, 45);
            btnReports.Click += btnReports_Click;
          
            StyleSidebarButton(btnSales, "btnSales", "Management Sales", 545, 45);
            btnSales.Click += btnSales_Click;
          
            pnlMain.BackColor = Color.FromArgb(240, 240, 240);
            pnlMain.Controls.Add(dgvLowStock);
            pnlMain.Controls.Add(lblLowStock);
            pnlMain.Controls.Add(dgvRecentSales);
            pnlMain.Controls.Add(lblRecentSales);
            pnlMain.Controls.Add(flpCards);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Name = "pnlMain";
            pnlMain.TabIndex = 0;

            pnlHeader.BackColor = Color.Gray;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(btnSignOut);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1102, 100);
            pnlHeader.TabIndex = 0;
 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 30F, FontStyle.Bold);
            lblWelcome.Location = new Point(8, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = "Welcome to Clothing Management System";

            btnSignOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignOut.BackColor = Color.White;
            btnSignOut.Cursor = Cursors.Hand;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSignOut.Location = new Point(960, 20);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(140, 50);
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;

            flpCards.BackColor = Color.FromArgb(240, 240, 240);
            flpCards.Controls.Add(pnlCardProducts);
            flpCards.Controls.Add(pnlCardVariants);
            flpCards.Controls.Add(pnlCardUnits);
            flpCards.Controls.Add(pnlCardLowStock);
            flpCards.Controls.Add(pnlCardTodaySales);
            flpCards.Controls.Add(pnlCardTodayRevenue);
            flpCards.Controls.Add(pnlCardTotalRevenue);
            flpCards.Dock = DockStyle.Top;
            flpCards.Name = "flpCards";
            flpCards.Size = new Size(1102, 176);
            flpCards.TabIndex = 1;

            StyleCard(pnlCardProducts, lblProductsTitle, lblProductsValue,
                "pnlCardProducts", "lblProductsTitle", "lblProductsValue", "Products", Color.FromArgb(128, 64, 0));
            StyleCard(pnlCardVariants, lblVariantsTitle, lblVariantsValue,
                "pnlCardVariants", "lblVariantsTitle", "lblVariantsValue", "Size / color variants", Color.ForestGreen);
            StyleCard(pnlCardUnits, lblUnitsTitle, lblUnitsValue,
                "pnlCardUnits", "lblUnitsTitle", "lblUnitsValue", "Units in stock", Color.FromArgb(192, 0, 0));
            StyleCard(pnlCardLowStock, lblLowStockItemsTitle, lblLowStockItemsValue,
                "pnlCardLowStock", "lblLowStockItemsTitle", "lblLowStockItemsValue", "Low stock items", Color.Teal);
            StyleCard(pnlCardTodaySales, lblTodaySalesTitle, lblTodaySalesValue,
                "pnlCardTodaySales", "lblTodaySalesTitle", "lblTodaySalesValue", "Today's sales", Color.CornflowerBlue);
            StyleCard(pnlCardTodayRevenue, lblTodayRevenueTitle, lblTodayRevenueValue,
                "pnlCardTodayRevenue", "lblTodayRevenueTitle", "lblTodayRevenueValue", "Today's revenue", Color.Olive);
            StyleCard(pnlCardTotalRevenue, lblTotalRevenueTitle, lblTotalRevenueValue,
                "pnlCardTotalRevenue", "lblTotalRevenueTitle", "lblTotalRevenueValue", "Total revenue", Color.FromArgb(192, 0, 192));
 
            StyleSectionLabel(lblRecentSales, "lblRecentSales", "Recent Sales");

            StyleGrid(dgvRecentSales, "dgvRecentSales");
            dgvRecentSales.Columns.AddRange(new DataGridViewColumn[] { colRsId, colRsDate, colRsCashier, colRsDiscount, colRsTotal });
            dgvRecentSales.Dock = DockStyle.Top;
            dgvRecentSales.Size = new Size(1102, 215);

            colRsId.HeaderText = "ID";
            colRsId.Name = "colRsId";
            colRsDate.HeaderText = "DATE";
            colRsDate.Name = "colRsDate";
            colRsCashier.HeaderText = "cashier";
            colRsCashier.Name = "colRsCashier";
            colRsDiscount.HeaderText = "Discount";
            colRsDiscount.Name = "colRsDiscount";
            colRsTotal.HeaderText = "Total";
            colRsTotal.Name = "colRsTotal";

            StyleSectionLabel(lblLowStock, "lblLowStock", "Low Stock alerts");

            StyleGrid(dgvLowStock, "dgvLowStock");
            dgvLowStock.Columns.AddRange(new DataGridViewColumn[] { colLsProduct, colLsSize, colLsColor, colLsQuantity, colLsReorderLevel });
            dgvLowStock.Dock = DockStyle.Fill;

            colLsProduct.HeaderText = "Product";
            colLsProduct.Name = "colLsProduct";
            colLsSize.HeaderText = "Size";
            colLsSize.Name = "colLsSize";
            colLsColor.HeaderText = "Color";
            colLsColor.Name = "colLsColor";
            colLsQuantity.HeaderText = "Quantity";
            colLsQuantity.Name = "colLsQuantity";
            colLsReorderLevel.HeaderText = "ReorderLevel";
            colLsReorderLevel.Name = "colLsReorderLevel";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1100, 650);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clothing Management System - Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).EndInit();
            flpCards.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

 
        private void StyleSidebarButton(Button b, string name, string text, int top, int height)
        {
            b.BackColor = Color.White;
            b.Cursor = Cursors.Hand;
            b.FlatAppearance.BorderColor = Color.Silver;
            b.FlatStyle = FlatStyle.Flat;
            b.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            b.Location = new Point(10, top);
            b.Name = name;
            b.Size = new Size(160, height);
            b.Text = text;
            b.UseVisualStyleBackColor = false;
        }

        private void StyleCard(Panel card, Label title, Label value,
            string cardName, string titleName, string valueName, string titleText, Color color)
        {
            card.BackColor = color;
            card.Controls.Add(value);
            card.Controls.Add(title);
            card.Name = cardName;
            card.Size = new Size(210, 78);
     
            title.AutoSize = true;
            title.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            title.Location = new Point(4, 3);
            title.Name = titleName;
            title.Text = titleText;
         
            value.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            value.Location = new Point(4, 28);
            value.Name = valueName;
            value.Size = new Size(200, 44);
        }

        private void StyleSectionLabel(Label l, string name, string text)
        {
            l.BackColor = Color.FromArgb(240, 240, 240);
            l.Dock = DockStyle.Top;
            l.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            l.Name = name;
            l.Padding = new Padding(6, 0, 0, 0);
            l.Size = new Size(1102, 26);
            l.Text = text;
            l.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void StyleGrid(DataGridView g, string name)
        {
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.BackgroundColor = Color.FromArgb(160, 160, 160);
            g.BorderStyle = BorderStyle.None;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            g.Name = name;
            g.ReadOnly = true;
            g.RowHeadersVisible = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnDashboard;
        private Button btnProducts;
        private Button btnSizesColors;
        private Button btnInventory;
        private Button btnReports;
        private Button btnSales;
        private Panel pnlMain;
        private Panel pnlHeader;
        private Label lblWelcome;
        private Button btnSignOut;
        private FlowLayoutPanel flpCards;
        private Panel pnlCardProducts;
        private Label lblProductsTitle;
        private Label lblProductsValue;
        private Panel pnlCardVariants;
        private Label lblVariantsTitle;
        private Label lblVariantsValue;
        private Panel pnlCardUnits;
        private Label lblUnitsTitle;
        private Label lblUnitsValue;
        private Panel pnlCardLowStock;
        private Label lblLowStockItemsTitle;
        private Label lblLowStockItemsValue;
        private Panel pnlCardTodaySales;
        private Label lblTodaySalesTitle;
        private Label lblTodaySalesValue;
        private Panel pnlCardTodayRevenue;
        private Label lblTodayRevenueTitle;
        private Label lblTodayRevenueValue;
        private Panel pnlCardTotalRevenue;
        private Label lblTotalRevenueTitle;
        private Label lblTotalRevenueValue;
        private Label lblRecentSales;
        private DataGridView dgvRecentSales;
        private DataGridViewTextBoxColumn colRsId;
        private DataGridViewTextBoxColumn colRsDate;
        private DataGridViewTextBoxColumn colRsCashier;
        private DataGridViewTextBoxColumn colRsDiscount;
        private DataGridViewTextBoxColumn colRsTotal;
        private Label lblLowStock;
        private DataGridView dgvLowStock;
        private DataGridViewTextBoxColumn colLsProduct;
        private DataGridViewTextBoxColumn colLsSize;
        private DataGridViewTextBoxColumn colLsColor;
        private DataGridViewTextBoxColumn colLsQuantity;
        private DataGridViewTextBoxColumn colLsReorderLevel;
    }
}
