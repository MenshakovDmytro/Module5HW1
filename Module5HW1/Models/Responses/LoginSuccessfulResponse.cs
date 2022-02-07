using Newtonsoft.Json;

namespace Module5HW1.Models.Responses;

public class LoginSuccessfulResponse
{
    [JsonProperty("token")]
    public string Token { get; set; } = default!;
}