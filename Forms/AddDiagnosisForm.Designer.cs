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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiagnosisForm));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtPatientId = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientName = new DevExpress.XtraEditors.TextEdit();
            this.txtSymptoms = new DevExpress.XtraEditors.MemoEdit();
            this.txtDiagnosis = new DevExpress.XtraEditors.MemoEdit();
            this.txtMedicines = new DevExpress.XtraEditors.MemoEdit();
            this.chkWardRequired = new DevExpress.XtraEditors.CheckEdit();
            this.cmbTypeOfWard = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSymptoms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiagnosis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWardRequired.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeOfWard.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ImageOptions.ImageKey = resources.GetString("btnSave.ImageOptions.ImageKey");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPatientId
            // 
            resources.ApplyResources(this.txtPatientId, "txtPatientId");
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Properties.NullValuePrompt = resources.GetString("txtPatientId.Properties.NullValuePrompt");
            this.txtPatientId.Properties.Leave += new System.EventHandler(this.TxtPatientId_Leave);
            this.txtPatientId.EditValueChanged += new System.EventHandler(this.txtPatientId_EditValueChanged);
            // 
            // txtPatientName
            // 
            resources.ApplyResources(this.txtPatientName, "txtPatientName");
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Properties.NullValuePrompt = resources.GetString("txtPatientName.Properties.NullValuePrompt");
            this.txtPatientName.Properties.ReadOnly = true;
            // 
            // txtSymptoms
            // 
            resources.ApplyResources(this.txtSymptoms, "txtSymptoms");
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Properties.NullValuePrompt = resources.GetString("txtSymptoms.Properties.NullValuePrompt");
            // 
            // txtDiagnosis
            // 
            resources.ApplyResources(this.txtDiagnosis, "txtDiagnosis");
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Properties.NullValuePrompt = resources.GetString("txtDiagnosis.Properties.NullValuePrompt");
            // 
            // txtMedicines
            // 
            resources.ApplyResources(this.txtMedicines, "txtMedicines");
            this.txtMedicines.Name = "txtMedicines";
            this.txtMedicines.Properties.NullValuePrompt = resources.GetString("txtMedicines.Properties.NullValuePrompt");
            // 
            // chkWardRequired
            // 
            resources.ApplyResources(this.chkWardRequired, "chkWardRequired");
            this.chkWardRequired.Name = "chkWardRequired";
            this.chkWardRequired.Properties.Caption = resources.GetString("chkWardRequired.Properties.Caption");
            this.chkWardRequired.Properties.DisplayValueChecked = resources.GetString("chkWardRequired.Properties.DisplayValueChecked");
            this.chkWardRequired.Properties.DisplayValueGrayed = resources.GetString("chkWardRequired.Properties.DisplayValueGrayed");
            this.chkWardRequired.Properties.DisplayValueUnchecked = resources.GetString("chkWardRequired.Properties.DisplayValueUnchecked");
            this.chkWardRequired.Properties.GlyphVerticalAlignment = ((DevExpress.Utils.VertAlignment)(resources.GetObject("chkWardRequired.Properties.GlyphVerticalAlignment")));
            this.chkWardRequired.CheckedChanged += new System.EventHandler(this.chkWardRequired_CheckedChanged);
            // 
            // cmbTypeOfWard
            // 
            resources.ApplyResources(this.cmbTypeOfWard, "cmbTypeOfWard");
            this.cmbTypeOfWard.Name = "cmbTypeOfWard";
            this.cmbTypeOfWard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cmbTypeOfWard.Properties.Buttons"))))});
            this.cmbTypeOfWard.Properties.Items.AddRange(new object[] {
            resources.GetString("cmbTypeOfWard.Properties.Items"),
            resources.GetString("cmbTypeOfWard.Properties.Items1"),
            resources.GetString("cmbTypeOfWard.Properties.Items2")});
            this.cmbTypeOfWard.Properties.NullValuePrompt = resources.GetString("cmbTypeOfWard.Properties.NullValuePrompt");
            this.cmbTypeOfWard.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // AddDiagnosisForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTypeOfWard);
            this.Controls.Add(this.chkWardRequired);
            this.Controls.Add(this.txtMedicines);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.txtPatientName);
            this.Name = "AddDiagnosisForm";
            this.Load += new System.EventHandler(this.AddDiagnosisForm_Load);
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