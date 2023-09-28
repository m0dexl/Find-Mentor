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
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<User, Models.Response.UserProfileDto>(); //kullanıcı görüntüleme

        CreateMap<MentorCreateDto, Mentor>();
        CreateMap<MentorUpdateDto, Mentor>();
        CreateMap<Mentor, MentorInfoDto>();
       

        CreateMap<CategoriesCreateDto, Categories>();
        CreateMap<CategoriesUpdateDto, Categories>();
        CreateMap<Categories, CategoriesInfoDto>();

        CreateMap<MentorCategoryCreateDto, MentorCategory>();
        CreateMap<MentorCategoryUpdateDto, MentorCategory>();
        CreateMap<MentorCategory, MentorCategoryInfoDto>();


        CreateMap<MentorFormCreateDto, Mentor>();
        CreateMap<MentorFormUpdateDto, Mentor>();
        CreateMap<MentorForm, MentorFormInfoDto>();

        CreateMap<FormCreateDto,Form>();
        CreateMap<FormUpdateDto, Form>();
        CreateMap<Form, FormInfoDto>();

        CreateMap<FormQuestionCreateDto,FormQuestion>();
        CreateMap<FormQuestionUpdateDto, FormQuestion>();
        CreateMap<FormQuestion, FormQuestionInfoDto>();

        CreateMap<QuestionsCreateDto,Questions>();
        CreateMap<QuestionsUpdateDto,Questions>();
        CreateMap<Questions,QuestionsInfoDto>();






    }
}