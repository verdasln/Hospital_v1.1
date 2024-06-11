using System.Windows.Forms;

namespace Hospital1._0
{
    partial class CheckHospitalInfoForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hospitalName = new DevExpress.XtraEditors.TextEdit();
            this.hospitalAddress = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalName
            // 
            this.hospitalName.Cursor = System.Windows.Forms.Cursors.No;
            this.hospitalName.Location = new System.Drawing.Point(150, 46);
            this.hospitalName.Name = "hospitalName";
            this.hospitalName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalName.Properties.Appearance.Options.UseFont = true;
            this.hospitalName.Properties.ReadOnly = true;
            this.hospitalName.Size = new System.Drawing.Size(225, 40);
            this.hospitalName.TabIndex = 0;
            // 
            // hospitalAddress
            // 
            this.hospitalAddress.Location = new System.Drawing.Point(150, 122);
            this.hospitalAddress.Name = "hospitalAddress";
            this.hospitalAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.hospitalAddress.Properties.Appearance.Options.UseFont = true;
            this.hospitalAddress.Properties.ReadOnly = true;
            this.hospitalAddress.Size = new System.Drawing.Size(225, 116);
            this.hospitalAddress.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Hospital name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hospital name";
            // 
            // CheckHospitalInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 250);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.hospitalAddress);
            this.Controls.Add(this.hospitalName);
            this.Name = "CheckHospitalInfoForm";
            this.Text = "CheckHospitalInfo";
            ((System.ComponentModel.ISupportInitialize)(this.hospitalName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalAddress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit hospitalName;
        private DevExpress.XtraEditors.MemoEdit hospitalAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}