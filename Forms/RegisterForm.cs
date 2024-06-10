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

namespace Hospital1._0.Forms
{
    public partial class RegisterForm : XtraForm
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
            var db = FirestoreHelper.Database;
            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show("User already exists!");
                return;
            }
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("LoginData").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("User registered");
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
    }
}
