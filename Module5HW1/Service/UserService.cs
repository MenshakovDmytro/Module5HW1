using System.Text;
using Module5HW1.Models;
using Module5HW1.Models.Requests;
using Module5HW1.Models.Responses;
using Module5HW1.Service.Abstraction;
using Newtonsoft.Json;

namespace Module5HW1.Service;

public class UserService : IUserService
{
    private readonly string _url;
    private readonly IHttpService _httpService;

    public UserService(IHttpService httpService, IConfigService configService)
    {
        _url = configService.RequestConfig.RequestAddress;
        _httpService = httpService;
    }

    public async Task GetListOfUsers()
    {
        var url = $"{_url}/api/users?page=2";
        await _httpService.SendAsync<RootResponse<UserDto>>(url, HttpMethod.Get);
    }

    public async Task GetSingleUser()
    {
        var url = $"{_url}/api/users/2";
        await _httpService.SendAsync<SingleResponse<UserDto>>(url, HttpMethod.Get);
    }

    public async Task GetSingleUserNotFound()
    {
        var url = $"{_url}/api/users/23";
        await _httpService.SendAsync<SingleUserNotFoundResponse>(url, HttpMethod.Get);
    }

    public async Task CreateUser()
    {
        var url = $"{_url}/api/users";
        var user = new UserRequest() { Name = "morpheus", Job = "leader" };
        var httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
        await _httpService.SendAsync<UserCreateResponse>(url, HttpMethod.Post, httpContent);
    }

    public async Task UpdateUserPut()
    {
        var url = $"{_url}/api/users/2";
        var user = new UserRequest() { Name = "morpheus", Job = "zion resident" };
        var httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
        await _httpService.SendAsync<UserUpdateResponse>(url, HttpMethod.Put, httpContent);
    }

    public async Task UpdateUserPatch()
    {
        var url = $"{_url}/api/users/2";
        var user = new UserRequest() { Name = "morpheus", Job = "zion resident" };
        var httpContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
        await _httpService.SendAsync<UserUpdateResponse>(url, HttpMethod.Patch, httpContent);
    }

    public async Task DeleteUser()
    {
        var url = $"{_url}/api/users/2";
        await _httpService.SendAsync<DeleteUserResponse>(url, HttpMethod.Delete);
    }

    public async Task GetDelayedResponse()
    {
        var url = $"{_url}/api/users/?delay=3";
        await _httpService.SendAsync<RootResponse<UserDto>>(url, HttpMethod.Get);
    }
}