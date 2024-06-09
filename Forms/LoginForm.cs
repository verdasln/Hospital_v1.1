using System;
using DevExpress.XtraEditors;

namespace Hospital1._0.Forms
{
    public partial class LoginForm : XtraForm
    {
       

        public LoginForm()
        {
            InitializeComponent();
            InitializePlaceholderText();
            Load += LoginForm_Load1;
        }

        private void LoginForm_Load1(object sender, EventArgs e)
        {
            
        }


        private void InitializePlaceholderText()
        {
            txtPassword.Properties.UseSystemPasswordChar = false;
            txtPassword.Text = "Password";
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            Close();
        }
    }
}
