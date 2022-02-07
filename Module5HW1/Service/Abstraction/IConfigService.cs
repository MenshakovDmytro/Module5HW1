using Module5HW1.Models.Configs;

namespace Module5HW1.Service.Abstraction;

public interface IConfigService
{
    public RequestConfig RequestConfig { get; }
}