// Hospital1._0.Forms/AddPatientForm.cs
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Hospital1._0.Classes;
using Google.Cloud.Firestore; // Ensure this is present
using System.Resources; // For ResourceManager
using System.Globalization; // For CultureInfo (if changing language at runtime)
using System.Threading; // For Thread (if changing language at runtime)

namespace Hospital1._0.Forms
{
    public partial class AddPatientForm : XtraForm
    {

        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.Messages", typeof(Program).Assembly);
        public AddPatientForm()
        {
            InitializeComponent();
            // Optionally, if you have a label or read-only text box to display the generated ID,
            // you might initialize it here, e.g., lblPatientIdDisplay.Text = "Will be generated automatically";
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

                // 2. Prepare the PatientData object from form fields (excluding Patient ID input)
                var patientData = GetWriteData(); // This method now only collects non-ID fields
                patientData.PatientId = newPatientId; // Assign the newly generated ID

                // 3. Save the patient data to Firestore, using the generated ID as the document ID
                var db = FirestoreHelper.Database;
                // Important: Use the generated ID as the Document ID in the "Patients" collection
                DocumentReference docRef = db.Collection("Patients").Document(patientData.PatientId.ToString());
                await docRef.SetAsync(patientData); // SetAsync will create or overwrite

                MessageBox.Show(resMan.GetString("PatientSaved") + $"{newPatientId}",
                                 resMan.GetString("SaveSuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                // If you have a display field for the new ID, you could set it here:
                // lblPatientIdDisplay.Text = newPatientId.ToString();
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
            // Removed validation for txtPatientId as it's no longer manually entered.
            // Ensure you have a PatientData class with PatientId property.
            // Example:
            // public class PatientData { public int PatientId {get;set;} ... other props }

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
            // txtPatientId.Text = string.Empty; // Remove this line as txtPatientId is no longer input
            txtName.Text = string.Empty;
            dtDob.DateTime = DateTime.Now; // Or set a sensible default
            txtAge.Text = string.Empty;
            cmbBloodGroup.SelectedIndex = -1;
            txtContactNumber.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            txtAddress.Text = string.Empty;
            // If you have a label/readonly textbox for generated ID, clear it or set to "..."
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}