namespace Hospital1._0.Forms
{
    partial class AddPatientForm
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

        
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblDob;
        private DevExpress.XtraEditors.DateEdit dtDob;
        private DevExpress.XtraEditors.LabelControl lblAge;
        private DevExpress.XtraEditors.TextEdit txtAge;
        private DevExpress.XtraEditors.LabelControl lblBloodGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBloodGroup;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblContactNumber;
        private DevExpress.XtraEditors.TextEdit txtContactNumber;
        private DevExpress.XtraEditors.LabelControl lblGender;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGender;
        private DevExpress.XtraEditors.LabelControl lblPatientId;
        private DevExpress.XtraEditors.TextEdit txtPatientId;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblDob = new DevExpress.XtraEditors.LabelControl();
            this.lblAge = new DevExpress.XtraEditors.LabelControl();
            this.lblBloodGroup = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.lblContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblGender = new DevExpress.XtraEditors.LabelControl();
            this.lblPatientId = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.dtDob = new DevExpress.XtraEditors.DateEdit();
            this.txtAge = new DevExpress.XtraEditors.TextEdit();
            this.cmbBloodGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtContactNumber = new DevExpress.XtraEditors.TextEdit();
            this.cmbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPatientId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDob.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBloodGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblDob
            // 
            resources.ApplyResources(this.lblDob, "lblDob");
            this.lblDob.Name = "lblDob";
            // 
            // lblAge
            // 
            resources.ApplyResources(this.lblAge, "lblAge");
            this.lblAge.Name = "lblAge";
            // 
            // lblBloodGroup
            // 
            resources.ApplyResources(this.lblBloodGroup, "lblBloodGroup");
            this.lblBloodGroup.Name = "lblBloodGroup";
            // 
            // lblAddress
            // 
            resources.ApplyResources(this.lblAddress, "lblAddress");
            this.lblAddress.Name = "lblAddress";
            // 
            // lblContactNumber
            // 
            resources.ApplyResources(this.lblContactNumber, "lblContactNumber");
            this.lblContactNumber.Name = "lblContactNumber";
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            // 
            // lblPatientId
            // 
            resources.ApplyResources(this.lblPatientId, "lblPatientId");
            this.lblPatientId.Name = "lblPatientId";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ImageOptions.ImageKey = resources.GetString("btnSave.ImageOptions.ImageKey");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ImageOptions.ImageKey = resources.GetString("btnCancel.ImageOptions.ImageKey");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // dtDob
            // 
            resources.ApplyResources(this.dtDob, "dtDob");
            this.dtDob.Name = "dtDob";
            this.dtDob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtDob.Properties.Buttons"))))});
            this.dtDob.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtDob.Properties.CalendarTimeProperties.Buttons")))),
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dtDob.Properties.CalendarTimeProperties.Buttons1"))))});
            this.dtDob.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDob.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDob.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("dtDob.Properties.Mask.UseMaskAsDisplayFormat")));
            this.dtDob.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDob.EditValueChanged += new System.EventHandler(this.dtDob_EditValueChanged);
            // 
            // txtAge
            // 
            resources.ApplyResources(this.txtAge, "txtAge");
            this.txtAge.Name = "txtAge";
            this.txtAge.Properties.ReadOnly = true;
            // 
            // cmbBloodGroup
            // 
            resources.ApplyResources(this.cmbBloodGroup, "cmbBloodGroup");
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cmbBloodGroup.Properties.Buttons"))))});
            this.cmbBloodGroup.Properties.Items.AddRange(new object[] {
            resources.GetString("cmbBloodGroup.Properties.Items"),
            resources.GetString("cmbBloodGroup.Properties.Items1"),
            resources.GetString("cmbBloodGroup.Properties.Items2"),
            resources.GetString("cmbBloodGroup.Properties.Items3"),
            resources.GetString("cmbBloodGroup.Properties.Items4"),
            resources.GetString("cmbBloodGroup.Properties.Items5"),
            resources.GetString("cmbBloodGroup.Properties.Items6"),
            resources.GetString("cmbBloodGroup.Properties.Items7")});
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // txtContactNumber
            // 
            resources.ApplyResources(this.txtContactNumber, "txtContactNumber");
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtContactNumber.Properties.MaskSettings.Set("mask", "(000) 000 00 00");
            // 
            // cmbGender
            // 
            resources.ApplyResources(this.cmbGender, "cmbGender");
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cmbGender.Properties.Buttons"))))});
            this.cmbGender.Properties.Items.AddRange(new object[] {
            resources.GetString("cmbGender.Properties.Items"),
            resources.GetString("cmbGender.Properties.Items1"),
            resources.GetString("cmbGender.Properties.Items2")});
            // 
            // txtPatientId
            // 
            resources.ApplyResources(this.txtPatientId, "txtPatientId");
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtPatientId.Properties.MaskSettings.Set("allowBlankInput", true);
            this.txtPatientId.Properties.MaskSettings.Set("mask", "\\d{0,4}");
            // 
            // AddPatientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cmbBloodGroup);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddPatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDob.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBloodGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}