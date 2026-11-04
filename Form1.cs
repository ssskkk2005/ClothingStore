using System;
using System.Data;
using System.Windows.Forms;


namespace clothes_2
{
    public partial class Form1 : Form
    {
        DataTable products = new DataTable();
        int selectedId = 0;

        public Form1()
        {
            InitializeComponent();

            // Connect events
            this.Load += Form1_Load;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvProducts.CellClick += dgvProducts_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create data columns (not DataGridView columns)
            products.Columns.Add("Id", typeof(int));
            products.Columns.Add("Name", typeof(string));
            products.Columns.Add("Category", typeof(string));
            products.Columns.Add("Size", typeof(string));
            products.Columns.Add("Color", typeof(string));
            products.Columns.Add("Price", typeof(decimal));
            products.Columns.Add("Quantity", typeof(int));

            // Default products
            products.Rows.Add(1, "T-Shirt", "Tops", "M", "Black", 250, 20);
            products.Rows.Add(2, "Jeans", "Bottoms", "L", "Blue", 600, 12);
            products.Rows.Add(3, "Hoodie", "Tops", "XL", "Red", 750, 3);
            products.Rows.Add(4, "Dress", "Dresses", "S", "White", 900, 8);
            products.Rows.Add(5, "Jacket", "Tops", "L", "Black", 1200, 5);
            products.Rows.Add(6, "Skirt", "Bottoms", "M", "White", 450, 15);
            products.Rows.Add(7, "Shirt", "Tops", "S", "Blue", 350, 10);
            products.Rows.Add(8, "Sweater", "Tops", "XL", "Red", 800, 6);

            // Use existing Designer columns
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = products;

            // ComboBox items
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[]
            {
                "Tops", "Bottoms", "Dresses"
            });

            cmbSize.Items.Clear();
            cmbSize.Items.AddRange(new string[]
            {
                "S", "M", "L", "XL"
            });

            cmbColor.Items.Clear();
            cmbColor.Items.AddRange(new string[]
            {
                "Black", "Blue", "Red", "White"
            });

            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
        }

        // Add Product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" ||
                cmbCategory.Text == "" ||
                cmbSize.Text == "" ||
                cmbColor.Text == "" ||
                txtPrice.Text.Trim() == "" ||
                txtQty.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            decimal price;
            int quantity;

            if (!decimal.TryParse(txtPrice.Text, out price) ||
                !int.TryParse(txtQty.Text, out quantity) ||
                price < 0 || quantity < 0)
            {
                MessageBox.Show("Enter valid price and quantity");
                return;
            }

            int newId = 1;

            foreach (DataRow row in products.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                if (id >= newId)
                    newId = id + 1;
            }

            products.Rows.Add(
                newId,
                txtName.Text.Trim(),
                cmbCategory.Text,
                cmbSize.Text,
                cmbColor.Text,
                price,
                quantity
            );

            MessageBox.Show("Product Added Successfully");
            ClearFields();
        }

        // Clear Fields
        private void ClearFields()
        {
            txtName.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;
            txtPrice.Clear();
            txtQty.Clear();

            selectedId = 0;
            dgvProducts.ClearSelection();
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Select Product
        private void dgvProducts_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            selectedId = Convert.ToInt32(row.Cells["Id"].Value);

            txtName.Text = row.Cells["Name"].Value.ToString();
            cmbCategory.Text = row.Cells["Category"].Value.ToString();
            cmbSize.Text = row.Cells["Size"].Value.ToString();
            cmbColor.Text = row.Cells["Color"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtQty.Text = row.Cells["Quantity"].Value.ToString();
        }

        // Update Product
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            decimal price;
            int quantity;

            if (txtName.Text.Trim() == "" ||
                cmbCategory.Text == "" ||
                cmbSize.Text == "" ||
                cmbColor.Text == "" ||
                !decimal.TryParse(txtPrice.Text, out price) ||
                !int.TryParse(txtQty.Text, out quantity) ||
                price < 0 || quantity < 0)
            {
                MessageBox.Show("Enter valid product information");
                return;
            }

            DataRow[] rows = products.Select("Id = " + selectedId);

            if (rows.Length > 0)
            {
                rows[0]["Name"] = txtName.Text.Trim();
                rows[0]["Category"] = cmbCategory.Text;
                rows[0]["Size"] = cmbSize.Text;
                rows[0]["Color"] = cmbColor.Text;
                rows[0]["Price"] = price;
                rows[0]["Quantity"] = quantity;
            }

            MessageBox.Show("Product Updated Successfully");
            ClearFields();
        }

        // Delete Product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            DataRow[] rows = products.Select("Id = " + selectedId);

            if (rows.Length > 0)
                rows[0].Delete();

            MessageBox.Show("Product Deleted Successfully");
            ClearFields();
        }

        // Search Product
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Replace("'", "''");

            products.DefaultView.RowFilter =
                "Name LIKE '%" + search + "%'";
        }

        // Old Designer events
        private void lblSize_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label4_Click_1(object sender, EventArgs e) { }
    }
}