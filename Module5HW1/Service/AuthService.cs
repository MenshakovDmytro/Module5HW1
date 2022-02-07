using System.Text;
using Module5HW1.Models.Requests;
using Module5HW1.Models.Responses;
using Module5HW1.Service.Abstraction;
using Newtonsoft.Json;

namespace Module5HW1.Service;

public class AuthService : IAuthService
{
    private readonly string _url;
    private readonly IHttpService _httpService;

    public AuthService(IHttpService httpService, IConfigService configService)
    {
        _url = configService.RequestConfig.RequestAddress;
        _httpService = httpService;
    }

    public async Task RegisterSuccessful()
    {
        var url = $"{_url}/api/register";
        var auth = new AuthRequest() { Email = "eve.holt@reqres.in", Password = "pistol" };
        var httpContent = new StringContent(JsonConvert.SerializeObject(auth), Encoding.UTF8, "application/json");
        await _httpService.SendAsync<RegisterSuccessfulResponse>(url, HttpMethod.Post, httpContent);
    }

    public async Task RegisterUnsuccessful()
    {
        var url = $"{_url}/api/register";
        var auth = new AuthRequest() { Email = "sydney@fife" };
        var httpContent = new StringContent(JsonConvert.SerializeObject(auth), Encoding.UTF8, "application/json");
        await _httpService.SendAsync<AuthUnsuccessfulResponse>(url, HttpMethod.Post, httpContent);
    }

    public async Task LoginSuccessful()
    {
        var url = $"{_url}/api/login";
        var auth = new AuthRequest() { Email = "eve.holt@reqres.in", Password = "cityslicka" };
        var httpContent = new StringContent(JsonConvert.SerializeObject(auth), Encoding.UTF8, "application/json");
        await _httpService.SendAsync<LoginSuccessfulResponse>(url, HttpMethod.Post, httpContent);
    }

    public async Task LoginUnsuccessful()
    {
        var url = $"{_url}/api/login";
        var auth = new AuthRequest() { Email = "peter@klaven" };
        var httpContent = new StringContent(JsonConvert.SerializeObject(auth), Encoding.UTF8, "application/json");
        await _httpService.SendAsync<AuthUnsuccessfulResponse>(url, HttpMethod.Post, httpContent);
    }
}