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

    public async Task SendAsync<TReturnType>(string url, HttpMethod method, StringContent? httpContent = null)
    {
        var httpMessage = new HttpRequestMessage();
        if (httpContent is not null)
        {
            httpMessage.Content = httpContent;
        }

        httpMessage.RequestUri = new Uri(url);
        httpMessage.Method = method;
        var result = await _httpClient.SendAsync(httpMessage);
        var content = await result.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<TReturnType>(content);
    }
}