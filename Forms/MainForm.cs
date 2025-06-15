using System;
using System.Collections.Generic;
using System.Diagnostics; // Required for Process.Start (to open URL)
//using System.Globalization; // Required for CultureInfo
using System.Linq;
using System.Resources; // Required for ResourceManager
using System.Threading; // Required for Thread.CurrentThread.CurrentUICulture
using System.Windows.Forms; // Required for MessageBox, Timer
using DevExpress.XtraEditors; // Required for DevExpress controls like PictureEdit, LabelControl, MemoEdit, SimpleButton
// THESE ARE CRUCIAL - make sure your namespaces match where you placed your files
using Hospital1._0.Classes.News; // To access your NewsApiClient and Article classes
// If you placed them directly in Hospital1._0.Classes:
// using Hospital1._0.Classes;

namespace Hospital1._0.Forms
{
    public partial class MainForm : XtraForm
    {
        // Ensure this ResourceManager path is correct, based on where your Messages.resx files are.
        // If in the 'Properties' folder: "Hospital1._0.Properties.Messages"
        // If in a 'Classes' folder: "Hospital1._0.Classes.Messages"
        private ResourceManager resMan = new ResourceManager("Hospital1._0.Properties.MessagesStrings", typeof(Program).Assembly);

        private NewsApiClient _newsApiClient;
        private List<Article> _newsArticles;
        private int _currentArticleIndex = 0;

        public MainForm()
        {
            InitializeComponent();

            // Initialize your API client
            _newsApiClient = new NewsApiClient();

            // Apply localization to MainForm's own elements (titles, buttons for news section, etc.)
            ApplyLocalizedTextToMainFormControls();

            // Hook up event handlers for the news section
            // (Ensure these control names match what you set in the designer)
            this.Load += MainForm_Load;
            newsSlideshowTimer.Tick += newsSlideshowTimer_Tick; // Hook up the timer event
            btnReadMore.Click += btnReadMore_Click;             // Hook up read more button event

            // Your existing button click handlers are typically hooked up in the designer
            // If they are not, you would add lines like:
            // btnAddPatient.Click += btnAddPatient_Click;
        }

        // This method applies localized text to UI elements within MainForm.
        // Remember: If you localized a control's 'Text' property directly in the designer
        // (by setting Localizable = True and translating there), you might remove the corresponding
        // line here to avoid conflicts. This method is primarily for dynamic strings or elements
        // you prefer to manage via Messages.resx.
        private void ApplyLocalizedTextToMainFormControls()
        {
            this.Text = resMan.GetString("MainFormTitle"); // Form title
            groupControlNews.Text = resMan.GetString("LatestNewsGroupTitle"); // Title for the news section group
            btnReadMore.Text = resMan.GetString("ReadMoreButton"); // "Read Full Article" button
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Initial state: Display a loading message and stop the timer
            lblHeadline.Text = resMan.GetString("LoadingNews");
            memoEditDescription.Text = "";
            lblSourceDate.Text = "";
            pictureEditNewsImage.Image = null;
            newsSlideshowTimer.Stop(); // Ensure timer is stopped during loading

            btnReadMore.Enabled = false;

            try
            {
                string countryCode = "us";

                // News API's 'country' parameter usually requires the 2-letter ISO country code.
                // If Thread.CurrentThread.CurrentUICulture.TwoLetterISORegionName returns "TR" for Turkish, that's fine.
                // If it returns "DE" for German, but you want US news, you'd hardcode "us" or use a mapping.

                // Fetch news articles (you can adjust pageSize as needed, e.g., 5 or 10 articles)
                _newsArticles = await _newsApiClient.GetHealthHeadlinesAsync(countryCode, pageSize: 10);

                if (_newsArticles != null && _newsArticles.Any())
                {
                    _currentArticleIndex = 0; // Start displaying the first article
                    DisplayArticle(_currentArticleIndex);
                    newsSlideshowTimer.Start(); // Start the automatic slideshow timer
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
                    // --- CHANGE THIS LINE ---
                    // Directly await LoadAsync. It's already an async method.
                    await pictureEditNewsImage.LoadAsync(article.UrlToImage);
                    // --- END CHANGE ---

                    // Ensure the control's properties are still set for scaling (though usually set once in constructor/designer)
                    pictureEditNewsImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                }
                catch (Exception ex)
                {
                    // IMPORTANT: Log the error here to see exactly why it failed
                    System.Diagnostics.Debug.WriteLine($"Image load failed for URL: {article.UrlToImage}. Error: {ex.Message}");
                    // Optional: You can show a more user-friendly message or log to a file.

                    // If image fails to load, just clear the picture box or set a placeholder.
                    pictureEditNewsImage.Image = null; // Or set to a "No Image Available" placeholder
                }
            }
            else
            {
                pictureEditNewsImage.Image = null; // No image URL provided (or set placeholder)
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

        // Click event for the "Next" button
        private void btnNextNews_Click(object sender, EventArgs e)
        {
            if (_newsArticles != null && _newsArticles.Count > 1) // Only if more than one article
            {
                newsSlideshowTimer.Stop(); // Stop automatic advance on manual interaction
                _currentArticleIndex++;
                if (_currentArticleIndex >= _newsArticles.Count)
                {
                    _currentArticleIndex = 0; // Loop to the beginning
                }
                DisplayArticle(_currentArticleIndex);
                newsSlideshowTimer.Start(); // Restart timer
            }
        }

        // Click event for the "Previous" button
        private void btnPreviousNews_Click(object sender, EventArgs e)
        {
            if (_newsArticles != null && _newsArticles.Count > 1) // Only if more than one article
            {
                newsSlideshowTimer.Stop(); // Stop automatic advance on manual interaction
                _currentArticleIndex--;
                if (_currentArticleIndex < 0)
                {
                    _currentArticleIndex = _newsArticles.Count - 1; // Loop to the end
                }
                DisplayArticle(_currentArticleIndex);
                newsSlideshowTimer.Start(); // Restart timer
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

        // --- Your Existing Button Click Handlers ---
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