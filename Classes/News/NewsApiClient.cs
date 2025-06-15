using System;
using System.Collections.Generic; // For List
using System.Configuration; // For ConfigurationManager (to read App.config)
using System.Net.Http; // For HttpClient, HttpResponseMessage
using System.Threading.Tasks; // For async/await
using Newtonsoft.Json;       // For JsonConvert (to deserialize JSON)

namespace Hospital1._0.Classes.News // Adjust this namespace if your folder structure is different
{
    public class NewsApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private const string BaseUrl = "https://newsapi.org/v2/";

        public NewsApiClient()
        {
            _httpClient = new HttpClient();
            // Read API key from App.config
            _apiKey = ConfigurationManager.AppSettings["NewsApiKey"];

            if (string.IsNullOrEmpty(_apiKey))
            {
                // This error will tell you if the API key is missing or empty in App.config
                throw new InvalidOperationException("News API key (NewsApiKey) not found or is empty in App.config. Please add it.");
            }
        }

        // Method to get top health headlines
        // Takes language (e.g., "en", "tr") and country (e.g., "us", "tr") as 2-letter ISO codes.
        public async Task<List<Article>> GetHealthHeadlinesAsync(string country, int pageSize = 10)
        {
            try
            {
                // Construct the API URL for top health headlines
                string requestUrl = $"{BaseUrl}top-headlines?" +
                                    $"country={country}&" +   // Filter by country (e.g., US, TR) 
                                    $"category=health&" +
                                    $"pageSize={pageSize}&" + // Number of articles to fetch
                                    $"apiKey={_apiKey}";      // Your API key


                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                response.EnsureSuccessStatusCode(); // Throws an HttpRequestException for 4xx or 5xx status codes

                string jsonResponse = await response.Content.ReadAsStringAsync();
                NewsApiResponse apiResponse = JsonConvert.DeserializeObject<NewsApiResponse>(jsonResponse);

                if (apiResponse.Status == "ok" && apiResponse.Articles != null)
                {
                    return apiResponse.Articles;
                }
                else
                {
                    // If API returns a status other than "ok" (e.g., "error")
                    // News API error responses typically have 'code' and 'message' properties.
                    // You could enhance NewsApiResponse to capture these for better error details.
                    throw new Exception($"News API returned an error status: {apiResponse.Status}. Check API documentation for error codes.");
                }
            }
            catch (HttpRequestException httpEx)
            {
                // Handles network-related errors (e.g., no internet, API endpoint down, 404, 500)
                throw new Exception($"Network error occurred while fetching news: {httpEx.Message}. Status: {httpEx.Message}", httpEx);
            }
            catch (JsonException jsonEx)
            {
                // Handles errors during JSON parsing (e.g., malformed JSON response)
                throw new Exception($"Error parsing news API response: {jsonEx.Message}", jsonEx);
            }
            catch (Exception ex)
            {
                // Catches any other unexpected errors
                throw new Exception($"An unexpected error occurred while fetching news: {ex.Message}", ex);
            }
        }
    }
}