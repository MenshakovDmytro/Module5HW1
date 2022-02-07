using Newtonsoft.Json;

namespace Module5HW1.Models.Responses;

public class AuthUnsuccessfulResponse
{
    [JsonProperty("error")]
    public string Error { get; set; } = default!;
}