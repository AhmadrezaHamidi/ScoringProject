using Microsoft.AspNetCore.Identity;

namespace ShortLink.Core.Models;

public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
