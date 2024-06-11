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

namespace Hospital1._0
{
    public partial class CheckPatientsHistoryForm : Form
    {
        public CheckPatientsHistoryForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "No", DataPropertyName = "No", Width = 50 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Symptoms", DataPropertyName = "Symptoms", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Diagnosis", DataPropertyName = "Diagnosis", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Medicines", DataPropertyName = "Medicines", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ward Required", DataPropertyName = "WardRequired", Width = 100 });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Type of Ward", DataPropertyName = "TypeOfWard", Width = 100 });
        }

        private async void  btnSearch_Click(object sender, EventArgs e)
        {
            // Retrieve and validate the ID from the form field.
            if (!int.TryParse(txtPatientId.Text, out int patientId))
            {
                MessageBox.Show("Please enter a valid Patient ID.");
                return;
            }

            // Validate if the patient ID exists in the "PatientData" collection
            var patientData = await GetPatientData(patientId);
            if (patientData == null)
            {
                MessageBox.Show("Patient ID does not exist. Please enter a valid Patient ID.");
                return;
            }

            // Retrieve and display the diagnosis records
            var diagnosisRecords = await GetPatientDiagnosisData(patientId);
            DisplayDiagnosisRecords(diagnosisRecords);
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

        private async Task<List<PatientDiagnosisData>> GetPatientDiagnosisData(int patientId)
        {
            FirestoreDb db = FirestoreHelper.Database;
            CollectionReference colRef = db.Collection("Patients").Document(patientId.ToString()).Collection("Diagnoses");
            QuerySnapshot snapshot = await colRef.GetSnapshotAsync();

            var diagnosisDataList = new List<PatientDiagnosisData>();
            foreach (var document in snapshot.Documents)
            {
                diagnosisDataList.Add(document.ConvertTo<PatientDiagnosisData>());
            }
            return diagnosisDataList;
        }
        private void DisplayDiagnosisRecords(List<PatientDiagnosisData> diagnosisRecords)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("No", typeof(int));
            dataTable.Columns.Add("Symptoms", typeof(string));
            dataTable.Columns.Add("Diagnosis", typeof(string));
            dataTable.Columns.Add("Medicines", typeof(string));
            dataTable.Columns.Add("WardRequired", typeof(bool));
            dataTable.Columns.Add("TypeOfWard", typeof(string));

            for (int i = 0; i < diagnosisRecords.Count; i++)
            {
                var record = diagnosisRecords[i];
                dataTable.Rows.Add(i + 1, record.Symptoms, record.Diagnosis, record.Medicines, record.WardRequired, record.TypeOfWard);
            }

            dataGridView.DataSource = dataTable;
            // Adjust column and row sizes
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
