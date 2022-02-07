using Module5HW1.Models;
using Module5HW1.Models.Responses;
using Module5HW1.Service.Abstraction;

namespace Module5HW1.Service;

public class ResourceService : IResourceService
{
    private readonly string _url;
    private readonly IHttpService _httpService;

    public ResourceService(IHttpService httpService, IConfigService configService)
    {
        _url = configService.RequestConfig.RequestAddress;
        _httpService = httpService;
    }

    public async Task GetListResource()
    {
        var url = $"{_url}/api/unknown";
        await _httpService.SendAsync<RootResponse<ResourceDto>>(url, HttpMethod.Get);
    }

    public async Task GetSingleResource()
    {
        var url = $"{_url}/api/unknown/2";
        await _httpService.SendAsync<SingleResponse<ResourceDto>>(url, HttpMethod.Get);
    }

    public async Task GetSingleResourceNotFound()
    {
        var url = $"{_url}/api/unknown/23";
        await _httpService.SendAsync<SingleResourceNotFoundResponse>(url, HttpMethod.Get);
    }
}