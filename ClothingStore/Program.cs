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
                MessageBox.Show("Welcome, " + login.LoggedUser);
            }
        }
    }
}