using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();

        CreateMap<MentorCreateDto, Mentor>();
        CreateMap<MentorUpdateDto, Mentor>();

        CreateMap<MentorFormCreateDto, Mentor>();
        CreateMap<MentorFormUpdateDto, Mentor>();



    }
}