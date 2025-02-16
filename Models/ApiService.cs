using System.Net.Http.Json;

public class ApiService
{
    private readonly HttpClient _httpClient;

    private string baseUrl;
    private bool onLocalhost = false;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;

        if (onLocalhost)
        {
            baseUrl = "https://localhost:7181/";
        }
        else
        {
            baseUrl = "https://geograficwarsapi.onrender.com/";
        }
    }

    public async Task<string> GetDataAsync()
    {
        var response = await _httpClient.GetStringAsync(baseUrl + "WeatherForecast");
        return response;
    }
    public async Task PostDataAsync(object data)
    {
        var response = await _httpClient.PostAsJsonAsync(baseUrl + "WeatherForecast", data);
        response.EnsureSuccessStatusCode();
    }
}