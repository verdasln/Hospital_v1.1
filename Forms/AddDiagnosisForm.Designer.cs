using System;

namespace Hospital1._0.Forms
{
    partial class AddDiagnosisForm
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


        #region Windows Form Designer generated code
        private DevExpress.XtraEditors.TextEdit txtPatientId;
        private DevExpress.XtraEditors.TextEdit txtPatientName;
        private DevExpress.XtraEditors.MemoEdit txtSymptoms;
        private DevExpress.XtraEditors.MemoEdit txtDiagnosis;
        private DevExpress.XtraEditors.MemoEdit txtMedicines;
        private DevExpress.XtraEditors.CheckEdit chkWardRequired;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTypeOfWard;
        private DevExpress.XtraEditors.SimpleButton btnSave;


        private void InitializeComponent()
        {
            this.txtPatientId = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientName = new DevExpress.XtraEditors.TextEdit();
            this.txtSymptoms = new DevExpress.XtraEditors.MemoEdit();
            this.txtDiagnosis = new DevExpress.XtraEditors.MemoEdit();
            this.txtMedicines = new DevExpress.XtraEditors.MemoEdit();
            this.chkWardRequired = new DevExpress.XtraEditors.CheckEdit();
            this.cmbTypeOfWard = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSymptoms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiagnosis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWardRequired.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeOfWard.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(131, 30);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Properties.NullValuePrompt = "Enter Patient ID";
            this.txtPatientId.Properties.Leave += new System.EventHandler(this.TxtPatientId_Leave);
            this.txtPatientId.Size = new System.Drawing.Size(219, 22);
            this.txtPatientId.TabIndex = 0;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(131, 70);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Properties.ReadOnly = true;
            this.txtPatientName.Properties.NullValuePrompt = "Patient Name";
            this.txtPatientName.Size = new System.Drawing.Size(219, 22);
            this.txtPatientName.TabIndex = 1;
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(131, 70);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Properties.NullValuePrompt = "Enter Symptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(219, 80);
            this.txtSymptoms.TabIndex = 1;
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(131, 170);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Properties.NullValuePrompt = "Enter Diagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(219, 80);
            this.txtDiagnosis.TabIndex = 2;
            // 
            // txtMedicines
            // 
            this.txtMedicines.Location = new System.Drawing.Point(131, 270);
            this.txtMedicines.Name = "txtMedicines";
            this.txtMedicines.Properties.NullValuePrompt = "Enter Medicines";
            this.txtMedicines.Size = new System.Drawing.Size(219, 80);
            this.txtMedicines.TabIndex = 3;
            // 
            // chkWardRequired
            // 
            this.chkWardRequired.Location = new System.Drawing.Point(131, 370);
            this.chkWardRequired.Name = "chkWardRequired";
            this.chkWardRequired.Properties.Caption = "Ward Required";
            this.chkWardRequired.Size = new System.Drawing.Size(105, 24);
            this.chkWardRequired.TabIndex = 4;
            this.chkWardRequired.CheckedChanged += new System.EventHandler(this.chkWardRequired_CheckedChanged);
            // 
            // cmbTypeOfWard
            // 
            this.cmbTypeOfWard.Enabled = false;
            this.cmbTypeOfWard.Location = new System.Drawing.Point(131, 410);
            this.cmbTypeOfWard.Name = "cmbTypeOfWard";
            this.cmbTypeOfWard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTypeOfWard.Properties.Items.AddRange(new object[] {
            "General",
            "Semi-Private",
            "Private"});
            this.cmbTypeOfWard.Properties.NullValuePrompt = "Select Type of Ward";
            this.cmbTypeOfWard.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTypeOfWard.Size = new System.Drawing.Size(219, 22);
            this.cmbTypeOfWard.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 520);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTypeOfWard);
            this.Controls.Add(this.chkWardRequired);
            this.Controls.Add(this.txtMedicines);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.txtPatientName);
            this.Name = "AddDiagnosisForm";
            this.Text = "Add Diagnosis Information";
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSymptoms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiagnosis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWardRequired.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeOfWard.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}