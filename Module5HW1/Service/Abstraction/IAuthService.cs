using Module5HW1.Models.Responses;

namespace Module5HW1.Service.Abstraction;

public interface IAuthService
{
    public Task<RegisterSuccessfulResponse> RegisterSuccessful();
    public Task<AuthUnsuccessfulResponse> RegisterUnsuccessful();
    public Task<LoginSuccessfulResponse> LoginSuccessful();
    public Task<AuthUnsuccessfulResponse> LoginUnsuccessful();
}