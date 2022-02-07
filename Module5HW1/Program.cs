using Module5HW1.Helper;

namespace Module5HW1;

public class Program
{
    public static async Task Main(string[] args)
    {
        var starter = new Starter();
        await starter.Run();
    }
}