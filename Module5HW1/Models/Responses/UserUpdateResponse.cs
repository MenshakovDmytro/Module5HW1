using Newtonsoft.Json;

namespace Module5HW1.Models.Responses;

public class UserUpdateResponse
{
    [JsonProperty("name")]
    public string Name { get; set; } = default!;

    [JsonProperty("job")]
    public string Job { get; set; } = default!;

    [JsonProperty("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}