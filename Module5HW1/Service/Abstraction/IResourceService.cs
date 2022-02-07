namespace Module5HW1.Service.Abstraction;

public interface IResourceService
{
    public Task GetListResource();
    public Task GetSingleResource();
    public Task GetSingleResourceNotFound();
}