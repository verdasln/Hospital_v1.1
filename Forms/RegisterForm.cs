using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital1._0.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void GetWriteData()
        {
            string username = 
        }
    }
}
