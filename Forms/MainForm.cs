using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Hospital1._0.Classes.News;

namespace Hospital1._0.Forms
{
    public partial class MainForm : XtraForm
    {
        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.MessagesStrings", typeof(Program).Assembly);

        private NewsApiClient _newsApiClient;
        private List<Article> _newsArticles;
        private int _currentArticleIndex = 0;

        public MainForm()
        {
            InitializeComponent();

            _newsApiClient = new NewsApiClient();

            // Apply localization to MainForm's own elements (titles, buttons for news section, etc.)
            ApplyLocalizedTextToMainFormControls();

            this.Load += MainForm_Load;
            newsSlideshowTimer.Tick += newsSlideshowTimer_Tick;
            btnReadMore.Click += btnReadMore_Click;
        }

        private void ApplyLocalizedTextToMainFormControls()
        {
            this.Text = resMan.GetString("MainFormTitle");
            groupControlNews.Text = resMan.GetString("LatestNewsGroupTitle");
            btnReadMore.Text = resMan.GetString("ReadMoreButton");
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Initial state: Display a loading message and stop the timer
            lblHeadline.Text = resMan.GetString("LoadingNews");
            memoEditDescription.Text = "";
            lblSourceDate.Text = "";
            pictureEditNewsImage.Image = null;
            newsSlideshowTimer.Stop(); // Timer is stopped during loading

            btnReadMore.Enabled = false;

            try
            {
                string countryCode = "us";

                // Fetch news articles, adjust pageSize as needed.
                _newsArticles = await _newsApiClient.GetHealthHeadlinesAsync(countryCode, pageSize: 10);

                if (_newsArticles != null && _newsArticles.Any())
                {
                    _currentArticleIndex = 0;
                    DisplayArticle(_currentArticleIndex);
                    newsSlideshowTimer.Start();
                }
                else
                {
                    // No news found scenario
                    lblHeadline.Text = resMan.GetString("NoNewsAvailable");
                    memoEditDescription.Text = "";
                    lblSourceDate.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during news fetching (network issues, API errors, etc.)
                MessageBox.Show(resMan.GetString("FailedToLoadNews") + Environment.NewLine + ex.Message,
                                resMan.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblHeadline.Text = resMan.GetString("NewsLoadError"); // Display a generic error message
                memoEditDescription.Text = "";
                lblSourceDate.Text = "";
            }
        }

        // Helper method to display a specific news article
        private async void DisplayArticle(int index)
        {
            // Basic validation for the index
            if (_newsArticles == null || !_newsArticles.Any() || index < 0 || index >= _newsArticles.Count)
            {
                lblHeadline.Text = resMan.GetString("NoNewsAvailable");
                memoEditDescription.Text = "";
                lblSourceDate.Text = "";
                pictureEditNewsImage.Image = null;
                btnReadMore.Enabled = false;
                return;
            }

            Article article = _newsArticles[index];

            // Update UI controls with article data
            lblHeadline.Text = article.Title;
            memoEditDescription.Text = article.Description;

            // Format published date for display based on current culture
            string formattedDate = article.PublishedAt.ToLocalTime().ToString(
                Thread.CurrentThread.CurrentUICulture.DateTimeFormat.ShortDatePattern + " " +
                Thread.CurrentThread.CurrentUICulture.DateTimeFormat.ShortTimePattern);

            lblSourceDate.Text = $"{article.Source?.Name ?? resMan.GetString("UnknownSource")} - {formattedDate}";
            // Make sure you add "UnknownSource" key to your Messages.resx files!

            // Enable "Read More" button only if a URL exists
            btnReadMore.Enabled = !string.IsNullOrEmpty(article.Url);

            // Load article image asynchronously
            pictureEditNewsImage.Image = null; // Clear previous image first

            // Load article image asynchronously
            if (!string.IsNullOrEmpty(article.UrlToImage))
            {
                try
                {
                    await pictureEditNewsImage.LoadAsync(article.UrlToImage);

                    pictureEditNewsImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Image load failed for URL: {article.UrlToImage}. Error: {ex.Message}");

                    pictureEditNewsImage.Image = null;
                }
            }
            else
            {
                pictureEditNewsImage.Image = null;
            }
        }

        // Timer Tick event for automatic slideshow advance
        private void newsSlideshowTimer_Tick(object sender, EventArgs e)
        {
            // Only advance if there are articles to show
            if (_newsArticles != null && _newsArticles.Any())
            {
                _currentArticleIndex++;
                if (_currentArticleIndex >= _newsArticles.Count)
                {
                    _currentArticleIndex = 0; // Loop back to the first article
                }
                DisplayArticle(_currentArticleIndex);
            }
        }


        // Click event for "Read Full Article" button
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            if (_newsArticles != null && _newsArticles.Any() && _currentArticleIndex >= 0 && _currentArticleIndex < _newsArticles.Count)
            {
                string url = _newsArticles[_currentArticleIndex].Url;
                if (!string.IsNullOrEmpty(url))
                {
                    try
                    {
                        // Open the URL in the user's default web browser
                        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(resMan.GetString("FailedToOpenLink") + Environment.NewLine + ex.Message,
                                        resMan.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            AddDiagnosisForm form = new AddDiagnosisForm();
            form.ShowDialog();
        }

        private void btnCheckPatientHistory_Click(object sender, EventArgs e)
        {
            CheckPatientsHistoryForm form = new CheckPatientsHistoryForm();
            form.ShowDialog();
        }

        private void btnCheckHospitalInfo_Click(object sender, EventArgs e)
        {
            CheckHospitalInfoForm form = new CheckHospitalInfoForm();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}