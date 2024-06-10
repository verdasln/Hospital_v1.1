using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hospital1._0.Forms
{
    public partial class MainForm : XtraForm
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            AddDiagnosisForm form = new AddDiagnosisForm();
            form.ShowDialog();
        }

        private void btnCheckPatientHistory_Click(object sender, EventArgs e)
        {
            CheckPatientsHistoryForm form = new CheckPatientsHistoryForm();
            form.ShowDialog();
        }

        private void btnCheckHospitalInfo_Click(object sender, EventArgs e)
        {
            CheckHospitalInfoForm form = new CheckHospitalInfoForm();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
