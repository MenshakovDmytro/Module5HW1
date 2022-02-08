using Module5HW1.Models;
using Module5HW1.Models.Responses;

namespace Module5HW1.Service.Abstraction;

public interface IUserService
{
    public Task<RootResponse<UserDto>> GetListOfUsers();
    public Task<SingleResponse<UserDto>> GetSingleUser();
    public Task<SingleUserNotFoundResponse> GetSingleUserNotFound();
    public Task<UserCreateResponse> CreateUser();
    public Task<UserUpdateResponse> UpdateUserPut();
    public Task<UserUpdateResponse> UpdateUserPatch();
    public Task<DeleteUserResponse> DeleteUser();
    public Task<RootResponse<UserDto>> GetDelayedResponse();
}