using AutoMapper;
using ShortLink.Core.Dtos;
using ShortLink.Core.Models;

namespace ShortLink.Core.Mappings;

public class TeacherMappingProfile : Profile
{
    public TeacherMappingProfile()
    {
        CreateMap<LinkEntity, TeacherDto>();

        CreateMap<TeacherCreationDto, LinkEntity>();

        CreateMap<TeacherUpdateDto, LinkEntity>().ReverseMap();
    }
}
