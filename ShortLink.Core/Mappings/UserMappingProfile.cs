using AutoMapper;
using ShortLink.Core.Dtos;
using ShortLink.Core.Models;

namespace ShortLink.Core.Mappings;
public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<UserRegistrationDto, User>();
    }
}
