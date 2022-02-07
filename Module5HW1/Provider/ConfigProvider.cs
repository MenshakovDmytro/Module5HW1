using Module5HW1.Models.Configs;
using Module5HW1.Provider.Abstraction;
using Newtonsoft.Json;

namespace Module5HW1.Provider;

public class ConfigProvider : IConfigProvider
{
    private const string ConfigFile = "appconfig.json";

    private readonly Config _config;

    public ConfigProvider()
    {
        _config = LoadConfig().GetAwaiter().GetResult();
    }

    public Config Config => _config;

    private async Task<Config> LoadConfig()
    {
        var configFile = await File.ReadAllTextAsync(ConfigFile);
        return JsonConvert.DeserializeObject<Config>(configFile);
    }
}