namespace Module5HW1.Service.Abstraction;

public interface IHttpService
{
    public Task<T> SendAsync<T>(string requestUri, HttpMethod method, string mediaType, object? body = null);
}