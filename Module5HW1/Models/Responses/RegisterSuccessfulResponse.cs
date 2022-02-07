using Newtonsoft.Json;

namespace Module5HW1.Models.Responses;

public class RegisterSuccessfulResponse
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("token")]
    public string? Token { get; set; }
}