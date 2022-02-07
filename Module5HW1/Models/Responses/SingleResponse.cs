using Newtonsoft.Json;

namespace Module5HW1.Models.Responses;

public class SingleResponse<T>
{
    [JsonProperty("data")]
    public T Data { get; set; } = default!;

    [JsonProperty("support")]
    public SupportDto Support { get; set; } = default!;
}