using Module5HW1.Models.Configs;

namespace Module5HW1.Provider.Abstraction;

public interface IConfigProvider
{
    public Config Config { get; }
}