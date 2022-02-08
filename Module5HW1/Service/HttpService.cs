using System.Text;
using Module5HW1.Service.Abstraction;
using Newtonsoft.Json;

namespace Module5HW1.Service;

public class HttpService : IHttpService
{
    private readonly HttpClient _httpClient;

    public HttpService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<T> SendAsync<T>(string url, HttpMethod method, string mediaType, object? payload = null)
    {
        var httpMessage = new HttpRequestMessage();
        if (payload is not null)
        {
            httpMessage.Content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, mediaType);
        }

        httpMessage.RequestUri = new Uri(url);
        httpMessage.Method = method;
        var result = await _httpClient.SendAsync(httpMessage);
        var content = await result.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<T>(content);
        return response;
    }
}