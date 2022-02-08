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

    public async Task<RegisterSuccessfulResponse> RegisterSuccessful()
    {
        var url = @$"{_url}/api/register";
        var auth = new AuthRequest() { Email = "eve.holt@reqres.in", Password = "pistol" };
        return await _httpService.SendAsync<RegisterSuccessfulResponse>(url, HttpMethod.Post, "application/json", auth);
    }

    public async Task<AuthUnsuccessfulResponse> RegisterUnsuccessful()
    {
        var url = @$"{_url}/api/register";
        var auth = new AuthRequest() { Email = "sydney@fife" };
        return await _httpService.SendAsync<AuthUnsuccessfulResponse>(url, HttpMethod.Post, "application/json", auth);
    }

    public async Task<LoginSuccessfulResponse> LoginSuccessful()
    {
        var url = @$"{_url}/api/login";
        var auth = new AuthRequest() { Email = "eve.holt@reqres.in", Password = "cityslicka" };
        return await _httpService.SendAsync<LoginSuccessfulResponse>(url, HttpMethod.Post, "application/json", auth);
    }

    public async Task<AuthUnsuccessfulResponse> LoginUnsuccessful()
    {
        var url = @$"{_url}/api/login";
        var auth = new AuthRequest() { Email = "peter@klaven" };
        return await _httpService.SendAsync<AuthUnsuccessfulResponse>(url, HttpMethod.Post, "application/json", auth);
    }
}