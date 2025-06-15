using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Hospital1._0.Classes;
using System.Resources;    // For ResourceManager
using System.Globalization; // For CultureInfo
using System.Threading;   // For Thread

namespace Hospital1._0.Forms
{
    public partial class LoginForm : XtraForm
    {
        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.MessagesStrings", typeof(Program).Assembly);

        public LoginForm()
        {
            // --- DEBUG STARTUP LANGUAGE ---
            MessageBox.Show($"[LoginForm Constructor] Initial Thread UICulture: {Thread.CurrentThread.CurrentUICulture.Name}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show($"[LoginForm Constructor] Saved Language Setting: '{Properties.Settings.Default.Language}'", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Set the initial culture based on a default or a saved preference
            string currentLanguageSetting = Properties.Settings.Default.Language;
            if (string.IsNullOrEmpty(currentLanguageSetting))
            {
                currentLanguageSetting = "en-US"; // Fallback to English if no setting found
                Properties.Settings.Default.Language = currentLanguageSetting; // Save this default
                Properties.Settings.Default.Save();
            }
            SetLanguage(currentLanguageSetting); // Set the culture for the thread before InitializeComponent

            InitializeComponent();
            InitializePlaceholderText();
            ApplyLocalizedTextToControls(); // Apply localized text to design-time controls

        }

        // Helper method to set the application's culture
        private void SetLanguage(string cultureName)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureName);
            Properties.Settings.Default.Language = cultureName; // Save language preference
            Properties.Settings.Default.Save();

            // --- DEBUG SetLanguage CALL ---
            MessageBox.Show($"[SetLanguage] Culture set to: {Thread.CurrentThread.CurrentUICulture.Name}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Apply localized text to controls that are designed in the form
        // and also for the toggle button's text
        private void ApplyLocalizedTextToControls()
        {
            // Localize form title
            this.Text = resMan.GetString("LoginTitle");

            // Localize the toggle button's text based on the *current* language.
            // It should display the text that indicates what it will SWITCH TO.
            if (Thread.CurrentThread.CurrentUICulture.Name == "en-US")
            {
                btnToggleLanguage.Text = resMan.GetString("ToggleToTurkish"); // If currently EN, button says "Türkçe"
            }
            else // If current UI culture is tr-TR or any other
            {
                btnToggleLanguage.Text = resMan.GetString("ToggleToEnglish"); // If currently TR, button says "English"
            }
            // You might also need to localize other labels/controls if not handled by Localizable = true
            // Example: lblUsername.Text = resMan.GetString("UsernameLabelText");
        }

        private void InitializePlaceholderText()
        {
            txtPassword.Properties.UseSystemPasswordChar = false;
            txtPassword.Text = resMan.GetString("PasswordPlaceholder");
            txtUsername.Properties.NullValuePrompt = resMan.GetString("UsernamePlaceholder");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("LoginData").Document(username);
            DocumentSnapshot snapshot = docRef.GetSnapshotAsync().GetAwaiter().GetResult();
            LoginData data = null;
            if (snapshot.Exists)
            {
                data = snapshot.ConvertTo<LoginData>();
            }

            if (data != null)
            {
                if (password == data.Password)
                {
                    this.Hide();
                    MainForm form = new MainForm();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resMan.GetString("IncorrectCredentials"));
                }
            }
            else
            {
                MessageBox.Show(resMan.GetString("InvalidEntry"));
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == resMan.GetString("PasswordPlaceholder"))
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
                txtPassword.Text = resMan.GetString("PasswordPlaceholder");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnToggleLanguage_Click(object sender, EventArgs e)
        {
            string currentCultureName = Thread.CurrentThread.CurrentUICulture.Name;
            string newCultureName;

            // --- DEBUG btnToggleLanguage_Click START ---
            MessageBox.Show($"[btnToggleLanguage_Click] Current UI Culture BEFORE change: {currentCultureName}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (currentCultureName == "en-US" || currentCultureName == "en") // Also check for neutral culture "en"
            {
                newCultureName = "tr-TR";
            }
            else // If current is tr-TR or any other (e.g., just "tr")
            {
                newCultureName = "en-US";
            }

            SetLanguage(newCultureName); // Set the new language and save preference

            // --- DEBUG btnToggleLanguage_Click AFTER SetLanguage ---
            MessageBox.Show($"[btnToggleLanguage_Click] New UI Culture AFTER change: {Thread.CurrentThread.CurrentUICulture.Name}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Recreate the login form to apply the new language to all controls
            // This is the simplest way to refresh all UI elements with the new culture.
            LoginForm newLoginForm = new LoginForm();
            this.Hide(); // Hide the current form
            newLoginForm.ShowDialog(); // Show the new, localized form
            this.Close(); // Close the old form (which is 'this')
        }

        // Ensure you only have one Load event handler, if any.
        // If LoginForm_Load1 was empty, it can be removed.
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // ApplyLocalizedTextToControls(); // This is already called in the constructor, so not strictly needed here unless you have late-loading elements
        }
    }
}