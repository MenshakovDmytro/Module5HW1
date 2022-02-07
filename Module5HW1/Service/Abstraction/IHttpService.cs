namespace Module5HW1.Service.Abstraction;

public interface IHttpService
{
    public Task SendAsync<TReturnType>(string requestUri, HttpMethod method, StringContent? httpContent = null);
}