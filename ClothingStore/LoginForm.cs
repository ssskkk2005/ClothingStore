namespace ClothingStore
{
    public partial class LoginForm : Form
    {
        public string LoggedUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = btnLogin;   // زرار Enter يعمل Login
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = DataStore.Authenticate(txtUser.Text.Trim(), txtPass.Text);
            if (user == null)
            {
                MessageBox.Show("Wrong username or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
                return;
            }
            LoggedUser = user.Username;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}