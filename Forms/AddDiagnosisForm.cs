using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Google.Cloud.Firestore;
using Hospital1._0.Classes;

namespace Hospital1._0.Forms
{
    public partial class AddDiagnosisForm : XtraForm
    {
        public AddDiagnosisForm()
        {
            InitializeComponent();
        }

        int patientId;
        private async void btnSave_Click(object sender, EventArgs e)
        {


            var patientData = new PatientDiagnosisData()
            {
                PatientId = patientId,
                Symptoms = txtSymptoms.Text,
                Diagnosis = txtDiagnosis.Text,
                Medicines = txtMedicines.Text,
                WardRequired = chkWardRequired.Checked,
                TypeOfWard = cmbTypeOfWard.Text
            };

            // Save the data to Firestore
            await SavePatientDiagnosisData(patientData);

            // Clear the fields after saving
            ClearFields();
        }

        private async void TxtPatientId_Leave(object sender, EventArgs e)
        {
            // Retrieve and validate the ID from the form field.
            if (!int.TryParse(txtPatientId.Text, out patientId))
            {
                MessageBox.Show("Please enter a valid Patient ID.");
                btnSave.Enabled = false;
                return;
            }

            // Validate if the patient ID exists in the "PatientData" collection
            bool patientExists = await ValidatePatientIdExists(patientId);
            if (!patientExists)
            {
                MessageBox.Show("Patient ID does not exist. Please enter a valid Patient ID.");
                btnSave.Enabled = false;
                return;
            }

            // Enable the save button if the patient ID exists
            btnSave.Enabled = true;

        }
        private async Task<bool> ValidatePatientIdExists(int patientId)
        {
            FirestoreDb db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("Patients").Document(patientId.ToString());
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            return snapshot.Exists;
        }

        private async Task SavePatientDiagnosisData(PatientDiagnosisData data)
        {
            FirestoreDb db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("PatientDiagnoses").Document(data.PatientId.ToString());
            await docRef.SetAsync(data);
        }

        private void chkWardRequired_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWardRequired.Checked)
            {
                cmbTypeOfWard.Enabled = true;
            }
            else
            {
                cmbTypeOfWard.Enabled = false;
            }
        }

        private void ClearFields()
        {
            txtPatientId.Text = "";
            txtSymptoms.Text = "";
            txtDiagnosis.Text = "";
            txtMedicines.Text = "";
            chkWardRequired.Checked = false;
            cmbTypeOfWard.SelectedIndex = -1;
        }
    }
}
