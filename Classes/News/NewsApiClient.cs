using System;
using System.Collections.Generic; 
using System.Configuration;
using System.Net.Http; 
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Hospital1._0.Classes.News
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
        }

        // Method to get top health headlines
        public async Task<List<Article>> GetHealthHeadlinesAsync(string country, int pageSize = 10)
        {
            try
            {
                // Construct the API URL for top health headlines
                string requestUrl = $"{BaseUrl}top-headlines?" +
                                    $"country={country}&" +
                                    $"category=health&" +
                                    $"pageSize={pageSize}&" +
                                    $"apiKey={_apiKey}";


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