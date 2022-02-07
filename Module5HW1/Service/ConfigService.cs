using Module5HW1.Models.Configs;
using Module5HW1.Provider.Abstraction;
using Module5HW1.Service.Abstraction;

namespace Module5HW1.Service;

public class ConfigService : IConfigService
{
    private readonly IConfigProvider _configProvider;

    public ConfigService(IConfigProvider configProvider)
    {
        _configProvider = configProvider;
    }

    public RequestConfig RequestConfig => _configProvider.Config.RequestConfig;
}