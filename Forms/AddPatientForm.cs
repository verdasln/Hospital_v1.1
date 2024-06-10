using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Hospital1._0.Forms
{
    public partial class AddPatientForm : XtraForm
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patient information saved successfully!");

            // Clear all input fields
            txtName.Text = string.Empty;
            dtDob.DateTime = DateTime.Now;
            txtAge.Text = string.Empty;
            cmbBloodGroup.SelectedIndex = -1;
            txtAddress.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            txtPatientId.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
