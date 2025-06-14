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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblTitle.Appearance.Font")));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Name = "lblTitle";
            // 
            // btnAddPatient
            // 
            resources.ApplyResources(this.btnAddPatient, "btnAddPatient");
            this.btnAddPatient.ImageOptions.ImageKey = resources.GetString("btnAddPatient.ImageOptions.ImageKey");
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddDiagnosis
            // 
            resources.ApplyResources(this.btnAddDiagnosis, "btnAddDiagnosis");
            this.btnAddDiagnosis.ImageOptions.ImageKey = resources.GetString("btnAddDiagnosis.ImageOptions.ImageKey");
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // btnCheckPatientHistory
            // 
            resources.ApplyResources(this.btnCheckPatientHistory, "btnCheckPatientHistory");
            this.btnCheckPatientHistory.ImageOptions.ImageKey = resources.GetString("btnCheckPatientHistory.ImageOptions.ImageKey");
            this.btnCheckPatientHistory.Name = "btnCheckPatientHistory";
            this.btnCheckPatientHistory.Click += new System.EventHandler(this.btnCheckPatientHistory_Click);
            // 
            // btnCheckHospitalInfo
            // 
            resources.ApplyResources(this.btnCheckHospitalInfo, "btnCheckHospitalInfo");
            this.btnCheckHospitalInfo.ImageOptions.ImageKey = resources.GetString("btnCheckHospitalInfo.ImageOptions.ImageKey");
            this.btnCheckHospitalInfo.Name = "btnCheckHospitalInfo";
            this.btnCheckHospitalInfo.Click += new System.EventHandler(this.btnCheckHospitalInfo_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ImageOptions.ImageKey = resources.GetString("btnExit.ImageOptions.ImageKey");
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnCheckPatientHistory);
            this.Controls.Add(this.btnCheckHospitalInfo);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

