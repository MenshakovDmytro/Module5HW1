using Module5HW1.Models;
using Module5HW1.Models.Responses;

namespace Module5HW1.Service.Abstraction;

public interface IResourceService
{
    public Task<RootResponse<ResourceDto>> GetListResource();
    public Task<SingleResponse<ResourceDto>> GetSingleResource();
    public Task<SingleResourceNotFoundResponse> GetSingleResourceNotFound();
}