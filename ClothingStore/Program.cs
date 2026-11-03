namespace ClothingStore
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DataStore.Load();

            using var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                var host = new Form
                {
                    Text = "Sizes & Colors",
                    ClientSize = new Size(680, 360),
                    StartPosition = FormStartPosition.CenterScreen
                };
                host.Controls.Add(new SizesColorsControl { Dock = DockStyle.Fill });
                Application.Run(host);
            }
        }
    }
}