using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Hospital1._0.Classes;
using Google.Cloud.Firestore;

namespace Hospital1._0.Forms
{
    public partial class AddPatientForm : XtraForm
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        // Function to calculate Age automatically.
        private void dtDob_EditValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtDob.DateTime;
            int age = DateTime.Now.Year - selectedDate.Year;

            // Check if the birthday has occurred this year
            if (DateTime.Now.DayOfYear < selectedDate.DayOfYear)
            {
                age--;
            }

            txtAge.Text = age.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var db = FirestoreHelper.Database;
                var patientData = GetWriteData();

                DocumentReference docRef = db.Collection("Patients").Document(patientData.PatientId.ToString());
                await docRef.SetAsync(patientData);

                MessageBox.Show("Patient information saved successfully.");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patient information: {ex.Message}");
            }
        }

        private PatientData GetWriteData()
        {
            // Open to view validation checks.
            #region Validation checks.
            // Validation checks
            if (string.IsNullOrEmpty(txtPatientId.Text) || !int.TryParse(txtPatientId.Text, out int patientId))
            {
                throw new ArgumentException("Invalid or missing Patient ID");
            }

            if (string.IsNullOrEmpty(txtName.Text))
            {
                throw new ArgumentException("Patient name is required");
            }

            if (dtDob.DateTime == DateTime.MinValue)
            {
                throw new ArgumentException("Date of birth is required");
            }

            if (string.IsNullOrEmpty(txtAge.Text) || !int.TryParse(txtAge.Text, out int patientAge))
            {
                throw new ArgumentException("Invalid or missing age");
            }

            if (string.IsNullOrEmpty(cmbBloodGroup.Text))
            {
                throw new ArgumentException("Blood group is required");
            }

            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                throw new ArgumentException("Contact number is required");
            }

            if (string.IsNullOrEmpty(cmbGender.Text))
            {
                throw new ArgumentException("Gender is required");
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                throw new ArgumentException("Address is required");
            }


            #endregion

            return new PatientData()
            {
                PatientId = patientId,
                PatientName = txtName.Text,
                PatientDateOfBirth = dtDob.DateTime.ToUniversalTime(),
                PatientAge = patientAge,
                PatientBloodGroup = cmbBloodGroup.Text,
                PatientContactNo = txtContactNumber.Text,
                PatientGender = cmbGender.Text,
                PatientAddress = txtAddress.Text
            };
        }

        private void ClearFields()
        {
            txtPatientId.Text = string.Empty;
            txtName.Text = string.Empty;
            dtDob.DateTime = DateTime.Now; // or any default value
            txtAge.Text = string.Empty;
            cmbBloodGroup.SelectedIndex = -1; // reset dropdown
            txtContactNumber.Text = string.Empty;
            cmbGender.SelectedIndex = -1; // reset dropdown
            txtAddress.Text = string.Empty;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
