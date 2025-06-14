using System;
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
    public partial class AddDiagnosisForm : XtraForm
    {

        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.Messages", typeof(Program).Assembly);

        public AddDiagnosisForm()
        {
            InitializeComponent();
        }

        int patientId;
        private async void btnSave_Click(object sender, EventArgs e)
        {

            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtSymptoms.Text) || string.IsNullOrWhiteSpace(txtDiagnosis.Text) || string.IsNullOrWhiteSpace(txtMedicines.Text))
            {
                MessageBox.Show(resMan.GetString("MissingFields"));
                btnSave.Enabled = false;
                return;
            }

            btnSave.Enabled = true;

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
                MessageBox.Show(resMan.GetString("MissingID"));
                btnSave.Enabled = false;
                return;
            }

            // Validate if the patient ID exists in the "PatientData" collection
            var patientData = await GetPatientData(patientId);
            if (patientData == null)
            {
                MessageBox.Show(resMan.GetString("IdDosentExist"));
                btnSave.Enabled = false;
                txtPatientName.Text = string.Empty;
                return;
            }

            // Display the patient's name
            txtPatientName.Text = patientData.PatientName;

            // Enable the save button if the patient ID exists
            btnSave.Enabled = true;
        }

        private async Task<PatientData> GetPatientData(int patientId)
        {
            FirestoreDb db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("Patients").Document(patientId.ToString());
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                return snapshot.ConvertTo<PatientData>();
            }
            return null;
        }

        private async Task SavePatientDiagnosisData(PatientDiagnosisData data)
        {
            FirestoreDb db = FirestoreHelper.Database;
            CollectionReference colRef = db.Collection("Patients").Document(data.PatientId.ToString()).Collection("Diagnoses");
            await colRef.AddAsync(data);
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
            txtPatientName.Text = "";
            txtSymptoms.Text = "";
            txtDiagnosis.Text = "";
            txtMedicines.Text = "";
            chkWardRequired.Checked = false;
            cmbTypeOfWard.SelectedIndex = -1;
        }

        private void AddDiagnosisForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPatientId_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
