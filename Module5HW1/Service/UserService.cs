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

    public async Task<RootResponse<UserDto>> GetListOfUsers()
    {
        var url = @$"{_url}/api/users?page=2";
        return await _httpService.SendAsync<RootResponse<UserDto>>(url, HttpMethod.Get, "application/json");
    }

    public async Task<SingleResponse<UserDto>> GetSingleUser()
    {
        var url = @$"{_url}/api/users/2";
        return await _httpService.SendAsync<SingleResponse<UserDto>>(url, HttpMethod.Get, "application/json");
    }

    public async Task<SingleUserNotFoundResponse> GetSingleUserNotFound()
    {
        var url = @$"{_url}/api/users/23";
        return await _httpService.SendAsync<SingleUserNotFoundResponse>(url, HttpMethod.Get, "application/json");
    }

    public async Task<UserCreateResponse> CreateUser()
    {
        var url = @$"{_url}/api/users";
        var user = new UserRequest() { Name = "morpheus", Job = "leader" };
        return await _httpService.SendAsync<UserCreateResponse>(url, HttpMethod.Post, "application/json", user);
    }

    public async Task<UserUpdateResponse> UpdateUserPut()
    {
        var url = @$"{_url}/api/users/2";
        var user = new UserRequest() { Name = "morpheus", Job = "zion resident" };
        return await _httpService.SendAsync<UserUpdateResponse>(url, HttpMethod.Put, "application/json", user);
    }

    public async Task<UserUpdateResponse> UpdateUserPatch()
    {
        var url = @$"{_url}/api/users/2";
        var user = new UserRequest() { Name = "morpheus", Job = "zion resident" };
        return await _httpService.SendAsync<UserUpdateResponse>(url, HttpMethod.Patch, "application/json", user);
    }

    public async Task<DeleteUserResponse> DeleteUser()
    {
        var url = @$"{_url}/api/users/2";
        return await _httpService.SendAsync<DeleteUserResponse>(url, HttpMethod.Delete, "application/json");
    }

    public async Task<RootResponse<UserDto>> GetDelayedResponse()
    {
        var url = @$"{_url}/api/users/?delay=3";
        return await _httpService.SendAsync<RootResponse<UserDto>>(url, HttpMethod.Get, "application/json");
    }
}