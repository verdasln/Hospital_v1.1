// Hospital1._0.Forms/AddPatientForm.cs
using System;
using System.Resources; // For ResourceManager
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Google.Cloud.Firestore; // Ensure this is present
using Hospital1._0.Classes;

namespace Hospital1._0.Forms
{
    public partial class AddPatientForm : XtraForm
    {

        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.MessagesStrings", typeof(Program).Assembly);
        public AddPatientForm()
        {
            InitializeComponent();
        }

        // Function to calculate Age automatically.
        private void dtDob_EditValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtDob.DateTime;
            int age = DateTime.Now.Year - selectedDate.Year;

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
                // 1. Get the next available Patient ID atomically
                int newPatientId = await PatientIdGenerator.GetNextPatientId();

                var patientData = GetWriteData();
                patientData.PatientId = newPatientId;

                var db = FirestoreHelper.Database;
                DocumentReference docRef = db.Collection("Patients").Document(patientData.PatientId.ToString());
                await docRef.SetAsync(patientData);

                MessageBox.Show(resMan.GetString("PatientSaved") + $"{newPatientId}",
                                 resMan.GetString("SaveSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (ArgumentException aex) // Catch validation errors specifically
            {
                // Localized validation error
                MessageBox.Show(aex.Message, resMan.GetString("ValidationError"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ioex) // Catch counter generation errors
            {
                // Localized ID generation error
                MessageBox.Show(ioex.Message, resMan.GetString("IDGenerationError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Localized unexpected error
                MessageBox.Show($"{resMan.GetString("unexpectedError")} {ex.Message}", resMan.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PatientData GetWriteData()
        {
            #region Validation checks for other fields
            if (string.IsNullOrEmpty(txtName.Text))
            {
                throw new ArgumentException(resMan.GetString("NameRequired"));
            }

            if (dtDob.DateTime == DateTime.MinValue || dtDob.DateTime > DateTime.Now)
            {
                throw new ArgumentException(resMan.GetString("InvalidDate"));
            }

            if (string.IsNullOrEmpty(txtAge.Text) || !int.TryParse(txtAge.Text, out int patientAge) || patientAge < 0)
            {
                throw new ArgumentException(resMan.GetString("InvalidAge"));
            }

            if (string.IsNullOrEmpty(cmbBloodGroup.Text))
            {
                throw new ArgumentException(resMan.GetString("MissingBlood"));
            }

            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                throw new ArgumentException(resMan.GetString("MissingNumber"));
            }

            if (string.IsNullOrEmpty(cmbGender.Text))
            {
                throw new ArgumentException(resMan.GetString("MissingGender"));
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                throw new ArgumentException(resMan.GetString("MissingAddress"));
            }
            #endregion

            return new PatientData()
            {
                // PatientId is now assigned by the calling btnSave_Click method after generation.
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
            txtName.Text = string.Empty;
            dtDob.DateTime = DateTime.Now;
            txtAge.Text = string.Empty;
            cmbBloodGroup.SelectedIndex = -1;
            txtContactNumber.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            txtAddress.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}