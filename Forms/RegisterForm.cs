using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Google.Cloud.Firestore;
using Hospital1._0.Classes;
using System.Resources; // For ResourceManager
using System.Globalization; // For CultureInfo (if changing language at runtime)
using System.Threading; // For Thread (if changing language at runtime)

namespace Hospital1._0.Forms
{
    public partial class RegisterForm : XtraForm
    {
        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.Messages", typeof(Program).Assembly);
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
            var db = FirestoreHelper.Database;

            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show(resMan.GetString("UserExists"));
                return;
            }

            var data = GetWriteData();
            DocumentReference docRef = db.Collection("LoginData").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show(resMan.GetString("UserRegistered"));
        }

        private LoginData GetWriteData()
        {
            
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            return new LoginData()
            {
                Username = username,
                Password = password
            };
        }

        private bool CheckIfUserAlreadyExist()
        {
            string username = txtUsername.Text.Trim();
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("LoginData").Document(username);
            LoginData data = docRef.GetSnapshotAsync().Result.ConvertTo<LoginData>();

            if (data != null)
            {
                return true;
            }
            return false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
