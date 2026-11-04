namespace ReportsDemo
{
    partial class ReportsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.colSaleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSalesBottom = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.panelSalesTop = new System.Windows.Forms.Panel();
            this.btnShowSales = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.gridStock = new System.Windows.Forms.DataGridView();
            this.colStockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStockTop = new System.Windows.Forms.Panel();
            this.btnShowStock = new System.Windows.Forms.Button();
            this.numThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.tabTop = new System.Windows.Forms.TabPage();
            this.gridTop = new System.Windows.Forms.DataGridView();
            this.colTopRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTopTop = new System.Windows.Forms.Panel();
            this.btnShowTop = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.panelSalesBottom.SuspendLayout();
            this.panelSalesTop.SuspendLayout();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            this.panelStockTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).BeginInit();
            this.tabTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).BeginInit();
            this.panelTopTop.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabSales);
            this.tabControl1.Controls.Add(this.tabStock);
            this.tabControl1.Controls.Add(this.tabTop);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 0;
            //
            // tabSales
            //
            this.tabSales.Controls.Add(this.gridSales);
            this.tabSales.Controls.Add(this.panelSalesBottom);
            this.tabSales.Controls.Add(this.panelSalesTop);
            this.tabSales.Location = new System.Drawing.Point(4, 24);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(776, 433);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales Report";
            this.tabSales.UseVisualStyleBackColor = true;
            //
            // gridSales
            //
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToDeleteRows = false;
            this.gridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSales.BackgroundColor = System.Drawing.Color.White;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleNo,
            this.colSaleDate,
            this.colSaleItems,
            this.colSaleTotal});
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.Location = new System.Drawing.Point(0, 45);
            this.gridSales.Name = "gridSales";
            this.gridSales.ReadOnly = true;
            this.gridSales.RowHeadersVisible = false;
            this.gridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSales.Size = new System.Drawing.Size(776, 348);
            this.gridSales.TabIndex = 2;
            //
            // colSaleNo
            //
            this.colSaleNo.HeaderText = "Sale #";
            this.colSaleNo.Name = "colSaleNo";
            this.colSaleNo.ReadOnly = true;
            //
            // colSaleDate
            //
            this.colSaleDate.HeaderText = "Date";
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.ReadOnly = true;
            //
            // colSaleItems
            //
            this.colSaleItems.HeaderText = "Items";
            this.colSaleItems.Name = "colSaleItems";
            this.colSaleItems.ReadOnly = true;
            //
            // colSaleTotal
            //
            this.colSaleTotal.HeaderText = "Total";
            this.colSaleTotal.Name = "colSaleTotal";
            this.colSaleTotal.ReadOnly = true;
            //
            // panelSalesBottom
            //
            this.panelSalesBottom.Controls.Add(this.lblTotal);
            this.panelSalesBottom.Controls.Add(this.lblCount);
            this.panelSalesBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSalesBottom.Location = new System.Drawing.Point(0, 393);
            this.panelSalesBottom.Name = "panelSalesBottom";
            this.panelSalesBottom.Size = new System.Drawing.Size(776, 40);
            this.panelSalesBottom.TabIndex = 1;
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(250, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 19);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total revenue: 0 EGP";
            //
            // lblCount
            //
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(12, 10);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(140, 19);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Number of sales: 0";
            //
            // panelSalesTop
            //
            this.panelSalesTop.Controls.Add(this.btnShowSales);
            this.panelSalesTop.Controls.Add(this.dtpTo);
            this.panelSalesTop.Controls.Add(this.lblTo);
            this.panelSalesTop.Controls.Add(this.dtpFrom);
            this.panelSalesTop.Controls.Add(this.lblFrom);
            this.panelSalesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalesTop.Location = new System.Drawing.Point(0, 0);
            this.panelSalesTop.Name = "panelSalesTop";
            this.panelSalesTop.Size = new System.Drawing.Size(776, 45);
            this.panelSalesTop.TabIndex = 0;
            //
            // btnShowSales
            //
            this.btnShowSales.Location = new System.Drawing.Point(400, 9);
            this.btnShowSales.Name = "btnShowSales";
            this.btnShowSales.Size = new System.Drawing.Size(85, 27);
            this.btnShowSales.TabIndex = 4;
            this.btnShowSales.Text = "Show";
            this.btnShowSales.UseVisualStyleBackColor = true;
            this.btnShowSales.Click += new System.EventHandler(this.btnShowSales_Click);
            //
            // dtpTo
            //
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(270, 11);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 23);
            this.dtpTo.TabIndex = 3;
            //
            // lblTo
            //
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(240, 15);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 15);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            //
            // dtpFrom
            //
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(70, 11);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 23);
            this.dtpFrom.TabIndex = 1;
            //
            // lblFrom
            //
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            //
            // tabStock
            //
            this.tabStock.Controls.Add(this.gridStock);
            this.tabStock.Controls.Add(this.panelStockTop);
            this.tabStock.Location = new System.Drawing.Point(4, 24);
            this.tabStock.Name = "tabStock";
            this.tabStock.Size = new System.Drawing.Size(776, 433);
            this.tabStock.TabIndex = 1;
            this.tabStock.Text = "Low Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            //
            // gridStock
            //
            this.gridStock.AllowUserToAddRows = false;
            this.gridStock.AllowUserToDeleteRows = false;
            this.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStock.BackgroundColor = System.Drawing.Color.White;
            this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockProduct,
            this.colStockSize,
            this.colStockColor,
            this.colStockQty});
            this.gridStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStock.Location = new System.Drawing.Point(0, 45);
            this.gridStock.Name = "gridStock";
            this.gridStock.ReadOnly = true;
            this.gridStock.RowHeadersVisible = false;
            this.gridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStock.Size = new System.Drawing.Size(776, 388);
            this.gridStock.TabIndex = 1;
            //
            // colStockProduct
            //
            this.colStockProduct.HeaderText = "Product";
            this.colStockProduct.Name = "colStockProduct";
            this.colStockProduct.ReadOnly = true;
            //
            // colStockSize
            //
            this.colStockSize.HeaderText = "Size";
            this.colStockSize.Name = "colStockSize";
            this.colStockSize.ReadOnly = true;
            //
            // colStockColor
            //
            this.colStockColor.HeaderText = "Color";
            this.colStockColor.Name = "colStockColor";
            this.colStockColor.ReadOnly = true;
            //
            // colStockQty
            //
            this.colStockQty.HeaderText = "Quantity Left";
            this.colStockQty.Name = "colStockQty";
            this.colStockQty.ReadOnly = true;
            //
            // panelStockTop
            //
            this.panelStockTop.Controls.Add(this.btnShowStock);
            this.panelStockTop.Controls.Add(this.numThreshold);
            this.panelStockTop.Controls.Add(this.lblThreshold);
            this.panelStockTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStockTop.Location = new System.Drawing.Point(0, 0);
            this.panelStockTop.Name = "panelStockTop";
            this.panelStockTop.Size = new System.Drawing.Size(776, 45);
            this.panelStockTop.TabIndex = 0;
            //
            // btnShowStock
            //
            this.btnShowStock.Location = new System.Drawing.Point(300, 9);
            this.btnShowStock.Name = "btnShowStock";
            this.btnShowStock.Size = new System.Drawing.Size(85, 27);
            this.btnShowStock.TabIndex = 2;
            this.btnShowStock.Text = "Show";
            this.btnShowStock.UseVisualStyleBackColor = true;
            this.btnShowStock.Click += new System.EventHandler(this.btnShowStock_Click);
            //
            // numThreshold
            //
            this.numThreshold.Location = new System.Drawing.Point(230, 11);
            this.numThreshold.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numThreshold.Name = "numThreshold";
            this.numThreshold.Size = new System.Drawing.Size(60, 23);
            this.numThreshold.TabIndex = 1;
            this.numThreshold.Value = new decimal(new int[] { 5, 0, 0, 0 });
            //
            // lblThreshold
            //
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(12, 15);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(210, 15);
            this.lblThreshold.TabIndex = 0;
            this.lblThreshold.Text = "Show products with quantity below:";
            //
            // tabTop
            //
            this.tabTop.Controls.Add(this.gridTop);
            this.tabTop.Controls.Add(this.panelTopTop);
            this.tabTop.Location = new System.Drawing.Point(4, 24);
            this.tabTop.Name = "tabTop";
            this.tabTop.Size = new System.Drawing.Size(776, 433);
            this.tabTop.TabIndex = 2;
            this.tabTop.Text = "Top Selling";
            this.tabTop.UseVisualStyleBackColor = true;
            //
            // gridTop
            //
            this.gridTop.AllowUserToAddRows = false;
            this.gridTop.AllowUserToDeleteRows = false;
            this.gridTop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTop.BackgroundColor = System.Drawing.Color.White;
            this.gridTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTopRank,
            this.colTopProduct,
            this.colTopUnits,
            this.colTopRevenue});
            this.gridTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTop.Location = new System.Drawing.Point(0, 45);
            this.gridTop.Name = "gridTop";
            this.gridTop.ReadOnly = true;
            this.gridTop.RowHeadersVisible = false;
            this.gridTop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTop.Size = new System.Drawing.Size(776, 388);
            this.gridTop.TabIndex = 1;
            //
            // colTopRank
            //
            this.colTopRank.HeaderText = "Rank";
            this.colTopRank.Name = "colTopRank";
            this.colTopRank.ReadOnly = true;
            //
            // colTopProduct
            //
            this.colTopProduct.HeaderText = "Product";
            this.colTopProduct.Name = "colTopProduct";
            this.colTopProduct.ReadOnly = true;
            //
            // colTopUnits
            //
            this.colTopUnits.HeaderText = "Units Sold";
            this.colTopUnits.Name = "colTopUnits";
            this.colTopUnits.ReadOnly = true;
            //
            // colTopRevenue
            //
            this.colTopRevenue.HeaderText = "Revenue";
            this.colTopRevenue.Name = "colTopRevenue";
            this.colTopRevenue.ReadOnly = true;
            //
            // panelTopTop
            //
            this.panelTopTop.Controls.Add(this.btnShowTop);
            this.panelTopTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTop.Location = new System.Drawing.Point(0, 0);
            this.panelTopTop.Name = "panelTopTop";
            this.panelTopTop.Size = new System.Drawing.Size(776, 45);
            this.panelTopTop.TabIndex = 0;
            //
            // btnShowTop
            //
            this.btnShowTop.Location = new System.Drawing.Point(12, 9);
            this.btnShowTop.Name = "btnShowTop";
            this.btnShowTop.Size = new System.Drawing.Size(85, 27);
            this.btnShowTop.TabIndex = 0;
            this.btnShowTop.Text = "Show";
            this.btnShowTop.UseVisualStyleBackColor = true;
            this.btnShowTop.Click += new System.EventHandler(this.btnShowTop_Click);
            //
            // ReportsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.tabControl1.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.panelSalesBottom.ResumeLayout(false);
            this.panelSalesBottom.PerformLayout();
            this.panelSalesTop.ResumeLayout(false);
            this.panelSalesTop.PerformLayout();
            this.tabStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            this.panelStockTop.ResumeLayout(false);
            this.panelStockTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreshold)).EndInit();
            this.tabTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).EndInit();
            this.panelTopTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.DataGridView gridSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTotal;
        private System.Windows.Forms.Panel panelSalesBottom;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panelSalesTop;
        private System.Windows.Forms.Button btnShowSales;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.DataGridView gridStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockQty;
        private System.Windows.Forms.Panel panelStockTop;
        private System.Windows.Forms.Button btnShowStock;
        private System.Windows.Forms.NumericUpDown numThreshold;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TabPage tabTop;
        private System.Windows.Forms.DataGridView gridTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopRevenue;
        private System.Windows.Forms.Panel panelTopTop;
        private System.Windows.Forms.Button btnShowTop;
    }
}
