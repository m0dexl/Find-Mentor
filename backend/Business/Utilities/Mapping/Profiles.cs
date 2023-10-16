using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<User, UserProfileDto>().ReverseMap(); //kullanıcı görüntüleme

        CreateMap<CategoryCreateDto, Category>().ReverseMap();
        CreateMap<CategoryUpdateDto, Category>().ReverseMap();
        CreateMap<Category, CategoryInfoDto>().ReverseMap();

        CreateMap<NoticeCreateDto, Notice>().ReverseMap();
        CreateMap<NoticeUpdateDto, Notice>().ReverseMap();
        CreateMap<Notice, NoticeInfoDto>().ReverseMap();

        CreateMap<NoticeFormAnswerCreateDto,NoticeFormAnswer >().ReverseMap();
        CreateMap<NoticeFormAnswer, NoticeFormAnswerInfoDto>().ReverseMap();
    }
}