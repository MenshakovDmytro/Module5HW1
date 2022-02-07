namespace Module5HW1.Service.Abstraction;

public interface IAuthService
{
    public Task RegisterSuccessful();
    public Task RegisterUnsuccessful();
    public Task LoginSuccessful();
    public Task LoginUnsuccessful();
}