using Microsoft.AspNetCore.Identity;
using ShortLink.Core.Dtos;
using ShortLink.Core.Models;

namespace ShortLink.Service.Interfaces;

public interface IUserAuthenticationRepository
{
    Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userForRegistration);
    Task<bool> ValidateUserAsync(UserLoginDto loginDto); 
    Task<string> CreateTokenAsync(); 
}

