using System.Text.Json.Serialization;

namespace API.Entities;

public class Photo
{
    public int Id { get; set; }  // Using an int here because the instructor wanted it so.
    public required string Url { get; set; }
    public string? Publicid { get; set; }

    // Navigation properties
    [JsonIgnore]
    public Member Member { get; set; } = null!;
    public string MemberId { get; set; } = null!;
}
