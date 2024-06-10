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
            this.components = new System.ComponentModel.Container();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblDob = new DevExpress.XtraEditors.LabelControl();
            this.dtDob = new DevExpress.XtraEditors.DateEdit();
            this.lblAge = new DevExpress.XtraEditors.LabelControl();
            this.txtAge = new DevExpress.XtraEditors.TextEdit();
            this.lblBloodGroup = new DevExpress.XtraEditors.LabelControl();
            this.cmbBloodGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.lblContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtContactNumber = new DevExpress.XtraEditors.TextEdit();
            this.lblGender = new DevExpress.XtraEditors.LabelControl();
            this.cmbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPatientId = new DevExpress.XtraEditors.LabelControl();
            this.txtPatientId = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();

            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 16);
            this.lblName.Text = "Name:";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 0;

            // 
            // lblDob
            // 
            this.lblDob.Location = new System.Drawing.Point(30, 70);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(74, 16);
            this.lblDob.Text = "Date of Birth:";


            // 
            // dtDob
            // 
            this.dtDob.Location = new System.Drawing.Point(150, 67);
            this.dtDob.Name = "dtDob";
            this.dtDob.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDob.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDob.Properties.EditFormat.FormatString = "DD/MM/YYYY";
            this.dtDob.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDob.Properties.Mask.EditMask = "DD/MM/YYYY";
            this.dtDob.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtDob.Size = new System.Drawing.Size(250, 22);
            this.dtDob.TabIndex = 1;
            this.dtDob.EditValueChanged += new System.EventHandler(this.dtDob_EditValueChanged);


            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(30, 110);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 16);
            this.lblAge.Text = "Age:";

            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(150, 107);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(250, 22);
            this.txtAge.Properties.ReadOnly = true;
            this.txtAge.TabIndex = 2;

            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.Location = new System.Drawing.Point(30, 150);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(76, 16);
            this.lblBloodGroup.Text = "Blood Group:";

            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.Location = new System.Drawing.Point(150, 147);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBloodGroup.Properties.Items.AddRange(new object[] {
                "A+",
                "A-",
                "B+",
                "B-",
                "AB+",
                "AB-",
                "O+",
                "O-"});
            this.cmbBloodGroup.Size = new System.Drawing.Size(250, 22);
            this.cmbBloodGroup.TabIndex = 3;

            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(30, 190);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 16);
            this.lblAddress.Text = "Address:";

            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 187);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 60);
            this.txtAddress.TabIndex = 4;

            // 
            // lblContactNumber
            // 
            this.lblContactNumber.Location = new System.Drawing.Point(30, 260);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(100, 16);
            this.lblContactNumber.Text = "Contact Number:";

            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(150, 257);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Properties.Mask.EditMask = "(000) 000 00 00";
            this.txtContactNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtContactNumber.Size = new System.Drawing.Size(250, 22);
            this.txtContactNumber.TabIndex = 5;

            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(30, 300);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(50, 16);
            this.lblGender.Text = "Gender:";

            // 
            // cmbGender
            // 
            this.cmbGender.Location = new System.Drawing.Point(150, 297);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGender.Properties.Items.AddRange(new object[] {
                "Male",
                "Female",
                "Other"});
            this.cmbGender.Size = new System.Drawing.Size(250, 22);
            this.cmbGender.TabIndex = 6;

            // 
            // lblPatientId
            // 
            this.lblPatientId.Location = new System.Drawing.Point(30, 340);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(64, 16);
            this.lblPatientId.Text = "Patient ID:";

            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(150, 337);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Properties.Mask.EditMask = "\\d{0,4}";
            this.txtPatientId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPatientId.Size = new System.Drawing.Size(250, 22);
            this.txtPatientId.TabIndex = 7;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(306, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
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
            this.Text = "Add Patient";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}