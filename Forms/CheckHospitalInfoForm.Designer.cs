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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckHospitalInfoForm));
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
            resources.ApplyResources(this.hospitalName, "hospitalName");
            this.hospitalName.Cursor = System.Windows.Forms.Cursors.No;
            this.hospitalName.Name = "hospitalName";
            this.hospitalName.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("hospitalName.Properties.Appearance.Font")));
            this.hospitalName.Properties.Appearance.Options.UseFont = true;
            this.hospitalName.Properties.ReadOnly = true;
            // 
            // hospitalAddress
            // 
            resources.ApplyResources(this.hospitalAddress, "hospitalAddress");
            this.hospitalAddress.Name = "hospitalAddress";
            this.hospitalAddress.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("hospitalAddress.Properties.Appearance.Font")));
            this.hospitalAddress.Properties.Appearance.Options.UseFont = true;
            this.hospitalAddress.Properties.ReadOnly = true;
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // CheckHospitalInfoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.hospitalAddress);
            this.Controls.Add(this.hospitalName);
            this.Name = "CheckHospitalInfoForm";
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