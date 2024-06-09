using DevExpress.XtraEditors;

namespace Hospital1._0.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private SimpleButton btnAddPatient;
        private SimpleButton btnAddDiagnosis;
        private SimpleButton btnCheckPatientHistory;
        private SimpleButton btnCheckHospitalInfo;
        private SimpleButton btnExit;

        private void InitializeComponent()
        {
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnAddPatient = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDiagnosis = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckPatientHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckHospitalInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(102, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Hospital Management System";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(33, 176);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(479, 30);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.Location = new System.Drawing.Point(33, 227);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(479, 30);
            this.btnAddDiagnosis.TabIndex = 1;
            this.btnAddDiagnosis.Text = "Add Diagnosis";
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // btnCheckPatientHistory
            // 
            this.btnCheckPatientHistory.Location = new System.Drawing.Point(33, 277);
            this.btnCheckPatientHistory.Name = "btnCheckPatientHistory";
            this.btnCheckPatientHistory.Size = new System.Drawing.Size(479, 30);
            this.btnCheckPatientHistory.TabIndex = 2;
            this.btnCheckPatientHistory.Text = "Check Patient History";
            this.btnCheckPatientHistory.Click += new System.EventHandler(this.btnCheckPatientHistory_Click);
            // 
            // btnCheckHospitalInfo
            // 
            this.btnCheckHospitalInfo.Location = new System.Drawing.Point(33, 327);
            this.btnCheckHospitalInfo.Name = "btnCheckHospitalInfo";
            this.btnCheckHospitalInfo.Size = new System.Drawing.Size(479, 30);
            this.btnCheckHospitalInfo.TabIndex = 3;
            this.btnCheckHospitalInfo.Text = "Check Hospital Info";
            this.btnCheckHospitalInfo.Click += new System.EventHandler(this.btnCheckHospitalInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(221, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(548, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnCheckPatientHistory);
            this.Controls.Add(this.btnCheckHospitalInfo);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

