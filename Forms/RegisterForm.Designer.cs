namespace Hospital1._0.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblRegister = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturnToLogin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEditUserIcon = new DevExpress.XtraEditors.PictureEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserIcon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblTitle.Appearance.Font")));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Name = "lblTitle";
            // 
            // lblRegister
            // 
            resources.ApplyResources(this.lblRegister, "lblRegister");
            this.lblRegister.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblRegister.Appearance.Font")));
            this.lblRegister.Appearance.Options.UseFont = true;
            this.lblRegister.Name = "lblRegister";
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.ImageOptions.ImageKey = resources.GetString("btnRegister.ImageOptions.ImageKey");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReturnToLogin
            // 
            resources.ApplyResources(this.btnReturnToLogin, "btnReturnToLogin");
            this.btnReturnToLogin.ImageOptions.ImageKey = resources.GetString("btnReturnToLogin.ImageOptions.ImageKey");
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
            // 
            // pictureEditUserIcon
            // 
            resources.ApplyResources(this.pictureEditUserIcon, "pictureEditUserIcon");
            this.pictureEditUserIcon.EditValue = global::Hospital1._0.Properties.Resources.user;
            this.pictureEditUserIcon.Name = "pictureEditUserIcon";
            this.pictureEditUserIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditUserIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.AllowFocused = false;
            this.txtUsername.Properties.NullText = resources.GetString("txtUsername.Properties.NullText");
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.NullText = resources.GetString("txtPassword.Properties.NullText");
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.pictureEditUserIcon);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnReturnToLogin);
            this.Name = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserIcon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEditUserIcon;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lblRegister;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnReturnToLogin;
    }
}