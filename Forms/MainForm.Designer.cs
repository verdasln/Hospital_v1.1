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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnAddPatient = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDiagnosis = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckPatientHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckHospitalInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlNews = new DevExpress.XtraEditors.GroupControl();
            this.btnReadMore = new DevExpress.XtraEditors.SimpleButton();
            this.memoEditDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblSourceDate = new DevExpress.XtraEditors.LabelControl();
            this.lblHeadline = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditNewsImage = new DevExpress.XtraEditors.PictureEdit();
            this.newsSlideshowTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNews)).BeginInit();
            this.groupControlNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditNewsImage.Properties)).BeginInit();
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
            // groupControlNews
            // 
            resources.ApplyResources(this.groupControlNews, "groupControlNews");
            this.groupControlNews.Controls.Add(this.btnReadMore);
            this.groupControlNews.Controls.Add(this.memoEditDescription);
            this.groupControlNews.Controls.Add(this.lblSourceDate);
            this.groupControlNews.Controls.Add(this.lblHeadline);
            this.groupControlNews.Controls.Add(this.pictureEditNewsImage);
            this.groupControlNews.Name = "groupControlNews";
            // 
            // btnReadMore
            // 
            resources.ApplyResources(this.btnReadMore, "btnReadMore");
            this.btnReadMore.ImageOptions.ImageKey = resources.GetString("btnReadMore.ImageOptions.ImageKey");
            this.btnReadMore.Name = "btnReadMore";
            // 
            // memoEditDescription
            // 
            resources.ApplyResources(this.memoEditDescription, "memoEditDescription");
            this.memoEditDescription.Name = "memoEditDescription";
            this.memoEditDescription.Properties.ReadOnly = true;
            // 
            // lblSourceDate
            // 
            resources.ApplyResources(this.lblSourceDate, "lblSourceDate");
            this.lblSourceDate.Appearance.FontSizeDelta = ((int)(resources.GetObject("lblSourceDate.Appearance.FontSizeDelta")));
            this.lblSourceDate.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblSourceDate.Appearance.Options.UseFont = true;
            this.lblSourceDate.Appearance.Options.UseForeColor = true;
            this.lblSourceDate.Name = "lblSourceDate";
            // 
            // lblHeadline
            // 
            resources.ApplyResources(this.lblHeadline, "lblHeadline");
            this.lblHeadline.Appearance.FontSizeDelta = ((int)(resources.GetObject("lblHeadline.Appearance.FontSizeDelta")));
            this.lblHeadline.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("lblHeadline.Appearance.FontStyleDelta")));
            this.lblHeadline.Appearance.Options.UseFont = true;
            this.lblHeadline.Appearance.Options.UseTextOptions = true;
            this.lblHeadline.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblHeadline.Name = "lblHeadline";
            // 
            // pictureEditNewsImage
            // 
            resources.ApplyResources(this.pictureEditNewsImage, "pictureEditNewsImage");
            this.pictureEditNewsImage.Name = "pictureEditNewsImage";
            this.pictureEditNewsImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditNewsImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // newsSlideshowTimer
            // 
            this.newsSlideshowTimer.Interval = 5000;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupControlNews);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnCheckPatientHistory);
            this.Controls.Add(this.btnCheckHospitalInfo);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNews)).EndInit();
            this.groupControlNews.ResumeLayout(false);
            this.groupControlNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditNewsImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private GroupControl groupControlNews;
        private PictureEdit pictureEditNewsImage;
        private LabelControl lblHeadline;
        private SimpleButton btnReadMore;
        private MemoEdit memoEditDescription;
        private LabelControl lblSourceDate;
        private System.Windows.Forms.Timer newsSlideshowTimer;
    }
}

