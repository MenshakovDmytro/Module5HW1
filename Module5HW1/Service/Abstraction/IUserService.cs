namespace Module5HW1.Service.Abstraction;

public interface IUserService
{
    public Task GetListOfUsers();
    public Task GetSingleUser();
    public Task GetSingleUserNotFound();
    public Task CreateUser();
    public Task UpdateUserPut();
    public Task UpdateUserPatch();
    public Task DeleteUser();
    public Task GetDelayedResponse();
}