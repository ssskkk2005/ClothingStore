namespace ClothingStore
{
    partial class SizesColorsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSizes = new GroupBox();
            lstSizes = new ListBox();
            txtSize = new TextBox();
            btnAddSize = new Button();
            btnDeleteSize = new Button();
            grpColors = new GroupBox();
            lstColors = new ListBox();
            txtColor = new TextBox();
            btnAddColor = new Button();
            btnDeleteColor = new Button();
            grpSizes.SuspendLayout();
            grpColors.SuspendLayout();
            SuspendLayout();
            // 
            // grpSizes
            // 
            grpSizes.Controls.Add(lstSizes);
            grpSizes.Controls.Add(txtSize);
            grpSizes.Controls.Add(btnAddSize);
            grpSizes.Controls.Add(btnDeleteSize);
            grpSizes.Location = new Point(10, 10);
            grpSizes.Name = "grpSizes";
            grpSizes.Size = new Size(320, 340);
            grpSizes.TabIndex = 0;
            grpSizes.TabStop = false;
            grpSizes.Text = "Sizes";
            // 
            // lstSizes
            // 
            lstSizes.FormattingEnabled = true;
            lstSizes.IntegralHeight = false;
            lstSizes.Location = new Point(10, 25);
            lstSizes.Name = "lstSizes";
            lstSizes.Size = new Size(300, 260);
            lstSizes.TabIndex = 0;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(10, 300);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(140, 27);
            txtSize.TabIndex = 1;
            // 
            // btnAddSize
            // 
            btnAddSize.Location = new Point(160, 298);
            btnAddSize.Name = "btnAddSize";
            btnAddSize.Size = new Size(70, 30);
            btnAddSize.TabIndex = 2;
            btnAddSize.Text = "Add";
            btnAddSize.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSize
            // 
            btnDeleteSize.Location = new Point(236, 298);
            btnDeleteSize.Name = "btnDeleteSize";
            btnDeleteSize.Size = new Size(70, 30);
            btnDeleteSize.TabIndex = 3;
            btnDeleteSize.Text = "Delete";
            btnDeleteSize.UseVisualStyleBackColor = true;
            // 
            // grpColors
            // 
            grpColors.Controls.Add(lstColors);
            grpColors.Controls.Add(txtColor);
            grpColors.Controls.Add(btnAddColor);
            grpColors.Controls.Add(btnDeleteColor);
            grpColors.Location = new Point(345, 10);
            grpColors.Name = "grpColors";
            grpColors.Size = new Size(320, 340);
            grpColors.TabIndex = 1;
            grpColors.TabStop = false;
            grpColors.Text = "Colors";
            // 
            // lstColors
            // 
            lstColors.FormattingEnabled = true;
            lstColors.IntegralHeight = false;
            lstColors.Location = new Point(10, 25);
            lstColors.Name = "lstColors";
            lstColors.Size = new Size(300, 260);
            lstColors.TabIndex = 0;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(10, 300);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(140, 27);
            txtColor.TabIndex = 1;
            // 
            // btnAddColor
            // 
            btnAddColor.Location = new Point(160, 298);
            btnAddColor.Name = "btnAddColor";
            btnAddColor.Size = new Size(70, 30);
            btnAddColor.TabIndex = 2;
            btnAddColor.Text = "Add";
            btnAddColor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteColor
            // 
            btnDeleteColor.Location = new Point(236, 298);
            btnDeleteColor.Name = "btnDeleteColor";
            btnDeleteColor.Size = new Size(70, 30);
            btnDeleteColor.TabIndex = 3;
            btnDeleteColor.Text = "Delete";
            btnDeleteColor.UseVisualStyleBackColor = true;
            // 
            // SizesColorsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpColors);
            Controls.Add(grpSizes);
            Name = "SizesColorsControl";
            Size = new Size(680, 360);
            grpSizes.ResumeLayout(false);
            grpSizes.PerformLayout();
            grpColors.ResumeLayout(false);
            grpColors.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSizes;
        private ListBox lstSizes;
        private TextBox txtSize;
        private Button btnAddSize;
        private Button btnDeleteSize;
        private GroupBox grpColors;
        private ListBox lstColors;
        private TextBox txtColor;
        private Button btnAddColor;
        private Button btnDeleteColor;
    }
}