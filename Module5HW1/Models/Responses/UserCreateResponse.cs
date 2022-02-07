using Newtonsoft.Json;

namespace Module5HW1.Models.Responses;

public class UserCreateResponse
{
    [JsonProperty("name")]
    public string Name { get; set; } = default!;

    [JsonProperty("job")]
    public string Job { get; set; } = default!;

    [JsonProperty("id")]
    public string Id { get; set; } = default!;

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }
}