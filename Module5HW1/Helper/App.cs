using Module5HW1.Service.Abstraction;

namespace Module5HW1.Helper;

public class App
{
    private readonly IUserService _userService;
    private readonly IResourceService _resourceService;
    private readonly IAuthService _authService;

    public App(IUserService userService, IResourceService resourceService, IAuthService authService)
    {
        _userService = userService;
        _resourceService = resourceService;
        _authService = authService;
    }

    public async Task Run()
    {
        var tasks = new List<Task>();
        tasks.Add(_userService.GetListOfUsers());
        tasks.Add(_userService.GetSingleUser());
        tasks.Add(_userService.GetSingleUserNotFound());
        tasks.Add(_resourceService.GetListResource());
        tasks.Add(_resourceService.GetSingleResource());
        tasks.Add(_resourceService.GetSingleResourceNotFound());
        tasks.Add(_userService.CreateUser());
        tasks.Add(_userService.UpdateUserPut());
        tasks.Add(_userService.UpdateUserPatch());
        tasks.Add(_userService.DeleteUser());
        tasks.Add(_authService.RegisterSuccessful());
        tasks.Add(_authService.RegisterUnsuccessful());
        tasks.Add(_authService.LoginSuccessful());
        tasks.Add(_authService.LoginUnsuccessful());
        tasks.Add(_userService.GetDelayedResponse());
        await Task.WhenAll(tasks.ToArray());
    }
}