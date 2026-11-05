namespace clothingstore
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            ManagementSales6 = new Button();
            ManagementReports5 = new Button();
            Inventory4 = new Button();
            ManagementSizesColors3 = new Button();
            Products2 = new Button();
            Dashboard1 = new Button();
            panel2 = new Panel();
            SignOut7 = new Button();
            labelwelcometoclothing1 = new Label();
            imageList1 = new ImageList(components);
            LowStockalert1 = new DataGridView();
            colProduct = new DataGridViewTextBoxColumn();
            colSize = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colReorderLevel = new DataGridViewTextBoxColumn();
            recentsales2 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colCashier = new DataGridViewTextBoxColumn();
            colDiscount = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            labelrecentsales2 = new Label();
            lablowstockalerts3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            productsPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            label6 = new Label();
            sizecolorpanel3 = new Panel();
            label5 = new Label();
            unitsinstockpanel4 = new Panel();
            label9 = new Label();
            lowstockitemspanel5 = new Panel();
            label10 = new Label();
            todayssalespanel6 = new Panel();
            label11 = new Label();
            todaysrevenuepanel7 = new Panel();
            label7 = new Label();
            totalrevenuepanel8 = new Panel();
            label12 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LowStockalert1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recentsales2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            productsPanel2.SuspendLayout();
            sizecolorpanel3.SuspendLayout();
            unitsinstockpanel4.SuspendLayout();
            lowstockitemspanel5.SuspendLayout();
            todayssalespanel6.SuspendLayout();
            todaysrevenuepanel7.SuspendLayout();
            totalrevenuepanel8.SuspendLayout();
            SuspendLayout();
           
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(ManagementSales6);
            panel1.Controls.Add(ManagementReports5);
            panel1.Controls.Add(Inventory4);
            panel1.Controls.Add(ManagementSizesColors3);
            panel1.Controls.Add(Products2);
            panel1.Controls.Add(Dashboard1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 700);
            panel1.TabIndex = 0;
     
            ManagementSales6.FlatStyle = FlatStyle.System;
            ManagementSales6.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagementSales6.Location = new Point(12, 543);
            ManagementSales6.Name = "ManagementSales6";
            ManagementSales6.Size = new Size(161, 50);
            ManagementSales6.TabIndex = 5;
            ManagementSales6.Text = "Management Sales";
            ManagementSales6.UseVisualStyleBackColor = true;
      
            ManagementReports5.FlatStyle = FlatStyle.System;
            ManagementReports5.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagementReports5.Location = new Point(12, 475);
            ManagementReports5.Name = "ManagementReports5";
            ManagementReports5.Size = new Size(161, 46);
            ManagementReports5.TabIndex = 4;
            ManagementReports5.Text = "Management Reports";
            ManagementReports5.UseVisualStyleBackColor = true;
    
            Inventory4.FlatStyle = FlatStyle.System;
            Inventory4.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inventory4.Location = new Point(12, 404);
            Inventory4.Name = "Inventory4";
            Inventory4.Size = new Size(161, 43);
            Inventory4.TabIndex = 3;
            Inventory4.Text = "Inventory";
            Inventory4.UseVisualStyleBackColor = true;

            ManagementSizesColors3.FlatStyle = FlatStyle.System;
            ManagementSizesColors3.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagementSizesColors3.Location = new Point(12, 326);
            ManagementSizesColors3.Name = "ManagementSizesColors3";
            ManagementSizesColors3.Size = new Size(161, 46);
            ManagementSizesColors3.TabIndex = 2;
            ManagementSizesColors3.Text = "Management Sizes & Colors";
            ManagementSizesColors3.UseVisualStyleBackColor = true;
  
            Products2.BackColor = Color.FromArgb(255, 255, 192);
            Products2.FlatStyle = FlatStyle.System;
            Products2.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Products2.Location = new Point(12, 260);
            Products2.Name = "Products2";
            Products2.Size = new Size(161, 48);
            Products2.TabIndex = 1;
            Products2.Text = "Products";
            Products2.UseVisualStyleBackColor = false;

            Dashboard1.BackColor = Color.Silver;
            Dashboard1.FlatStyle = FlatStyle.System;
            Dashboard1.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard1.Location = new Point(12, 195);
            Dashboard1.Name = "Dashboard1";
            Dashboard1.Size = new Size(161, 43);
            Dashboard1.TabIndex = 0;
            Dashboard1.Text = "Dashboard";
            Dashboard1.UseVisualStyleBackColor = false;

            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(SignOut7);
            panel2.Controls.Add(labelwelcometoclothing1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(179, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1253, 100);
            panel2.TabIndex = 1;

            SignOut7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignOut7.Location = new Point(1082, 22);
            SignOut7.Name = "SignOut7";
            SignOut7.Size = new Size(142, 49);
            SignOut7.TabIndex = 1;
            SignOut7.Tag = "SignOut7_Click";
            SignOut7.Text = "Sign Out";
            SignOut7.UseVisualStyleBackColor = true;

            labelwelcometoclothing1.AutoSize = true;
            labelwelcometoclothing1.Font = new Font("Century Gothic", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelwelcometoclothing1.Location = new Point(0, 0);
            labelwelcometoclothing1.Name = "labelwelcometoclothing1";
            labelwelcometoclothing1.Size = new Size(918, 49);
            labelwelcometoclothing1.TabIndex = 0;
            labelwelcometoclothing1.Text = "Welcome to Clothing Management System";
 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;

            LowStockalert1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LowStockalert1.Columns.AddRange(new DataGridViewColumn[] { colProduct, colSize, colColor, colQuantity, colReorderLevel });
            LowStockalert1.Location = new Point(179, 512);
            LowStockalert1.Name = "LowStockalert1";
            LowStockalert1.RowHeadersWidth = 51;
            LowStockalert1.Size = new Size(1253, 188);
            LowStockalert1.TabIndex = 2;

            colProduct.HeaderText = "Product";
            colProduct.MinimumWidth = 6;
            colProduct.Name = "colProduct";
            colProduct.Width = 250;
 
            colSize.HeaderText = "Size";
            colSize.MinimumWidth = 6;
            colSize.Name = "colSize";
            colSize.Width = 250;
  
            colColor.HeaderText = "Color";
            colColor.MinimumWidth = 6;
            colColor.Name = "colColor";
            colColor.Width = 250;

            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 250;

            colReorderLevel.HeaderText = "ReorderLevel";
            colReorderLevel.MinimumWidth = 6;
            colReorderLevel.Name = "colReorderLevel";
            colReorderLevel.Width = 250;

            recentsales2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recentsales2.Columns.AddRange(new DataGridViewColumn[] { colID, colDate, colCashier, colDiscount, colTotal });
            recentsales2.Location = new Point(179, 299);
            recentsales2.Name = "recentsales2";
            recentsales2.RowHeadersWidth = 51;
            recentsales2.Size = new Size(1253, 188);
            recentsales2.TabIndex = 3;
    
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 200;
  
            colDate.HeaderText = "DATE";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.Width = 250;
   
            colCashier.HeaderText = "cashier";
            colCashier.MinimumWidth = 6;
            colCashier.Name = "colCashier";
            colCashier.Width = 250;
   
            colDiscount.HeaderText = "Discount";
            colDiscount.MinimumWidth = 6;
            colDiscount.Name = "colDiscount";
            colDiscount.Width = 250;
 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.Width = 250;

            labelrecentsales2.AutoSize = true;
            labelrecentsales2.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelrecentsales2.Location = new Point(185, 276);
            labelrecentsales2.Name = "labelrecentsales2";
            labelrecentsales2.Size = new Size(89, 16);
            labelrecentsales2.TabIndex = 4;
            labelrecentsales2.Text = "Recent Sales";
  
            lablowstockalerts3.AutoSize = true;
            lablowstockalerts3.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablowstockalerts3.Location = new Point(185, 490);
            lablowstockalerts3.Name = "lablowstockalerts3";
            lablowstockalerts3.Size = new Size(110, 16);
            lablowstockalerts3.TabIndex = 5;
            lablowstockalerts3.Text = "Low Stock alerts";

            flowLayoutPanel1.Controls.Add(productsPanel2);
            flowLayoutPanel1.Controls.Add(sizecolorpanel3);
            flowLayoutPanel1.Controls.Add(unitsinstockpanel4);
            flowLayoutPanel1.Controls.Add(lowstockitemspanel5);
            flowLayoutPanel1.Controls.Add(todayssalespanel6);
            flowLayoutPanel1.Controls.Add(todaysrevenuepanel7);
            flowLayoutPanel1.Controls.Add(totalrevenuepanel8);
            flowLayoutPanel1.Location = new Point(179, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1253, 173);
            flowLayoutPanel1.TabIndex = 6;
  
            productsPanel2.BackColor = Color.FromArgb(128, 64, 0);
            productsPanel2.Controls.Add(label4);
            productsPanel2.Controls.Add(label6);
            productsPanel2.Location = new Point(3, 3);
            productsPanel2.Name = "productsPanel2";
            productsPanel2.Size = new Size(210, 77);
            productsPanel2.TabIndex = 0;
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 0;
          
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 1;
            label6.Text = "Products";
   
            sizecolorpanel3.BackColor = Color.ForestGreen;
            sizecolorpanel3.Controls.Add(label5);
            sizecolorpanel3.Location = new Point(219, 3);
            sizecolorpanel3.Name = "sizecolorpanel3";
            sizecolorpanel3.Size = new Size(214, 77);
            sizecolorpanel3.TabIndex = 0;
      
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 1);
            label5.Name = "label5";
            label5.Size = new Size(135, 16);
            label5.TabIndex = 0;
            label5.Text = "Size / color variants";

            unitsinstockpanel4.BackColor = Color.FromArgb(192, 0, 0);
            unitsinstockpanel4.Controls.Add(label9);
            unitsinstockpanel4.Location = new Point(439, 3);
            unitsinstockpanel4.Name = "unitsinstockpanel4";
            unitsinstockpanel4.Size = new Size(214, 77);
            unitsinstockpanel4.TabIndex = 1;
   
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 16);
            label9.TabIndex = 0;
            label9.Text = "Units in stock";
    
            lowstockitemspanel5.BackColor = Color.Teal;
            lowstockitemspanel5.Controls.Add(label10);
            lowstockitemspanel5.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lowstockitemspanel5.Location = new Point(659, 3);
            lowstockitemspanel5.Name = "lowstockitemspanel5";
            lowstockitemspanel5.Size = new Size(214, 77);
            lowstockitemspanel5.TabIndex = 2;
      
            label10.AutoSize = true;
            label10.Location = new Point(3, 1);
            label10.Name = "label10";
            label10.Size = new Size(107, 16);
            label10.TabIndex = 0;
            label10.Text = "Low stock items";
  
            todayssalespanel6.BackColor = Color.CornflowerBlue;
            todayssalespanel6.Controls.Add(label11);
            todayssalespanel6.Location = new Point(879, 3);
            todayssalespanel6.Name = "todayssalespanel6";
            todayssalespanel6.Size = new Size(214, 77);
            todayssalespanel6.TabIndex = 3;
     
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(0, 1);
            label11.Name = "label11";
            label11.Size = new Size(93, 16);
            label11.TabIndex = 0;
            label11.Text = "Today's sales";
    
            todaysrevenuepanel7.BackColor = Color.Olive;
            todaysrevenuepanel7.Controls.Add(label7);
            todaysrevenuepanel7.Location = new Point(3, 86);
            todaysrevenuepanel7.Name = "todaysrevenuepanel7";
            todaysrevenuepanel7.Size = new Size(214, 77);
            todaysrevenuepanel7.TabIndex = 4;
     
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(112, 16);
            label7.TabIndex = 0;
            label7.Text = "Today's revenue";
   
            totalrevenuepanel8.BackColor = Color.FromArgb(192, 0, 192);
            totalrevenuepanel8.Controls.Add(label12);
            totalrevenuepanel8.Controls.Add(label8);
            totalrevenuepanel8.Location = new Point(223, 86);
            totalrevenuepanel8.Name = "totalrevenuepanel8";
            totalrevenuepanel8.Size = new Size(214, 77);
            totalrevenuepanel8.TabIndex = 5;
     
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(3, 9);
            label12.Name = "label12";
            label12.Size = new Size(94, 16);
            label12.TabIndex = 1;
            label12.Text = "Total revenue";
     
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(62, 47);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 0;
  
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 700);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lablowstockalerts3);
            Controls.Add(labelrecentsales2);
            Controls.Add(recentsales2);
            Controls.Add(LowStockalert1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LowStockalert1).EndInit();
            ((System.ComponentModel.ISupportInitialize)recentsales2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            productsPanel2.ResumeLayout(false);
            productsPanel2.PerformLayout();
            sizecolorpanel3.ResumeLayout(false);
            sizecolorpanel3.PerformLayout();
            unitsinstockpanel4.ResumeLayout(false);
            unitsinstockpanel4.PerformLayout();
            lowstockitemspanel5.ResumeLayout(false);
            lowstockitemspanel5.PerformLayout();
            todayssalespanel6.ResumeLayout(false);
            todayssalespanel6.PerformLayout();
            todaysrevenuepanel7.ResumeLayout(false);
            todaysrevenuepanel7.PerformLayout();
            totalrevenuepanel8.ResumeLayout(false);
            totalrevenuepanel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ManagementSales6;
        private Button ManagementReports5;
        private Button Inventory4;
        private Button ManagementSizesColors3;
        private Button Products2;
        private Button Dashboard1;
        private ImageList imageList1;
        private Label labelwelcometoclothing1;
        private Button SignOut7;
        private DataGridView LowStockalert1;
        private DataGridView recentsales2;
        private Label labelrecentsales2;
        private Label lablowstockalerts3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel productsPanel2;
        private Panel sizecolorpanel3;
        private Panel unitsinstockpanel4;
        private Panel lowstockitemspanel5;
        private Panel todayssalespanel6;
        private Panel todaysrevenuepanel7;
        private Panel totalrevenuepanel8;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colCashier;
        private DataGridViewTextBoxColumn colDiscount;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colSize;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colReorderLevel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}