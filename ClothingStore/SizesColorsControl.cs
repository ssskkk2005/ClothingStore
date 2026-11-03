namespace ClothingStore
{
    public partial class SizesColorsControl : UserControl
    {
        public SizesColorsControl()
        {
            InitializeComponent();

            btnAddSize.Click += (s, e) => AddTo(DataStore.Data.Sizes, txtSize);
            btnAddColor.Click += (s, e) => AddTo(DataStore.Data.Colors, txtColor);
            btnDeleteSize.Click += (s, e) => DeleteSize();
            btnDeleteColor.Click += (s, e) => DeleteColor();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode) RefreshLists();
        }

        void RefreshLists()
        {
            lstSizes.DataSource = null;
            lstSizes.DataSource = DataStore.Data.Sizes.ToList();
            lstColors.DataSource = null;
            lstColors.DataSource = DataStore.Data.Colors.ToList();
        }

        void AddTo(List<string> list, TextBox box)
        {
            var name = box.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Enter a name first.");
                return;
            }
            if (list.Any(x => x.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"'{name}' already exists.");
                return;
            }
            list.Add(name);
            DataStore.Save();
            box.Clear();
            RefreshLists();
        }

        void DeleteSize()
        {
            if (lstSizes.SelectedItem is not string item)
            {
                MessageBox.Show("Select a size first.");
                return;
            }
            if (DataStore.Data.Products.Any(p => p.Size == item))
            {
                MessageBox.Show($"Cannot delete '{item}' because some products use it.");
                return;
            }
            DataStore.Data.Sizes.Remove(item);
            DataStore.Save();
            RefreshLists();
        }

        void DeleteColor()
        {
            if (lstColors.SelectedItem is not string item)
            {
                MessageBox.Show("Select a color first.");
                return;
            }
            if (DataStore.Data.Products.Any(p => p.Color == item))
            {
                MessageBox.Show($"Cannot delete '{item}' because some products use it.");
                return;
            }
            DataStore.Data.Colors.Remove(item);
            DataStore.Save();
            RefreshLists();
        }
    }
}