using Microsoft.Extensions.DependencyInjection;
using Module5HW1.Provider;
using Module5HW1.Provider.Abstraction;
using Module5HW1.Service;
using Module5HW1.Service.Abstraction;

namespace Module5HW1.Helper;

public class Starter
{
    public async Task Run()
    {
        var starter = new ServiceCollection()
            .AddSingleton<IConfigProvider, ConfigProvider>()
            .AddSingleton<IConfigService, ConfigService>()
            .AddSingleton<IHttpService, HttpService>()
            .AddTransient<IUserService, UserService>()
            .AddTransient<IResourceService, ResourceService>()
            .AddTransient<IAuthService, AuthService>()
            .AddScoped<App>()
            .BuildServiceProvider();
        var app = starter.GetService<App>();
        await app.Run();
    }
}