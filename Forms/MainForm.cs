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
            var formPopup = new Form();
            formPopup.Show(this);
        }

        private void btnCheckPatientHistory_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this);
        }

        private void btnCheckHospitalInfo_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
