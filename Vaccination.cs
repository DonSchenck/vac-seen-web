using System.Text.Json.Serialization;

namespace vac_seen_web;

public class Vaccination
{
    [JsonPropertyName("date")]
    public String? date { get; set; }
    [JsonPropertyName("countryCode")]
    public string? countryCode { get; set; }
    [JsonPropertyName("count")]
    public int? count { get; set; }
}
