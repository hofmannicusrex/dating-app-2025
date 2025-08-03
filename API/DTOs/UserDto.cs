using System;

namespace API.DTOs;

public class UserDto
{
    public required string Id { get; set; }
    public required string Email { get; set; }
    public required string DisplayName { get; set; }
    public string? ImageUrl { get; set; }  // Users will not be required to add an image when creating their profile.
    public required string Token { get; set; }
}
