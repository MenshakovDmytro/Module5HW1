﻿using Newtonsoft.Json;

namespace Module5HW1.Models;

public class SupportDto
{
    [JsonProperty("url")]
    public string Url { get; set; } = default!;

    [JsonProperty("text")]
    public string Text { get; set; } = default!;
}