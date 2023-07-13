namespace TestesWPF
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = buttonLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool usernameIsEmpty = txtUsername.Text.Length == 0 ? true : false;
            bool passwordIsEmpty = txtPassword.Text.Length == 0 ? true : false;

            if (!usernameIsEmpty && !passwordIsEmpty)
            {
                new FrmNotas().Show();
                this.Hide();
            }
            else if (usernameIsEmpty && passwordIsEmpty)
            {
                txtError.Text = "O Login e a Senha são obrigatórios.";
                txtError.Visible = true;

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            else if (usernameIsEmpty)
            {
                txtError.Text = "O Login é obrigatório.";
                txtError.Visible = true;

                txtPassword.Clear();
                txtUsername.Focus();
            }
            else
            {
                txtError.Text = "A Senha é obrigatória.";
                txtError.Visible = true;

                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

    }
}